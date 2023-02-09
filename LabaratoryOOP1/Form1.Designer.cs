namespace LabaratoryOOP1
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbColor = new System.Windows.Forms.GroupBox();
            this.pbColor = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.nuBlue = new System.Windows.Forms.NumericUpDown();
            this.nuGreen = new System.Windows.Forms.NumericUpDown();
            this.nuRed = new System.Windows.Forms.NumericUpDown();
            this.redTick = new System.Windows.Forms.Timer(this.components);
            this.autoGenerateColor = new System.Windows.Forms.PictureBox();
            this.greenTick = new System.Windows.Forms.Timer(this.components);
            this.blueTick = new System.Windows.Forms.Timer(this.components);
            this.dtpChooseDate = new System.Windows.Forms.DateTimePicker();
            this.lblBirthDay = new System.Windows.Forms.Label();
            this.redTrackBar = new System.Windows.Forms.TrackBar();
            this.greenTrackBar = new System.Windows.Forms.TrackBar();
            this.BlueTrackBar = new System.Windows.Forms.TrackBar();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.gitHubLink = new System.Windows.Forms.LinkLabel();
            this.btnX = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.timerX = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerY = new System.Windows.Forms.Timer(this.components);
            this.btnXReverse = new System.Windows.Forms.Button();
            this.btnYReverse = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pbPos = new System.Windows.Forms.ProgressBar();
            this.lbTeleporter = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pbOpenDialog = new System.Windows.Forms.PictureBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.gpField = new System.Windows.Forms.Panel();
            this.player = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.gbColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoGenerateColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpenDialog)).BeginInit();
            this.gpField.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbColor
            // 
            this.gbColor.Controls.Add(this.pbColor);
            this.gbColor.Controls.Add(this.btnReset);
            this.gbColor.Controls.Add(this.nuBlue);
            this.gbColor.Controls.Add(this.nuGreen);
            this.gbColor.Controls.Add(this.nuRed);
            this.gbColor.Location = new System.Drawing.Point(12, 12);
            this.gbColor.Name = "gbColor";
            this.gbColor.Size = new System.Drawing.Size(273, 163);
            this.gbColor.TabIndex = 1;
            this.gbColor.TabStop = false;
            this.gbColor.Text = "background color";
            // 
            // pbColor
            // 
            this.pbColor.BackColor = System.Drawing.Color.Black;
            this.pbColor.Location = new System.Drawing.Point(20, 22);
            this.pbColor.Name = "pbColor";
            this.pbColor.Size = new System.Drawing.Size(100, 100);
            this.pbColor.TabIndex = 2;
            this.pbColor.TabStop = false;
            this.pbColor.Click += new System.EventHandler(this.pbColor_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(20, 128);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // nuBlue
            // 
            this.nuBlue.Location = new System.Drawing.Point(147, 99);
            this.nuBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nuBlue.Name = "nuBlue";
            this.nuBlue.Size = new System.Drawing.Size(120, 23);
            this.nuBlue.TabIndex = 5;
            this.nuBlue.ValueChanged += new System.EventHandler(this.nuRed_ValueChanged);
            // 
            // nuGreen
            // 
            this.nuGreen.Location = new System.Drawing.Point(147, 70);
            this.nuGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nuGreen.Name = "nuGreen";
            this.nuGreen.Size = new System.Drawing.Size(120, 23);
            this.nuGreen.TabIndex = 4;
            this.nuGreen.ValueChanged += new System.EventHandler(this.nuRed_ValueChanged);
            // 
            // nuRed
            // 
            this.nuRed.Location = new System.Drawing.Point(147, 41);
            this.nuRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nuRed.Name = "nuRed";
            this.nuRed.Size = new System.Drawing.Size(120, 23);
            this.nuRed.TabIndex = 3;
            this.nuRed.ValueChanged += new System.EventHandler(this.nuRed_ValueChanged);
            // 
            // redTick
            // 
            this.redTick.Enabled = true;
            this.redTick.Interval = 5;
            this.redTick.Tick += new System.EventHandler(this.redTick_Tick);
            // 
            // autoGenerateColor
            // 
            this.autoGenerateColor.Location = new System.Drawing.Point(12, 181);
            this.autoGenerateColor.Name = "autoGenerateColor";
            this.autoGenerateColor.Size = new System.Drawing.Size(120, 120);
            this.autoGenerateColor.TabIndex = 2;
            this.autoGenerateColor.TabStop = false;
            // 
            // greenTick
            // 
            this.greenTick.Enabled = true;
            this.greenTick.Interval = 20;
            this.greenTick.Tick += new System.EventHandler(this.greenTick_Tick);
            // 
            // blueTick
            // 
            this.blueTick.Enabled = true;
            this.blueTick.Interval = 80;
            this.blueTick.Tick += new System.EventHandler(this.blueTick_Tick);
            // 
            // dtpChooseDate
            // 
            this.dtpChooseDate.Location = new System.Drawing.Point(357, 250);
            this.dtpChooseDate.Name = "dtpChooseDate";
            this.dtpChooseDate.Size = new System.Drawing.Size(200, 23);
            this.dtpChooseDate.TabIndex = 3;
            this.dtpChooseDate.ValueChanged += new System.EventHandler(this.dtpChooseDate_ValueChanged);
            // 
            // lblBirthDay
            // 
            this.lblBirthDay.AutoSize = true;
            this.lblBirthDay.Location = new System.Drawing.Point(357, 286);
            this.lblBirthDay.Name = "lblBirthDay";
            this.lblBirthDay.Size = new System.Drawing.Size(38, 15);
            this.lblBirthDay.TabIndex = 4;
            this.lblBirthDay.Text = "label1";
            this.lblBirthDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // redTrackBar
            // 
            this.redTrackBar.Location = new System.Drawing.Point(150, 181);
            this.redTrackBar.Maximum = 500;
            this.redTrackBar.Minimum = 1;
            this.redTrackBar.Name = "redTrackBar";
            this.redTrackBar.Size = new System.Drawing.Size(104, 45);
            this.redTrackBar.TabIndex = 5;
            this.redTrackBar.Value = 10;
            this.redTrackBar.Scroll += new System.EventHandler(this.redTrackBar_Scroll);
            // 
            // greenTrackBar
            // 
            this.greenTrackBar.Location = new System.Drawing.Point(150, 216);
            this.greenTrackBar.Maximum = 500;
            this.greenTrackBar.Minimum = 1;
            this.greenTrackBar.Name = "greenTrackBar";
            this.greenTrackBar.Size = new System.Drawing.Size(104, 45);
            this.greenTrackBar.TabIndex = 6;
            this.greenTrackBar.Value = 5;
            this.greenTrackBar.Scroll += new System.EventHandler(this.greenTrackBar_Scroll);
            // 
            // BlueTrackBar
            // 
            this.BlueTrackBar.Location = new System.Drawing.Point(150, 256);
            this.BlueTrackBar.Maximum = 500;
            this.BlueTrackBar.Minimum = 1;
            this.BlueTrackBar.Name = "BlueTrackBar";
            this.BlueTrackBar.Size = new System.Drawing.Size(104, 45);
            this.BlueTrackBar.TabIndex = 7;
            this.BlueTrackBar.Value = 5;
            this.BlueTrackBar.Scroll += new System.EventHandler(this.BlueTrackBar_Scroll);
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.BackColor = System.Drawing.SystemColors.Menu;
            this.lblRed.ForeColor = System.Drawing.Color.Red;
            this.lblRed.Location = new System.Drawing.Point(260, 181);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(38, 15);
            this.lblRed.TabIndex = 8;
            this.lblRed.Text = "label1";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.ForeColor = System.Drawing.Color.Green;
            this.lblGreen.Location = new System.Drawing.Point(260, 216);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(38, 15);
            this.lblGreen.TabIndex = 9;
            this.lblGreen.Text = "label2";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.ForeColor = System.Drawing.Color.Blue;
            this.lblBlue.Location = new System.Drawing.Point(260, 256);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(38, 15);
            this.lblBlue.TabIndex = 10;
            this.lblBlue.Text = "label3";
            // 
            // gitHubLink
            // 
            this.gitHubLink.AutoSize = true;
            this.gitHubLink.Location = new System.Drawing.Point(291, 21);
            this.gitHubLink.Name = "gitHubLink";
            this.gitHubLink.Size = new System.Drawing.Size(96, 15);
            this.gitHubLink.TabIndex = 11;
            this.gitHubLink.TabStop = true;
            this.gitHubLink.Text = "go to my GitHub";
            this.gitHubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gitHubLink_LinkClicked);
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(402, 111);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(30, 30);
            this.btnX.TabIndex = 13;
            this.btnX.Text = "x";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.MouseEnter += new System.EventHandler(this.btnX_MouseEnter);
            this.btnX.MouseLeave += new System.EventHandler(this.btnX_MouseLeave);
            // 
            // btnY
            // 
            this.btnY.Location = new System.Drawing.Point(357, 75);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(30, 30);
            this.btnY.TabIndex = 15;
            this.btnY.Text = "y";
            this.btnY.UseVisualStyleBackColor = true;
            this.btnY.MouseEnter += new System.EventHandler(this.btnY_MouseEnter);
            this.btnY.MouseLeave += new System.EventHandler(this.btnY_MouseLeave);
            // 
            // timerX
            // 
            this.timerX.Enabled = true;
            this.timerX.Interval = 1;
            this.timerX.Tick += new System.EventHandler(this.timerX_Tick);
            // 
            // timerY
            // 
            this.timerY.Interval = 1;
            this.timerY.Tick += new System.EventHandler(this.timerY_Tick);
            // 
            // btnXReverse
            // 
            this.btnXReverse.Location = new System.Drawing.Point(308, 111);
            this.btnXReverse.Name = "btnXReverse";
            this.btnXReverse.Size = new System.Drawing.Size(30, 30);
            this.btnXReverse.TabIndex = 16;
            this.btnXReverse.Text = "x";
            this.btnXReverse.UseVisualStyleBackColor = true;
            this.btnXReverse.MouseEnter += new System.EventHandler(this.btnXReverse_MouseEnter);
            this.btnXReverse.MouseLeave += new System.EventHandler(this.btnXReverse_MouseLeave);
            // 
            // btnYReverse
            // 
            this.btnYReverse.Location = new System.Drawing.Point(357, 160);
            this.btnYReverse.Name = "btnYReverse";
            this.btnYReverse.Size = new System.Drawing.Size(30, 30);
            this.btnYReverse.TabIndex = 17;
            this.btnYReverse.Text = "y";
            this.btnYReverse.UseVisualStyleBackColor = true;
            this.btnYReverse.MouseEnter += new System.EventHandler(this.btnYReverse_MouseEnter);
            this.btnYReverse.MouseLeave += new System.EventHandler(this.btnYReverse_MouseLeave);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(861, 208);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.Text = "teleport";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pbPos
            // 
            this.pbPos.Location = new System.Drawing.Point(458, 21);
            this.pbPos.Name = "pbPos";
            this.pbPos.Size = new System.Drawing.Size(382, 23);
            this.pbPos.TabIndex = 19;
            this.pbPos.Value = 5;
            // 
            // lbTeleporter
            // 
            this.lbTeleporter.FormattingEnabled = true;
            this.lbTeleporter.ItemHeight = 15;
            this.lbTeleporter.Location = new System.Drawing.Point(861, 21);
            this.lbTeleporter.Name = "lbTeleporter";
            this.lbTeleporter.Size = new System.Drawing.Size(186, 169);
            this.lbTeleporter.TabIndex = 20;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pbOpenDialog
            // 
            this.pbOpenDialog.Location = new System.Drawing.Point(12, 312);
            this.pbOpenDialog.Name = "pbOpenDialog";
            this.pbOpenDialog.Size = new System.Drawing.Size(326, 129);
            this.pbOpenDialog.TabIndex = 21;
            this.pbOpenDialog.TabStop = false;
            this.pbOpenDialog.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(587, 250);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 22;
            this.buttonAdd.Text = "добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(587, 282);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 49);
            this.buttonRemove.TabIndex = 23;
            this.buttonRemove.Text = "убрать четные";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // checkedListBox
            // 
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(701, 250);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(120, 184);
            this.checkedListBox.TabIndex = 24;
            // 
            // gpField
            // 
            this.gpField.Controls.Add(this.player);
            this.gpField.Location = new System.Drawing.Point(458, 63);
            this.gpField.Name = "gpField";
            this.gpField.Size = new System.Drawing.Size(397, 168);
            this.gpField.TabIndex = 25;
            // 
            // player
            // 
            this.player.AutoSize = true;
            this.player.Location = new System.Drawing.Point(56, 42);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(14, 13);
            this.player.TabIndex = 0;
            this.player.TabStop = true;
            this.player.UseVisualStyleBackColor = true;
            this.player.LocationChanged += new System.EventHandler(this.player_LocationChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(861, 242);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(44, 19);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "rgb";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.gpField);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.pbOpenDialog);
            this.Controls.Add(this.lbTeleporter);
            this.Controls.Add(this.pbPos);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnYReverse);
            this.Controls.Add(this.btnXReverse);
            this.Controls.Add(this.btnY);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.gitHubLink);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.BlueTrackBar);
            this.Controls.Add(this.greenTrackBar);
            this.Controls.Add(this.redTrackBar);
            this.Controls.Add(this.lblBirthDay);
            this.Controls.Add(this.dtpChooseDate);
            this.Controls.Add(this.autoGenerateColor);
            this.Controls.Add(this.gbColor);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.DoubleClick += new System.EventHandler(this.niDest_DoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseClick);
            this.gbColor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoGenerateColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpenDialog)).EndInit();
            this.gpField.ResumeLayout(false);
            this.gpField.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox gbColor;
        private NumericUpDown nuBlue;
        private NumericUpDown nuGreen;
        private NumericUpDown nuRed;
        private Button btnReset;
        private PictureBox pbColor;
        private System.Windows.Forms.Timer redTick;
        private PictureBox autoGenerateColor;
        private System.Windows.Forms.Timer greenTick;
        private System.Windows.Forms.Timer blueTick;
        private DateTimePicker dtpChooseDate;
        private Label lblBirthDay;
        private TrackBar redTrackBar;
        private TrackBar greenTrackBar;
        private TrackBar BlueTrackBar;
        private Label lblRed;
        private Label lblGreen;
        private Label lblBlue;
        private LinkLabel gitHubLink;
        private Button btnX;
        private Button btnY;
        private System.Windows.Forms.Timer timerX;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerY;
        private Button btnXReverse;
        private Button btnYReverse;
        private ComboBox comboBox1;
        private ProgressBar pbPos;
        private ListBox lbTeleporter;
        private ToolTip toolTip1;
        private OpenFileDialog openFileDialog1;
        private ColorDialog colorDialog1;
        private PictureBox pbOpenDialog;
        private Button buttonAdd;
        private Button buttonRemove;
        private CheckedListBox checkedListBox;
        private Panel gpField;
        private RadioButton player;
        private CheckBox checkBox1;
    }
}