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
            this.gpField = new System.Windows.Forms.GroupBox();
            this.player = new System.Windows.Forms.RadioButton();
            this.btnX = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.timerX = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerY = new System.Windows.Forms.Timer(this.components);
            this.btnXReverse = new System.Windows.Forms.Button();
            this.btnYReverse = new System.Windows.Forms.Button();
            this.gbColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoGenerateColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTrackBar)).BeginInit();
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
            this.dtpChooseDate.Location = new System.Drawing.Point(479, 34);
            this.dtpChooseDate.Name = "dtpChooseDate";
            this.dtpChooseDate.Size = new System.Drawing.Size(200, 23);
            this.dtpChooseDate.TabIndex = 3;
            this.dtpChooseDate.ValueChanged += new System.EventHandler(this.dtpChooseDate_ValueChanged);
            // 
            // lblBirthDay
            // 
            this.lblBirthDay.AutoSize = true;
            this.lblBirthDay.Location = new System.Drawing.Point(553, 82);
            this.lblBirthDay.Name = "lblBirthDay";
            this.lblBirthDay.Size = new System.Drawing.Size(38, 15);
            this.lblBirthDay.TabIndex = 4;
            this.lblBirthDay.Text = "label1";
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
            this.gitHubLink.Location = new System.Drawing.Point(692, 426);
            this.gitHubLink.Name = "gitHubLink";
            this.gitHubLink.Size = new System.Drawing.Size(96, 15);
            this.gitHubLink.TabIndex = 11;
            this.gitHubLink.TabStop = true;
            this.gitHubLink.Text = "go to my GitHub";
            this.gitHubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gitHubLink_LinkClicked);
            // 
            // gpField
            // 
            this.gpField.Controls.Add(this.player);
            this.gpField.Location = new System.Drawing.Point(339, 121);
            this.gpField.Name = "gpField";
            this.gpField.Size = new System.Drawing.Size(382, 180);
            this.gpField.TabIndex = 12;
            this.gpField.TabStop = false;
            this.gpField.Text = "groupBox1";
            // 
            // player
            // 
            this.player.AutoSize = true;
            this.player.Location = new System.Drawing.Point(115, 87);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(14, 13);
            this.player.TabIndex = 0;
            this.player.TabStop = true;
            this.player.UseVisualStyleBackColor = true;
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(477, 343);
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
            this.btnY.Location = new System.Drawing.Point(441, 307);
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
            this.btnXReverse.Location = new System.Drawing.Point(407, 343);
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
            this.btnYReverse.Location = new System.Drawing.Point(441, 376);
            this.btnYReverse.Name = "btnYReverse";
            this.btnYReverse.Size = new System.Drawing.Size(30, 30);
            this.btnYReverse.TabIndex = 17;
            this.btnYReverse.Text = "y";
            this.btnYReverse.UseVisualStyleBackColor = true;
            this.btnYReverse.MouseEnter += new System.EventHandler(this.btnYReverse_MouseEnter);
            this.btnYReverse.MouseLeave += new System.EventHandler(this.btnYReverse_MouseLeave);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnYReverse);
            this.Controls.Add(this.btnXReverse);
            this.Controls.Add(this.btnY);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.gpField);
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
            this.gbColor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoGenerateColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTrackBar)).EndInit();
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
        private GroupBox gpField;
        private RadioButton player;
        private Button btnX;
        private Button btnY;
        private System.Windows.Forms.Timer timerX;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerY;
        private Button btnXReverse;
        private Button btnYReverse;
    }
}