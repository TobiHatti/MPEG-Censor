using MediaToolkit;
using MediaToolkit.Model;
using MediaToolkit.Options;
using NReco.VideoConverter;
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhiteboardCensor_UI
{
    public partial class Form1 : SfForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region FormControlls

        private void btnFullresInput_Click(object sender, EventArgs e)
        {
            if(ofdFullresInput.ShowDialog() == DialogResult.OK)
            {
                txbFullresInput.Text = ofdFullresInput.FileName;
                if (chbFullresAsCompressed.Checked)
                    txbCompressedInput.Text = ofdFullresInput.FileName;
            } 
        }

        private void btnCompressedInput_Click(object sender, EventArgs e)
        {
            if (ofdCompressedInput.ShowDialog() == DialogResult.OK)
                txbCompressedInput.Text = ofdCompressedInput.FileName;
        }

        private void btnSegmentOutput_Click(object sender, EventArgs e)
        {
            if (fbdSegmentOutput.ShowDialog() == DialogResult.OK)
                txbSegmentOutput.Text = fbdSegmentOutput.SelectedPath;
        }

        private void btnInvalidOutput_Click(object sender, EventArgs e)
        {
            if (fbdInvalidOutput.ShowDialog() == DialogResult.OK)
                txbInvalidOutput.Text = fbdInvalidOutput.SelectedPath;
        }

        private void chbFullresAsCompressed_CheckedChanged(object sender, EventArgs e)
        {
            if(chbFullresAsCompressed.Checked)
            {
                txbCompressedInput.Text = txbFullresInput.Text;
                txbCompressedInput.Enabled = false;
                btnCompressedInput.Enabled = false;
            }
            else
            {
                txbCompressedInput.Text = string.Empty;
                txbCompressedInput.Enabled = true;
                btnCompressedInput.Enabled = true;
            }
        }

        private void chbSaveInvalids_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSaveInvalids.Checked)
            {
                txbInvalidOutput.Enabled = true;
                btnInvalidOutput.Enabled = true;
            }
            else
            {
                txbInvalidOutput.Enabled = false;
                btnInvalidOutput.Enabled = false;
            }
        }

        private void numCheckerX_ValueChanged(object sender, EventArgs e)
        {
            UpdateCompressedPreview();
        }

        private void numCheckerY_ValueChanged(object sender, EventArgs e)
        {
            UpdateCompressedPreview();
        }

        private void trbPreview_ValueChanged(object sender, EventArgs e)
        {
            UpdateManualPreview();
        }

        private void btnStartCensor_Click(object sender, EventArgs e)
        {
            if (InitializeWBCensor())
            {
                btnStartCensor.Enabled = false;
                btnStopCensor.Enabled = true;

                btnFullresInput.Enabled = false;
                btnCompressedInput.Enabled = false;
                btnSegmentOutput.Enabled = false;
                btnInvalidOutput.Enabled = false;
                numWBID.Enabled = false;
                chbFullresAsCompressed.Enabled = false;
                numCheckerX.Enabled = false;
                numCheckerY.Enabled = false;
                numCheckResolution.Enabled = false;
                trbPreview.Enabled = false;
                btnLoadPreview.Enabled = false;


                tmrUIUpdate.Start();
                bgwWorker.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Please fill out all paths and try again", "Missing Paths", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnStopCensor_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to abort the censor progress?", "Abort", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnStartCensor.Enabled = true;
                btnStopCensor.Enabled = false;

                btnFullresInput.Enabled = true;
                btnCompressedInput.Enabled = true;
                btnSegmentOutput.Enabled = true;
                btnInvalidOutput.Enabled = true;
                numWBID.Enabled = true;
                chbFullresAsCompressed.Enabled = true;
                numCheckerX.Enabled = true;
                numCheckerY.Enabled = true;
                numCheckResolution.Enabled = true;
                trbPreview.Enabled = true;
                btnLoadPreview.Enabled = true;

                totalFrames = 0;
                checkedFrames = 0;
                validFrames = 0;
                invalidFrames = 0;
                segments = 0;

                tmrUIUpdate.Stop();
                bgwWorker.CancelAsync();
            }
        }


        #endregion

        private void UpdateFullresPreview()
        {
            if(currentFullresFrame != null)
            {
                pbxFullres.Image = currentFullresFrame;
            }
        }

        private void UpdateCompressedPreview()
        {
            if (currentCheckerFrame != null)
            {
                pbxChecker.Image = currentCheckerFrame;
            }
            pbxChecker.Invalidate();
        }

        FFMpegConverter ffMpeg;
        FFMpegConverter ffMpegPrev;
        Engine engine;
        Engine engine2;
        MediaFile inputFileFullres;
        MediaFile inputFileCompressed;
        private bool InitializeWBCensor()
        {
            if (string.IsNullOrWhiteSpace(txbFullresInput.Text) 
                || string.IsNullOrWhiteSpace(txbCompressedInput.Text) 
                || string.IsNullOrWhiteSpace(txbSegmentOutput.Text) 
                || string.IsNullOrWhiteSpace(txbInvalidOutput.Text)) 
                return false;

            ffMpeg = new FFMpegConverter();
            ffMpegPrev = new FFMpegConverter();
            engine = new Engine();
            engine2 = new Engine();

            inputFileFullres = new MediaFile { Filename = txbFullresInput.Text };
            inputFileCompressed = new MediaFile { Filename = txbCompressedInput.Text };
            engine.GetMetadata(inputFileFullres);
            engine2.GetMetadata(inputFileCompressed);

            string[] dimensions = inputFileCompressed.Metadata.VideoData.FrameSize.Split('x');
            pbxChecker.Width = Convert.ToInt32(dimensions[0]);
            pbxChecker.Height = Convert.ToInt32(dimensions[1]);

            return true;
        }

        private double totalFrames = 0;
        private double checkedFrames = 0;
        private double validFrames = 0;
        private double invalidFrames = 0;
        private double segments = 0;
        private string statusMessage = "";
        private Image currentFullresFrame = null;
        private Image currentCheckerFrame = null;

        private void bgwWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Color validColor = Color.FromArgb(255, 238, 238, 238);

            int fps = (int)inputFileFullres.Metadata.VideoData.Fps;

            totalFrames = inputFileFullres.Metadata.Duration.TotalSeconds * fps;

            float checkResolution = ((float)numCheckResolution.Value / fps);

            bool captureActive = true;
            bool lastCapture = false;

            float currentTime = 0;
            float captureStartTime = 0;
            float captureDuration = 0;

            try
            {
                while (currentTime < inputFileFullres.Metadata.Duration.TotalSeconds)
                {
                    if (bgwWorker.CancellationPending) return;

                    using (MemoryStream ms = new MemoryStream())
                    {
                        // Extract Pixel from source, check if valid segment
                        ffMpeg.GetVideoThumbnail(txbCompressedInput.Text, ms, currentTime);
                        using (Bitmap bmp = (Bitmap)Image.FromStream(ms))
                        {
                            checkedFrames++;

                            // Load Preview Frames
                            if (chbShowCompressedPreview.Checked) currentCheckerFrame = (Image)bmp.Clone();
                            else currentCheckerFrame = null;

                            if (chbShowFullresPreview.Checked && checkedFrames % 15 == 0)
                            {
                                using (MemoryStream msPreview = new MemoryStream())
                                {
                                    ffMpeg.GetVideoThumbnail(txbFullresInput.Text, msPreview, currentTime);
                                    currentFullresFrame = Image.FromStream(msPreview);
                                }
                            }
                            else currentFullresFrame = null;

                            // Check Pixel and Start Capture
                            statusMessage = $"Capturing - Checking Frame {checkedFrames} / {(int)totalFrames}...";
                            if (bmp.GetPixel((int)numCheckerX.Value, (int)numCheckerY.Value) == validColor)
                            {
                                validFrames++;
                                captureActive = true;
                                pbxCaptureStatus.BackColor = Color.LimeGreen;
                                captureDuration += checkResolution;
                            }
                            else
                            {
                                invalidFrames++;

                                if (chbSaveInvalids.Checked)
                                {
                                    using (MemoryStream msInv = new MemoryStream())
                                    {
                                        ffMpeg.GetVideoThumbnail(txbFullresInput.Text, msInv, currentTime);
                                        using (Bitmap bmpInv = (Bitmap)Image.FromStream(msInv))
                                        {
                                            bmpInv.Save(Path.Combine(txbInvalidOutput.Text, $"WB{numWBID.Value}_INV_F{currentTime * fps}_{invalidFrames}.bmp"));
                                        }
                                    }
                                }

                                captureActive = false;
                                pbxCaptureStatus.BackColor = Color.Red;
                            }
                        }
                    }

                    // Start Capture
                    if (!lastCapture && captureActive)
                    {
                        captureStartTime = currentTime;
                    }

                    if (lastCapture && !captureActive)
                    {
                        SaveSegment(captureStartTime + (3 * checkResolution), captureDuration - (3 * checkResolution));
                        captureDuration = 0;
                    }

                    currentTime += checkResolution;
                    lastCapture = captureActive;
                }

                if (captureActive)
                {
                    SaveSegment(captureStartTime + (3 * checkResolution), captureDuration - (3*checkResolution));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"An error occured while censoring WB{numWBID.Value}:\r\n\r\n{ex.Message}","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bgwWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void bgwWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            statusMessage = $"WB Censor Finished!";
            engine.Dispose();
            engine2.Dispose();
        }

        private void SaveSegment(float pStartTime, float pDuration)
        {
            // Only Save clips longer than .5s
            if(pDuration > 0.5)
            {
                segments++;
                statusMessage = $"Capture Stopped - Saving Segment {segments}...";

                var outputFile = new MediaFile(Path.Combine(txbSegmentOutput.Text, $@"WB{numWBID.Value}_SGM{segments}.mp4"));

                var options = new ConversionOptions();
                options.CutMedia(TimeSpan.FromSeconds(pStartTime), TimeSpan.FromSeconds(pDuration));
                engine.Convert(inputFileFullres, outputFile, options);
            }
        }

        private void UpdateStatus()
        {
            lblTotalFrames.Text = $"Total Frames: {(int)totalFrames}";
            lblCheckedFrames.Text = $"Checked Frames: {(int)checkedFrames}";
            lblValidFrames.Text = $"Valid Frames: {(int)validFrames}";
            lblInvalidFrames.Text = $"Invalid Frames: {(int)invalidFrames}";
            lblSegments.Text = $"Segments: {(int)segments}";
            lblProgress.Text = $"Progress: {(checkedFrames / totalFrames)*100}%";

            grbStatus.Text = statusMessage;

            prgProgress.Maximum = (int)totalFrames;
            prgProgress.Value = (int)checkedFrames;
        }

        private void tmrUIUpdate_Tick(object sender, EventArgs e)
        {
            UpdateStatus();
            UpdateFullresPreview();
            UpdateCompressedPreview();
        }

        private void pbxChecker_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Red, (int)numCheckerX.Value, 0, 1, pbxChecker.Height);
            e.Graphics.FillRectangle(Brushes.Red, 0, (int)numCheckerY.Value, pbxChecker.Width, 1);
        }

        private void btnLoadPreview_Click(object sender, EventArgs e)
        {
            if (InitializeWBCensor())
            {
                trbPreview.Minimum = 0;
                trbPreview.Maximum = (int)inputFileFullres.Metadata.Duration.TotalSeconds;
                trbPreview.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please fill out all paths and try again", "Missing Paths", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void trbPreview_Scroll(object sender, EventArgs e)
        {
            UpdateManualPreview();
        }

        private void UpdateManualPreview()
        {
            if (InitializeWBCensor())
            {
                int timestamp = trbPreview.Value;

                using (MemoryStream msPreview = new MemoryStream())
                {
                    ffMpegPrev.GetVideoThumbnail(txbFullresInput.Text, msPreview, timestamp);
                    currentFullresFrame = Image.FromStream(msPreview);
                }

                using (MemoryStream msPreview = new MemoryStream())
                {
                    ffMpegPrev.GetVideoThumbnail(txbCompressedInput.Text, msPreview, timestamp);
                    currentCheckerFrame = Image.FromStream(msPreview);
                }

                UpdateFullresPreview();
                UpdateCompressedPreview();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bgwWorker.IsBusy)
                bgwWorker.CancelAsync();
        }
    }
}
