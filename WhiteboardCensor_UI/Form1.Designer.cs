
namespace WhiteboardCensor_UI
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.prgProgress = new System.Windows.Forms.ProgressBar();
            this.btnFullresInput = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbShowCompressedPreview = new System.Windows.Forms.CheckBox();
            this.chbShowFullresPreview = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numWBID = new System.Windows.Forms.NumericUpDown();
            this.chbSaveInvalids = new System.Windows.Forms.CheckBox();
            this.btnInvalidOutput = new System.Windows.Forms.Button();
            this.txbInvalidOutput = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.chbFullresAsCompressed = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSegmentOutput = new System.Windows.Forms.Button();
            this.btnCompressedInput = new System.Windows.Forms.Button();
            this.txbSegmentOutput = new System.Windows.Forms.TextBox();
            this.txbCompressedInput = new System.Windows.Forms.TextBox();
            this.txbFullresInput = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numCheckResolution = new System.Windows.Forms.NumericUpDown();
            this.numCheckerY = new System.Windows.Forms.NumericUpDown();
            this.numCheckerX = new System.Windows.Forms.NumericUpDown();
            this.btnLoadPreview = new System.Windows.Forms.Button();
            this.trbPreview = new System.Windows.Forms.TrackBar();
            this.grbStatus = new System.Windows.Forms.GroupBox();
            this.pbxFullres = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlPanel = new System.Windows.Forms.Panel();
            this.pbxChecker = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnStartCensor = new System.Windows.Forms.Button();
            this.lblTotalFrames = new System.Windows.Forms.Label();
            this.lblCheckedFrames = new System.Windows.Forms.Label();
            this.lblValidFrames = new System.Windows.Forms.Label();
            this.lblInvalidFrames = new System.Windows.Forms.Label();
            this.lblSegments = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pbxCaptureStatus = new System.Windows.Forms.PictureBox();
            this.btnStopCensor = new System.Windows.Forms.Button();
            this.bgwWorker = new System.ComponentModel.BackgroundWorker();
            this.ofdFullresInput = new System.Windows.Forms.OpenFileDialog();
            this.ofdCompressedInput = new System.Windows.Forms.OpenFileDialog();
            this.fbdSegmentOutput = new System.Windows.Forms.FolderBrowserDialog();
            this.fbdInvalidOutput = new System.Windows.Forms.FolderBrowserDialog();
            this.tmrUIUpdate = new System.Windows.Forms.Timer(this.components);
            this.Control = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWBID)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCheckResolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCheckerY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCheckerX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbPreview)).BeginInit();
            this.grbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFullres)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChecker)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCaptureStatus)).BeginInit();
            this.Control.SuspendLayout();
            this.SuspendLayout();
            // 
            // prgProgress
            // 
            this.prgProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgProgress.Location = new System.Drawing.Point(7, 66);
            this.prgProgress.Margin = new System.Windows.Forms.Padding(4);
            this.prgProgress.Name = "prgProgress";
            this.prgProgress.Size = new System.Drawing.Size(836, 34);
            this.prgProgress.TabIndex = 0;
            // 
            // btnFullresInput
            // 
            this.btnFullresInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFullresInput.Location = new System.Drawing.Point(420, 77);
            this.btnFullresInput.Name = "btnFullresInput";
            this.btnFullresInput.Size = new System.Drawing.Size(35, 27);
            this.btnFullresInput.TabIndex = 2;
            this.btnFullresInput.Text = "...";
            this.btnFullresInput.UseVisualStyleBackColor = true;
            this.btnFullresInput.Click += new System.EventHandler(this.btnFullresInput_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbShowCompressedPreview);
            this.groupBox1.Controls.Add(this.chbShowFullresPreview);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.numWBID);
            this.groupBox1.Controls.Add(this.chbSaveInvalids);
            this.groupBox1.Controls.Add(this.btnInvalidOutput);
            this.groupBox1.Controls.Add(this.txbInvalidOutput);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.chbFullresAsCompressed);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSegmentOutput);
            this.groupBox1.Controls.Add(this.btnCompressedInput);
            this.groupBox1.Controls.Add(this.txbSegmentOutput);
            this.groupBox1.Controls.Add(this.btnFullresInput);
            this.groupBox1.Controls.Add(this.txbCompressedInput);
            this.groupBox1.Controls.Add(this.txbFullresInput);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 290);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source / Destination";
            // 
            // chbShowCompressedPreview
            // 
            this.chbShowCompressedPreview.AutoSize = true;
            this.chbShowCompressedPreview.Location = new System.Drawing.Point(251, 48);
            this.chbShowCompressedPreview.Name = "chbShowCompressedPreview";
            this.chbShowCompressedPreview.Size = new System.Drawing.Size(201, 23);
            this.chbShowCompressedPreview.TabIndex = 18;
            this.chbShowCompressedPreview.Text = "Show Compressed Preview";
            this.chbShowCompressedPreview.UseVisualStyleBackColor = true;
            // 
            // chbShowFullresPreview
            // 
            this.chbShowFullresPreview.AutoSize = true;
            this.chbShowFullresPreview.Location = new System.Drawing.Point(251, 24);
            this.chbShowFullresPreview.Name = "chbShowFullresPreview";
            this.chbShowFullresPreview.Size = new System.Drawing.Size(164, 23);
            this.chbShowFullresPreview.TabIndex = 17;
            this.chbShowFullresPreview.Text = "Show Fullres Preview";
            this.chbShowFullresPreview.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "Whiteboard ID (Number)";
            // 
            // numWBID
            // 
            this.numWBID.Location = new System.Drawing.Point(183, 23);
            this.numWBID.Name = "numWBID";
            this.numWBID.Size = new System.Drawing.Size(62, 27);
            this.numWBID.TabIndex = 15;
            this.numWBID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chbSaveInvalids
            // 
            this.chbSaveInvalids.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbSaveInvalids.AutoSize = true;
            this.chbSaveInvalids.Location = new System.Drawing.Point(305, 210);
            this.chbSaveInvalids.Name = "chbSaveInvalids";
            this.chbSaveInvalids.Size = new System.Drawing.Size(156, 23);
            this.chbSaveInvalids.TabIndex = 11;
            this.chbSaveInvalids.Text = "Save Invalid Frames";
            this.chbSaveInvalids.UseVisualStyleBackColor = true;
            this.chbSaveInvalids.CheckedChanged += new System.EventHandler(this.chbSaveInvalids_CheckedChanged);
            // 
            // btnInvalidOutput
            // 
            this.btnInvalidOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInvalidOutput.Enabled = false;
            this.btnInvalidOutput.Location = new System.Drawing.Point(420, 233);
            this.btnInvalidOutput.Name = "btnInvalidOutput";
            this.btnInvalidOutput.Size = new System.Drawing.Size(35, 27);
            this.btnInvalidOutput.TabIndex = 10;
            this.btnInvalidOutput.Text = "...";
            this.btnInvalidOutput.UseVisualStyleBackColor = true;
            this.btnInvalidOutput.Click += new System.EventHandler(this.btnInvalidOutput_Click);
            // 
            // txbInvalidOutput
            // 
            this.txbInvalidOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbInvalidOutput.Enabled = false;
            this.txbInvalidOutput.Location = new System.Drawing.Point(6, 233);
            this.txbInvalidOutput.Name = "txbInvalidOutput";
            this.txbInvalidOutput.ReadOnly = true;
            this.txbInvalidOutput.Size = new System.Drawing.Size(408, 27);
            this.txbInvalidOutput.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 211);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(224, 19);
            this.label15.TabIndex = 8;
            this.label15.Text = "Invalid Frame Output Destination";
            // 
            // chbFullresAsCompressed
            // 
            this.chbFullresAsCompressed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbFullresAsCompressed.AutoSize = true;
            this.chbFullresAsCompressed.Location = new System.Drawing.Point(270, 106);
            this.chbFullresAsCompressed.Name = "chbFullresAsCompressed";
            this.chbFullresAsCompressed.Size = new System.Drawing.Size(185, 23);
            this.chbFullresAsCompressed.TabIndex = 7;
            this.chbFullresAsCompressed.Text = "Use fullres for detecting";
            this.chbFullresAsCompressed.UseVisualStyleBackColor = true;
            this.chbFullresAsCompressed.CheckedChanged += new System.EventHandler(this.chbFullresAsCompressed_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Output Destination";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Compressed Input File (*.mp4)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fullres Input File (*.mp4)";
            // 
            // btnSegmentOutput
            // 
            this.btnSegmentOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSegmentOutput.Location = new System.Drawing.Point(420, 181);
            this.btnSegmentOutput.Name = "btnSegmentOutput";
            this.btnSegmentOutput.Size = new System.Drawing.Size(35, 27);
            this.btnSegmentOutput.TabIndex = 4;
            this.btnSegmentOutput.Text = "...";
            this.btnSegmentOutput.UseVisualStyleBackColor = true;
            this.btnSegmentOutput.Click += new System.EventHandler(this.btnSegmentOutput_Click);
            // 
            // btnCompressedInput
            // 
            this.btnCompressedInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompressedInput.Location = new System.Drawing.Point(420, 129);
            this.btnCompressedInput.Name = "btnCompressedInput";
            this.btnCompressedInput.Size = new System.Drawing.Size(35, 27);
            this.btnCompressedInput.TabIndex = 3;
            this.btnCompressedInput.Text = "...";
            this.btnCompressedInput.UseVisualStyleBackColor = true;
            this.btnCompressedInput.Click += new System.EventHandler(this.btnCompressedInput_Click);
            // 
            // txbSegmentOutput
            // 
            this.txbSegmentOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSegmentOutput.Location = new System.Drawing.Point(6, 181);
            this.txbSegmentOutput.Name = "txbSegmentOutput";
            this.txbSegmentOutput.ReadOnly = true;
            this.txbSegmentOutput.Size = new System.Drawing.Size(408, 27);
            this.txbSegmentOutput.TabIndex = 2;
            // 
            // txbCompressedInput
            // 
            this.txbCompressedInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCompressedInput.Location = new System.Drawing.Point(6, 129);
            this.txbCompressedInput.Name = "txbCompressedInput";
            this.txbCompressedInput.ReadOnly = true;
            this.txbCompressedInput.Size = new System.Drawing.Size(408, 27);
            this.txbCompressedInput.TabIndex = 1;
            // 
            // txbFullresInput
            // 
            this.txbFullresInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbFullresInput.Location = new System.Drawing.Point(6, 77);
            this.txbFullresInput.Name = "txbFullresInput";
            this.txbFullresInput.ReadOnly = true;
            this.txbFullresInput.Size = new System.Drawing.Size(408, 27);
            this.txbFullresInput.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numCheckResolution);
            this.groupBox2.Controls.Add(this.numCheckerY);
            this.groupBox2.Controls.Add(this.numCheckerX);
            this.groupBox2.Location = new System.Drawing.Point(15, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 160);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Setup";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(240, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Check Resolution / Frame Steps";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Checker Pixel";
            // 
            // numCheckResolution
            // 
            this.numCheckResolution.Location = new System.Drawing.Point(244, 47);
            this.numCheckResolution.Name = "numCheckResolution";
            this.numCheckResolution.Size = new System.Drawing.Size(67, 27);
            this.numCheckResolution.TabIndex = 2;
            this.numCheckResolution.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numCheckerY
            // 
            this.numCheckerY.Location = new System.Drawing.Point(133, 47);
            this.numCheckerY.Maximum = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            this.numCheckerY.Name = "numCheckerY";
            this.numCheckerY.Size = new System.Drawing.Size(71, 27);
            this.numCheckerY.TabIndex = 1;
            this.numCheckerY.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numCheckerY.ValueChanged += new System.EventHandler(this.numCheckerY_ValueChanged);
            // 
            // numCheckerX
            // 
            this.numCheckerX.Location = new System.Drawing.Point(31, 47);
            this.numCheckerX.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.numCheckerX.Name = "numCheckerX";
            this.numCheckerX.Size = new System.Drawing.Size(71, 27);
            this.numCheckerX.TabIndex = 0;
            this.numCheckerX.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numCheckerX.ValueChanged += new System.EventHandler(this.numCheckerX_ValueChanged);
            // 
            // btnLoadPreview
            // 
            this.btnLoadPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadPreview.Location = new System.Drawing.Point(769, 14);
            this.btnLoadPreview.Name = "btnLoadPreview";
            this.btnLoadPreview.Size = new System.Drawing.Size(74, 51);
            this.btnLoadPreview.TabIndex = 22;
            this.btnLoadPreview.Text = "Load Preview";
            this.btnLoadPreview.UseVisualStyleBackColor = true;
            this.btnLoadPreview.Click += new System.EventHandler(this.btnLoadPreview_Click);
            // 
            // trbPreview
            // 
            this.trbPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trbPreview.Enabled = false;
            this.trbPreview.Location = new System.Drawing.Point(6, 26);
            this.trbPreview.Name = "trbPreview";
            this.trbPreview.Size = new System.Drawing.Size(757, 45);
            this.trbPreview.TabIndex = 13;
            this.trbPreview.Scroll += new System.EventHandler(this.trbPreview_Scroll);
            this.trbPreview.ValueChanged += new System.EventHandler(this.trbPreview_ValueChanged);
            // 
            // grbStatus
            // 
            this.grbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbStatus.Controls.Add(this.btnLoadPreview);
            this.grbStatus.Controls.Add(this.prgProgress);
            this.grbStatus.Controls.Add(this.trbPreview);
            this.grbStatus.Location = new System.Drawing.Point(12, 631);
            this.grbStatus.Name = "grbStatus";
            this.grbStatus.Size = new System.Drawing.Size(850, 111);
            this.grbStatus.TabIndex = 5;
            this.grbStatus.TabStop = false;
            this.grbStatus.Text = "Progress";
            // 
            // pbxFullres
            // 
            this.pbxFullres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxFullres.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbxFullres.Location = new System.Drawing.Point(0, 29);
            this.pbxFullres.Name = "pbxFullres";
            this.pbxFullres.Size = new System.Drawing.Size(377, 267);
            this.pbxFullres.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxFullres.TabIndex = 0;
            this.pbxFullres.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox5.Controls.Add(this.splitContainer1);
            this.groupBox5.Location = new System.Drawing.Point(479, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(383, 627);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Preview";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 23);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.pnlPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.pbxFullres);
            this.splitContainer1.Size = new System.Drawing.Size(377, 601);
            this.splitContainer1.SplitterDistance = 299;
            this.splitContainer1.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 27);
            this.panel1.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 19);
            this.label8.TabIndex = 23;
            this.label8.Text = "Check-Frame";
            // 
            // pnlPanel
            // 
            this.pnlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPanel.AutoScroll = true;
            this.pnlPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlPanel.Controls.Add(this.pbxChecker);
            this.pnlPanel.Location = new System.Drawing.Point(0, 33);
            this.pnlPanel.Name = "pnlPanel";
            this.pnlPanel.Size = new System.Drawing.Size(377, 264);
            this.pnlPanel.TabIndex = 1;
            // 
            // pbxChecker
            // 
            this.pbxChecker.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbxChecker.Location = new System.Drawing.Point(0, 0);
            this.pbxChecker.Name = "pbxChecker";
            this.pbxChecker.Size = new System.Drawing.Size(89, 78);
            this.pbxChecker.TabIndex = 0;
            this.pbxChecker.TabStop = false;
            this.pbxChecker.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxChecker_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 23);
            this.panel2.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 19);
            this.label10.TabIndex = 24;
            this.label10.Text = "Fullres-Frame";
            // 
            // btnStartCensor
            // 
            this.btnStartCensor.Location = new System.Drawing.Point(6, 20);
            this.btnStartCensor.Name = "btnStartCensor";
            this.btnStartCensor.Size = new System.Drawing.Size(77, 49);
            this.btnStartCensor.TabIndex = 12;
            this.btnStartCensor.Text = "Start\r\nCensor";
            this.btnStartCensor.UseVisualStyleBackColor = true;
            this.btnStartCensor.Click += new System.EventHandler(this.btnStartCensor_Click);
            // 
            // lblTotalFrames
            // 
            this.lblTotalFrames.AutoSize = true;
            this.lblTotalFrames.Location = new System.Drawing.Point(6, 23);
            this.lblTotalFrames.Name = "lblTotalFrames";
            this.lblTotalFrames.Size = new System.Drawing.Size(108, 19);
            this.lblTotalFrames.TabIndex = 15;
            this.lblTotalFrames.Text = "Total Frames: 0";
            // 
            // lblCheckedFrames
            // 
            this.lblCheckedFrames.AutoSize = true;
            this.lblCheckedFrames.Location = new System.Drawing.Point(6, 42);
            this.lblCheckedFrames.Name = "lblCheckedFrames";
            this.lblCheckedFrames.Size = new System.Drawing.Size(130, 19);
            this.lblCheckedFrames.TabIndex = 16;
            this.lblCheckedFrames.Text = "Checked Frames: 0";
            // 
            // lblValidFrames
            // 
            this.lblValidFrames.AutoSize = true;
            this.lblValidFrames.Location = new System.Drawing.Point(6, 61);
            this.lblValidFrames.Name = "lblValidFrames";
            this.lblValidFrames.Size = new System.Drawing.Size(108, 19);
            this.lblValidFrames.TabIndex = 17;
            this.lblValidFrames.Text = "Valid Frames: 0";
            // 
            // lblInvalidFrames
            // 
            this.lblInvalidFrames.AutoSize = true;
            this.lblInvalidFrames.Location = new System.Drawing.Point(6, 80);
            this.lblInvalidFrames.Name = "lblInvalidFrames";
            this.lblInvalidFrames.Size = new System.Drawing.Size(119, 19);
            this.lblInvalidFrames.TabIndex = 18;
            this.lblInvalidFrames.Text = "Invalid Frames: 0";
            // 
            // lblSegments
            // 
            this.lblSegments.AutoSize = true;
            this.lblSegments.Location = new System.Drawing.Point(6, 99);
            this.lblSegments.Name = "lblSegments";
            this.lblSegments.Size = new System.Drawing.Size(88, 19);
            this.lblSegments.TabIndex = 19;
            this.lblSegments.Text = "Segments: 0";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(6, 118);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(92, 19);
            this.lblProgress.TabIndex = 20;
            this.lblProgress.Text = "Progress: 0%";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblProgress);
            this.groupBox6.Controls.Add(this.lblTotalFrames);
            this.groupBox6.Controls.Add(this.lblSegments);
            this.groupBox6.Controls.Add(this.lblCheckedFrames);
            this.groupBox6.Controls.Add(this.lblInvalidFrames);
            this.groupBox6.Controls.Add(this.lblValidFrames);
            this.groupBox6.Location = new System.Drawing.Point(234, 474);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(242, 163);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Status";
            // 
            // pbxCaptureStatus
            // 
            this.pbxCaptureStatus.Location = new System.Drawing.Point(89, 20);
            this.pbxCaptureStatus.Name = "pbxCaptureStatus";
            this.pbxCaptureStatus.Size = new System.Drawing.Size(21, 137);
            this.pbxCaptureStatus.TabIndex = 22;
            this.pbxCaptureStatus.TabStop = false;
            // 
            // btnStopCensor
            // 
            this.btnStopCensor.Enabled = false;
            this.btnStopCensor.Location = new System.Drawing.Point(6, 107);
            this.btnStopCensor.Name = "btnStopCensor";
            this.btnStopCensor.Size = new System.Drawing.Size(77, 49);
            this.btnStopCensor.TabIndex = 21;
            this.btnStopCensor.Text = "Stop\r\nCensor";
            this.btnStopCensor.UseVisualStyleBackColor = true;
            this.btnStopCensor.Click += new System.EventHandler(this.btnStopCensor_Click);
            // 
            // bgwWorker
            // 
            this.bgwWorker.WorkerReportsProgress = true;
            this.bgwWorker.WorkerSupportsCancellation = true;
            this.bgwWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwWorker_DoWork);
            this.bgwWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwWorker_ProgressChanged);
            this.bgwWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwWorker_RunWorkerCompleted);
            // 
            // ofdFullresInput
            // 
            this.ofdFullresInput.Filter = "MP4 Files|*.mp4";
            this.ofdFullresInput.Title = "Fullres Input File";
            // 
            // ofdCompressedInput
            // 
            this.ofdCompressedInput.Filter = "MP4 Files|*.mp4";
            this.ofdCompressedInput.Title = "Compressed Input File";
            // 
            // fbdSegmentOutput
            // 
            this.fbdSegmentOutput.Description = "Segment Output";
            // 
            // fbdInvalidOutput
            // 
            this.fbdInvalidOutput.Description = "Invalid Frame Output";
            // 
            // tmrUIUpdate
            // 
            this.tmrUIUpdate.Interval = 300;
            this.tmrUIUpdate.Tick += new System.EventHandler(this.tmrUIUpdate_Tick);
            // 
            // Control
            // 
            this.Control.Controls.Add(this.button1);
            this.Control.Controls.Add(this.pbxCaptureStatus);
            this.Control.Controls.Add(this.btnStartCensor);
            this.Control.Controls.Add(this.btnStopCensor);
            this.Control.Location = new System.Drawing.Point(15, 474);
            this.Control.Name = "Control";
            this.Control.Size = new System.Drawing.Size(213, 163);
            this.Control.TabIndex = 22;
            this.Control.TabStop = false;
            this.Control.Text = "Contol";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 26);
            this.button1.TabIndex = 23;
            this.button1.Text = "Pause";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 754);
            this.Controls.Add(this.Control);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.grbStatus);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(890, 760);
            this.Name = "Form1";
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "Whiteboard Censor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWBID)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCheckResolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCheckerY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCheckerX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbPreview)).EndInit();
            this.grbStatus.ResumeLayout(false);
            this.grbStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFullres)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxChecker)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCaptureStatus)).EndInit();
            this.Control.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar prgProgress;
        private System.Windows.Forms.Button btnFullresInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbFullresAsCompressed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSegmentOutput;
        private System.Windows.Forms.Button btnCompressedInput;
        private System.Windows.Forms.TextBox txbSegmentOutput;
        private System.Windows.Forms.TextBox txbCompressedInput;
        private System.Windows.Forms.TextBox txbFullresInput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numCheckResolution;
        private System.Windows.Forms.NumericUpDown numCheckerY;
        private System.Windows.Forms.NumericUpDown numCheckerX;
        private System.Windows.Forms.GroupBox grbStatus;
        private System.Windows.Forms.PictureBox pbxFullres;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pbxChecker;
        private System.Windows.Forms.CheckBox chbSaveInvalids;
        private System.Windows.Forms.Button btnInvalidOutput;
        private System.Windows.Forms.TextBox txbInvalidOutput;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TrackBar trbPreview;
        private System.Windows.Forms.Button btnStartCensor;
        private System.Windows.Forms.Label lblTotalFrames;
        private System.Windows.Forms.Label lblCheckedFrames;
        private System.Windows.Forms.Label lblValidFrames;
        private System.Windows.Forms.Label lblInvalidFrames;
        private System.Windows.Forms.Label lblSegments;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnStopCensor;
        private System.ComponentModel.BackgroundWorker bgwWorker;
        private System.Windows.Forms.OpenFileDialog ofdFullresInput;
        private System.Windows.Forms.OpenFileDialog ofdCompressedInput;
        private System.Windows.Forms.FolderBrowserDialog fbdSegmentOutput;
        private System.Windows.Forms.FolderBrowserDialog fbdInvalidOutput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numWBID;
        private System.Windows.Forms.CheckBox chbShowCompressedPreview;
        private System.Windows.Forms.CheckBox chbShowFullresPreview;
        private System.Windows.Forms.Timer tmrUIUpdate;
        private System.Windows.Forms.Button btnLoadPreview;
        private System.Windows.Forms.PictureBox pbxCaptureStatus;
        private System.Windows.Forms.Panel pnlPanel;
        private System.Windows.Forms.GroupBox Control;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

