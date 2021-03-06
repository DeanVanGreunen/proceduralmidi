﻿namespace ProceduralMidi
{
    partial class BoardEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoardEditor));
            this.tmrIterate = new System.Windows.Forms.Timer(this.components);
            this.lblDebug = new System.Windows.Forms.Label();
            this.tmrDrawHighlights = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ddlSamples = new System.Windows.Forms.ComboBox();
            this.rdbSample = new System.Windows.Forms.RadioButton();
            this.rdbMidi = new System.Windows.Forms.RadioButton();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.ddlMidiDevices = new System.Windows.Forms.ComboBox();
            this.sldNoteDuration = new System.Windows.Forms.TrackBar();
            this.lblNoteDuration = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudColumns = new System.Windows.Forms.NumericUpDown();
            this.nudRows = new System.Windows.Forms.NumericUpDown();
            this.sldSpeed = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.sldVolume = new System.Windows.Forms.TrackBar();
            this.ddlInstruments = new System.Windows.Forms.ComboBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRun = new System.Windows.Forms.ToolStripButton();
            this.btnRecord = new System.Windows.Forms.ToolStripButton();
            this.btnStep = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClean = new System.Windows.Forms.ToolStripButton();
            this.btnRandomize = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.status = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.picBoard = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReload = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuImportAutomataUrl = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportOtomataUrl = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFancy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShowGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStates = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReloadSamples = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGenerateMidi = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoadStates = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveStates = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ddlScales = new System.Windows.Forms.ComboBox();
            this.mnuReloadScales = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cellPalette = new ProceduralMidi.Palette();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sldNoteDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sldSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sldVolume)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoard)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrIterate
            // 
            this.tmrIterate.Interval = 250;
            this.tmrIterate.Tick += new System.EventHandler(this.tmrIterate_Tick);
            // 
            // lblDebug
            // 
            this.lblDebug.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebug.Location = new System.Drawing.Point(9, 333);
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Size = new System.Drawing.Size(161, 49);
            this.lblDebug.TabIndex = 3;
            // 
            // tmrDrawHighlights
            // 
            this.tmrDrawHighlights.Enabled = true;
            this.tmrDrawHighlights.Interval = 25;
            this.tmrDrawHighlights.Tick += new System.EventHandler(this.tmrDrawHighlights_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ddlSamples);
            this.groupBox1.Controls.Add(this.rdbSample);
            this.groupBox1.Controls.Add(this.rdbMidi);
            this.groupBox1.Controls.Add(this.lblDebug);
            this.groupBox1.Controls.Add(this.lblSpeed);
            this.groupBox1.Controls.Add(this.ddlMidiDevices);
            this.groupBox1.Controls.Add(this.sldNoteDuration);
            this.groupBox1.Controls.Add(this.lblNoteDuration);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudColumns);
            this.groupBox1.Controls.Add(this.nudRows);
            this.groupBox1.Controls.Add(this.sldSpeed);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.sldVolume);
            this.groupBox1.Controls.Add(this.ddlInstruments);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(478, 3);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(194, 446);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // ddlSamples
            // 
            this.ddlSamples.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSamples.FormattingEnabled = true;
            this.ddlSamples.Location = new System.Drawing.Point(19, 104);
            this.ddlSamples.Name = "ddlSamples";
            this.ddlSamples.Size = new System.Drawing.Size(155, 21);
            this.ddlSamples.TabIndex = 0;
            this.ddlSamples.SelectedIndexChanged += new System.EventHandler(this.ddlSamples_SelectedIndexChanged);
            // 
            // rdbSample
            // 
            this.rdbSample.AutoSize = true;
            this.rdbSample.Location = new System.Drawing.Point(9, 86);
            this.rdbSample.Name = "rdbSample";
            this.rdbSample.Size = new System.Drawing.Size(60, 17);
            this.rdbSample.TabIndex = 1;
            this.rdbSample.Text = "Sample";
            this.rdbSample.UseVisualStyleBackColor = true;
            this.rdbSample.CheckedChanged += new System.EventHandler(this.rdbSample_CheckedChanged);
            // 
            // rdbMidi
            // 
            this.rdbMidi.AutoSize = true;
            this.rdbMidi.Checked = true;
            this.rdbMidi.Location = new System.Drawing.Point(9, 16);
            this.rdbMidi.Name = "rdbMidi";
            this.rdbMidi.Size = new System.Drawing.Size(44, 17);
            this.rdbMidi.TabIndex = 2;
            this.rdbMidi.TabStop = true;
            this.rdbMidi.Text = "Midi";
            this.rdbMidi.UseVisualStyleBackColor = true;
            this.rdbMidi.CheckedChanged += new System.EventHandler(this.rdbMidi_CheckedChanged);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(6, 179);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(134, 13);
            this.lblSpeed.TabIndex = 4;
            this.lblSpeed.Text = "Speed (in ms, current=250)";
            // 
            // ddlMidiDevices
            // 
            this.ddlMidiDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlMidiDevices.FormattingEnabled = true;
            this.ddlMidiDevices.Location = new System.Drawing.Point(18, 59);
            this.ddlMidiDevices.Name = "ddlMidiDevices";
            this.ddlMidiDevices.Size = new System.Drawing.Size(155, 21);
            this.ddlMidiDevices.TabIndex = 18;
            this.ddlMidiDevices.SelectedIndexChanged += new System.EventHandler(this.ddlMidiDevices_SelectedIndexChanged);
            // 
            // sldNoteDuration
            // 
            this.sldNoteDuration.Location = new System.Drawing.Point(18, 297);
            this.sldNoteDuration.Maximum = 3000;
            this.sldNoteDuration.Minimum = 25;
            this.sldNoteDuration.Name = "sldNoteDuration";
            this.sldNoteDuration.Size = new System.Drawing.Size(155, 45);
            this.sldNoteDuration.TabIndex = 17;
            this.sldNoteDuration.TickFrequency = 100;
            this.sldNoteDuration.Value = 250;
            this.sldNoteDuration.ValueChanged += new System.EventHandler(this.sldNoteDuration_ValueChanged);
            // 
            // lblNoteDuration
            // 
            this.lblNoteDuration.AutoSize = true;
            this.lblNoteDuration.Location = new System.Drawing.Point(6, 281);
            this.lblNoteDuration.Name = "lblNoteDuration";
            this.lblNoteDuration.Size = new System.Drawing.Size(167, 13);
            this.lblNoteDuration.TabIndex = 16;
            this.lblNoteDuration.Text = "Note duration (in ms, current=500)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Columns";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Rows";
            // 
            // nudColumns
            // 
            this.nudColumns.Location = new System.Drawing.Point(95, 249);
            this.nudColumns.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudColumns.Name = "nudColumns";
            this.nudColumns.Size = new System.Drawing.Size(69, 20);
            this.nudColumns.TabIndex = 13;
            this.nudColumns.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudColumns.ValueChanged += new System.EventHandler(this.nudColumns_ValueChanged);
            // 
            // nudRows
            // 
            this.nudRows.Location = new System.Drawing.Point(15, 249);
            this.nudRows.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudRows.Name = "nudRows";
            this.nudRows.Size = new System.Drawing.Size(69, 20);
            this.nudRows.TabIndex = 12;
            this.nudRows.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudRows.ValueChanged += new System.EventHandler(this.nudRows_ValueChanged);
            // 
            // sldSpeed
            // 
            this.sldSpeed.Location = new System.Drawing.Point(15, 198);
            this.sldSpeed.Maximum = 1000;
            this.sldSpeed.Minimum = 25;
            this.sldSpeed.Name = "sldSpeed";
            this.sldSpeed.Size = new System.Drawing.Size(155, 45);
            this.sldSpeed.TabIndex = 11;
            this.sldSpeed.TickFrequency = 100;
            this.sldSpeed.Value = 250;
            this.sldSpeed.ValueChanged += new System.EventHandler(this.sldSpeed_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Volume";
            // 
            // sldVolume
            // 
            this.sldVolume.Location = new System.Drawing.Point(15, 147);
            this.sldVolume.Maximum = 127;
            this.sldVolume.Name = "sldVolume";
            this.sldVolume.Size = new System.Drawing.Size(155, 45);
            this.sldVolume.TabIndex = 8;
            this.sldVolume.TickFrequency = 12;
            this.sldVolume.Value = 64;
            this.sldVolume.ValueChanged += new System.EventHandler(this.sldVolume_ValueChanged);
            // 
            // ddlInstruments
            // 
            this.ddlInstruments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlInstruments.FormattingEnabled = true;
            this.ddlInstruments.Location = new System.Drawing.Point(18, 39);
            this.ddlInstruments.Name = "ddlInstruments";
            this.ddlInstruments.Size = new System.Drawing.Size(155, 21);
            this.ddlInstruments.TabIndex = 7;
            this.ddlInstruments.SelectedIndexChanged += new System.EventHandler(this.ddlInstrument_SelectedIndexChanged);
            // 
            // txtNotes
            // 
            this.txtNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotes.Location = new System.Drawing.Point(3, 3);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(249, 20);
            this.txtNotes.TabIndex = 20;
            this.txtNotes.Text = "D3, A3, A#3, C4, D4, E4, F4, A5, C5";
            this.txtNotes.TextChanged += new System.EventHandler(this.txtNotes_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(61, 4);
            this.menuStrip1.Text = "menuStrip1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cellPalette);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox2, 2);
            this.groupBox2.Size = new System.Drawing.Size(63, 446);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Palette";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen,
            this.btnSave,
            this.toolStripSeparator3,
            this.btnRun,
            this.btnRecord,
            this.btnStep,
            this.toolStripSeparator1,
            this.btnClean,
            this.btnRandomize,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(675, 25);
            this.toolStrip1.TabIndex = 18;
            // 
            // btnOpen
            // 
            this.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpen.Image = global::ProceduralMidi.Properties.Resources.control_open_icon;
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(23, 22);
            this.btnOpen.Text = "Open (CTRL+O)";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = global::ProceduralMidi.Properties.Resources.control_save_icon;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(23, 22);
            this.btnSave.Text = "Save";
            this.btnSave.ToolTipText = "Save (CTRL+S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnRun
            // 
            this.btnRun.CheckOnClick = true;
            this.btnRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRun.Image = global::ProceduralMidi.Properties.Resources.control_play_icon;
            this.btnRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(23, 22);
            this.btnRun.Text = "Play";
            this.btnRun.ToolTipText = "Play (F5)";
            this.btnRun.CheckedChanged += new System.EventHandler(this.btnRun_CheckedChanged);
            // 
            // btnRecord
            // 
            this.btnRecord.CheckOnClick = true;
            this.btnRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRecord.Image = global::ProceduralMidi.Properties.Resources.control_record_icon;
            this.btnRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(23, 22);
            this.btnRecord.Text = "Record midi";
            this.btnRecord.ToolTipText = "Record to a midi file (F7)";
            this.btnRecord.CheckedChanged += new System.EventHandler(this.btnRecord_CheckedChanged);
            // 
            // btnStep
            // 
            this.btnStep.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStep.Image = global::ProceduralMidi.Properties.Resources.control_step_icon;
            this.btnStep.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStep.Name = "btnStep";
            this.btnStep.Size = new System.Drawing.Size(23, 22);
            this.btnStep.Text = "Next state";
            this.btnStep.ToolTipText = "Next state (F6)";
            this.btnStep.Click += new System.EventHandler(this.btnStep_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnClean
            // 
            this.btnClean.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClean.Image = global::ProceduralMidi.Properties.Resources.control_clean_icon;
            this.btnClean.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(23, 22);
            this.btnClean.Text = "Clean";
            this.btnClean.ToolTipText = "Clean board";
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnRandomize
            // 
            this.btnRandomize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRandomize.Image = global::ProceduralMidi.Properties.Resources.control_shuffle_icon;
            this.btnRandomize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(23, 22);
            this.btnRandomize.Text = "Randomize";
            this.btnRandomize.Click += new System.EventHandler(this.btnRandomize_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.status.Location = new System.Drawing.Point(0, 501);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(675, 22);
            this.status.TabIndex = 19;
            this.status.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // picBoard
            // 
            this.picBoard.BackColor = System.Drawing.Color.Black;
            this.picBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoard.Location = new System.Drawing.Point(72, 3);
            this.picBoard.Name = "picBoard";
            this.picBoard.Size = new System.Drawing.Size(400, 400);
            this.picBoard.TabIndex = 2;
            this.picBoard.TabStop = false;
            this.picBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.picBoard_Paint);
            this.picBoard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBoard_MouseDown);
            this.picBoard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBoard_MouseMove);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.picBoard, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 49);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(675, 452);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.mnuStates,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(675, 24);
            this.menuStrip2.TabIndex = 23;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpen,
            this.mnuReload,
            this.toolStripSeparator5,
            this.mnuImportAutomataUrl,
            this.mnuExportOtomataUrl,
            this.toolStripSeparator,
            this.mnuSave,
            this.toolStripSeparator2,
            this.mnuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Image = ((System.Drawing.Image)(resources.GetObject("mnuOpen.Image")));
            this.mnuOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuOpen.Size = new System.Drawing.Size(175, 22);
            this.mnuOpen.Text = "&Open";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuReload
            // 
            this.mnuReload.Name = "mnuReload";
            this.mnuReload.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.mnuReload.Size = new System.Drawing.Size(175, 22);
            this.mnuReload.Text = "Reload";
            this.mnuReload.Click += new System.EventHandler(this.mnuReload_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(172, 6);
            // 
            // mnuImportAutomataUrl
            // 
            this.mnuImportAutomataUrl.Name = "mnuImportAutomataUrl";
            this.mnuImportAutomataUrl.Size = new System.Drawing.Size(175, 22);
            this.mnuImportAutomataUrl.Text = "&Import otomata url";
            this.mnuImportAutomataUrl.Click += new System.EventHandler(this.mnuImportAutomataUrl_Click);
            // 
            // mnuExportOtomataUrl
            // 
            this.mnuExportOtomataUrl.Name = "mnuExportOtomataUrl";
            this.mnuExportOtomataUrl.Size = new System.Drawing.Size(175, 22);
            this.mnuExportOtomataUrl.Text = "&Export otomata url";
            this.mnuExportOtomataUrl.Click += new System.EventHandler(this.mnuExportOtomataUrl_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(172, 6);
            // 
            // mnuSave
            // 
            this.mnuSave.Image = ((System.Drawing.Image)(resources.GetObject("mnuSave.Image")));
            this.mnuSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuSave.Size = new System.Drawing.Size(175, 22);
            this.mnuSave.Text = "&Save";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(172, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(175, 22);
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFancy,
            this.mnuShowGrid});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // mnuFancy
            // 
            this.mnuFancy.Checked = true;
            this.mnuFancy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuFancy.Name = "mnuFancy";
            this.mnuFancy.Size = new System.Drawing.Size(153, 22);
            this.mnuFancy.Text = "&Fancy graphics";
            this.mnuFancy.Click += new System.EventHandler(this.mnuFancy_Click);
            // 
            // mnuShowGrid
            // 
            this.mnuShowGrid.Checked = true;
            this.mnuShowGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuShowGrid.Name = "mnuShowGrid";
            this.mnuShowGrid.Size = new System.Drawing.Size(153, 22);
            this.mnuShowGrid.Text = "Show &grid";
            this.mnuShowGrid.Click += new System.EventHandler(this.mnuShowGrid_Click);
            // 
            // mnuStates
            // 
            this.mnuStates.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLoadStates,
            this.mnuSaveStates});
            this.mnuStates.Name = "mnuStates";
            this.mnuStates.Size = new System.Drawing.Size(50, 20);
            this.mnuStates.Text = "&States";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReloadSamples,
            this.mnuReloadScales,
            this.toolStripMenuItem1,
            this.mnuGenerateMidi});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.optionsToolStripMenuItem.Text = "&Tools";
            // 
            // mnuReloadSamples
            // 
            this.mnuReloadSamples.Name = "mnuReloadSamples";
            this.mnuReloadSamples.Size = new System.Drawing.Size(157, 22);
            this.mnuReloadSamples.Text = "Reload &samples";
            this.mnuReloadSamples.Click += new System.EventHandler(this.mnuReloadSamples_Click);
            // 
            // mnuGenerateMidi
            // 
            this.mnuGenerateMidi.Name = "mnuGenerateMidi";
            this.mnuGenerateMidi.Size = new System.Drawing.Size(157, 22);
            this.mnuGenerateMidi.Text = "&Generate midi...";
            this.mnuGenerateMidi.Click += new System.EventHandler(this.mnuGenerateMidi_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(116, 22);
            this.mnuAbout.Text = "&About...";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // mnuLoadStates
            // 
            this.mnuLoadStates.Name = "mnuLoadStates";
            this.mnuLoadStates.Size = new System.Drawing.Size(133, 22);
            this.mnuLoadStates.Text = "&Load states";
            // 
            // mnuSaveStates
            // 
            this.mnuSaveStates.Name = "mnuSaveStates";
            this.mnuSaveStates.Size = new System.Drawing.Size(133, 22);
            this.mnuSaveStates.Text = "&Save states";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel2.Controls.Add(this.ddlScales, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtNotes, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 13);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(394, 24);
            this.tableLayoutPanel2.TabIndex = 22;
            // 
            // ddlScales
            // 
            this.ddlScales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ddlScales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlScales.FormattingEnabled = true;
            this.ddlScales.Location = new System.Drawing.Point(258, 3);
            this.ddlScales.Name = "ddlScales";
            this.ddlScales.Size = new System.Drawing.Size(133, 21);
            this.ddlScales.TabIndex = 21;
            this.ddlScales.SelectedIndexChanged += new System.EventHandler(this.ddlScales_SelectedIndexChanged);
            // 
            // mnuReloadScales
            // 
            this.mnuReloadScales.Name = "mnuReloadScales";
            this.mnuReloadScales.Size = new System.Drawing.Size(157, 22);
            this.mnuReloadScales.Text = "Reload &scales";
            this.mnuReloadScales.Click += new System.EventHandler(this.mnuReloadScales_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(154, 6);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(72, 409);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox3.Size = new System.Drawing.Size(400, 40);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Scale";
            // 
            // cellPalette
            // 
            this.cellPalette.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cellPalette.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cellPalette.FormattingEnabled = true;
            this.cellPalette.ItemHeight = 34;
            this.cellPalette.Location = new System.Drawing.Point(3, 16);
            this.cellPalette.Name = "cellPalette";
            this.cellPalette.Size = new System.Drawing.Size(57, 427);
            this.cellPalette.States = null;
            this.cellPalette.TabIndex = 0;
            // 
            // BoardEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.menuStrip1;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "BoardEditor";
            this.Size = new System.Drawing.Size(675, 523);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sldNoteDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sldSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sldVolume)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoard)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrIterate;
        private System.Windows.Forms.PictureBox picBoard;
        private System.Windows.Forms.Label lblDebug;
        private System.Windows.Forms.Timer tmrDrawHighlights;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ddlInstruments;
        private System.Windows.Forms.TrackBar sldVolume;
        private System.Windows.Forms.TrackBar sldSpeed;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudColumns;
        private System.Windows.Forms.NumericUpDown nudRows;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblNoteDuration;
        private System.Windows.Forms.TrackBar sldNoteDuration;
        private System.Windows.Forms.ContextMenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox ddlMidiDevices;
        private System.Windows.Forms.GroupBox groupBox2;
        private Palette cellPalette;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnRun;
        private System.Windows.Forms.ToolStripButton btnRecord;
        private System.Windows.Forms.ToolStripButton btnStep;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnClean;
        private System.Windows.Forms.ToolStripButton btnRandomize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ComboBox ddlSamples;
        private System.Windows.Forms.RadioButton rdbSample;
        private System.Windows.Forms.RadioButton rdbMidi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuReload;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem mnuImportAutomataUrl;
        private System.Windows.Forms.ToolStripMenuItem mnuExportOtomataUrl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFancy;
        private System.Windows.Forms.ToolStripMenuItem mnuShowGrid;
        private System.Windows.Forms.ToolStripMenuItem mnuStates;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuReloadSamples;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuGenerateMidi;
        private System.Windows.Forms.ToolStripMenuItem mnuLoadStates;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveStates;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox ddlScales;
        private System.Windows.Forms.ToolStripMenuItem mnuReloadScales;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

