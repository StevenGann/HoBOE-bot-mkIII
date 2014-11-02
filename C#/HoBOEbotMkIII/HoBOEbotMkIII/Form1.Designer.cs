namespace HoBOEbotMkIII
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxTrackRight = new System.Windows.Forms.TextBox();
            this.textBoxTrackLeft = new System.Windows.Forms.TextBox();
            this.trackBarTrackRight = new System.Windows.Forms.TrackBar();
            this.trackBarTrackLeft = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.portTextbox = new System.Windows.Forms.TextBox();
            this.comConnectButt = new System.Windows.Forms.Button();
            this.serialOutTextbox = new System.Windows.Forms.TextBox();
            this.serialInTextbox = new System.Windows.Forms.TextBox();
            this.buttonConnectJoystick = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxClawGrasp = new System.Windows.Forms.TextBox();
            this.textBoxClawTwist = new System.Windows.Forms.TextBox();
            this.textBoxClawVertical = new System.Windows.Forms.TextBox();
            this.trackBarClawGrasp = new System.Windows.Forms.TrackBar();
            this.trackBarClawTwist = new System.Windows.Forms.TrackBar();
            this.trackBarClawVertical = new System.Windows.Forms.TrackBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tmrUpdateStick = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerConnectPhidget = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTrackRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTrackLeft)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarClawGrasp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarClawTwist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarClawVertical)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(562, 573);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.portTextbox);
            this.tabPage1.Controls.Add(this.comConnectButt);
            this.tabPage1.Controls.Add(this.serialOutTextbox);
            this.tabPage1.Controls.Add(this.serialInTextbox);
            this.tabPage1.Controls.Add(this.buttonConnectJoystick);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(554, 547);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Controls";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxTrackRight);
            this.groupBox2.Controls.Add(this.textBoxTrackLeft);
            this.groupBox2.Controls.Add(this.trackBarTrackRight);
            this.groupBox2.Controls.Add(this.trackBarTrackLeft);
            this.groupBox2.Location = new System.Drawing.Point(186, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(114, 521);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Track Controls";
            // 
            // textBoxTrackRight
            // 
            this.textBoxTrackRight.Location = new System.Drawing.Point(58, 495);
            this.textBoxTrackRight.Name = "textBoxTrackRight";
            this.textBoxTrackRight.ReadOnly = true;
            this.textBoxTrackRight.Size = new System.Drawing.Size(44, 20);
            this.textBoxTrackRight.TabIndex = 8;
            // 
            // textBoxTrackLeft
            // 
            this.textBoxTrackLeft.Location = new System.Drawing.Point(6, 495);
            this.textBoxTrackLeft.Name = "textBoxTrackLeft";
            this.textBoxTrackLeft.ReadOnly = true;
            this.textBoxTrackLeft.Size = new System.Drawing.Size(44, 20);
            this.textBoxTrackLeft.TabIndex = 6;
            // 
            // trackBarTrackRight
            // 
            this.trackBarTrackRight.Location = new System.Drawing.Point(57, 19);
            this.trackBarTrackRight.Maximum = 100;
            this.trackBarTrackRight.Name = "trackBarTrackRight";
            this.trackBarTrackRight.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarTrackRight.Size = new System.Drawing.Size(42, 470);
            this.trackBarTrackRight.TabIndex = 7;
            this.trackBarTrackRight.TickFrequency = 10;
            this.trackBarTrackRight.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarTrackRight.Value = 1;
            this.trackBarTrackRight.Scroll += new System.EventHandler(this.trackBarTrackRight_Scroll);
            // 
            // trackBarTrackLeft
            // 
            this.trackBarTrackLeft.Location = new System.Drawing.Point(6, 19);
            this.trackBarTrackLeft.Maximum = 100;
            this.trackBarTrackLeft.Name = "trackBarTrackLeft";
            this.trackBarTrackLeft.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarTrackLeft.Size = new System.Drawing.Size(42, 470);
            this.trackBarTrackLeft.TabIndex = 6;
            this.trackBarTrackLeft.TickFrequency = 10;
            this.trackBarTrackLeft.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarTrackLeft.Value = 1;
            this.trackBarTrackLeft.Scroll += new System.EventHandler(this.trackBarTrackLeft_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 504);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "USB Input:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "USB Output:";
            // 
            // portTextbox
            // 
            this.portTextbox.Location = new System.Drawing.Point(313, 64);
            this.portTextbox.Name = "portTextbox";
            this.portTextbox.Size = new System.Drawing.Size(75, 20);
            this.portTextbox.TabIndex = 6;
            this.portTextbox.Text = "COM65";
            // 
            // comConnectButt
            // 
            this.comConnectButt.Location = new System.Drawing.Point(313, 35);
            this.comConnectButt.Name = "comConnectButt";
            this.comConnectButt.Size = new System.Drawing.Size(75, 23);
            this.comConnectButt.TabIndex = 5;
            this.comConnectButt.Text = "Connect USB";
            this.comConnectButt.UseVisualStyleBackColor = true;
            this.comConnectButt.Click += new System.EventHandler(this.comConnectButt_Click);
            // 
            // serialOutTextbox
            // 
            this.serialOutTextbox.Location = new System.Drawing.Point(383, 475);
            this.serialOutTextbox.Name = "serialOutTextbox";
            this.serialOutTextbox.ReadOnly = true;
            this.serialOutTextbox.Size = new System.Drawing.Size(156, 20);
            this.serialOutTextbox.TabIndex = 4;
            // 
            // serialInTextbox
            // 
            this.serialInTextbox.Location = new System.Drawing.Point(383, 501);
            this.serialInTextbox.Name = "serialInTextbox";
            this.serialInTextbox.ReadOnly = true;
            this.serialInTextbox.Size = new System.Drawing.Size(156, 20);
            this.serialInTextbox.TabIndex = 3;
            // 
            // buttonConnectJoystick
            // 
            this.buttonConnectJoystick.Location = new System.Drawing.Point(313, 6);
            this.buttonConnectJoystick.Name = "buttonConnectJoystick";
            this.buttonConnectJoystick.Size = new System.Drawing.Size(75, 23);
            this.buttonConnectJoystick.TabIndex = 2;
            this.buttonConnectJoystick.Text = "Joystick";
            this.buttonConnectJoystick.UseVisualStyleBackColor = true;
            this.buttonConnectJoystick.Click += new System.EventHandler(this.buttonConnectJoystick_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.textBoxClawGrasp);
            this.groupBox1.Controls.Add(this.textBoxClawTwist);
            this.groupBox1.Controls.Add(this.textBoxClawVertical);
            this.groupBox1.Controls.Add(this.trackBarClawGrasp);
            this.groupBox1.Controls.Add(this.trackBarClawTwist);
            this.groupBox1.Controls.Add(this.trackBarClawVertical);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 521);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Claw Controls";
            // 
            // textBoxClawGrasp
            // 
            this.textBoxClawGrasp.Location = new System.Drawing.Point(108, 495);
            this.textBoxClawGrasp.Name = "textBoxClawGrasp";
            this.textBoxClawGrasp.ReadOnly = true;
            this.textBoxClawGrasp.Size = new System.Drawing.Size(44, 20);
            this.textBoxClawGrasp.TabIndex = 5;
            // 
            // textBoxClawTwist
            // 
            this.textBoxClawTwist.Location = new System.Drawing.Point(57, 495);
            this.textBoxClawTwist.Name = "textBoxClawTwist";
            this.textBoxClawTwist.ReadOnly = true;
            this.textBoxClawTwist.Size = new System.Drawing.Size(44, 20);
            this.textBoxClawTwist.TabIndex = 4;
            // 
            // textBoxClawVertical
            // 
            this.textBoxClawVertical.Location = new System.Drawing.Point(7, 495);
            this.textBoxClawVertical.Name = "textBoxClawVertical";
            this.textBoxClawVertical.ReadOnly = true;
            this.textBoxClawVertical.Size = new System.Drawing.Size(44, 20);
            this.textBoxClawVertical.TabIndex = 3;
            // 
            // trackBarClawGrasp
            // 
            this.trackBarClawGrasp.Location = new System.Drawing.Point(108, 19);
            this.trackBarClawGrasp.Maximum = 100;
            this.trackBarClawGrasp.Name = "trackBarClawGrasp";
            this.trackBarClawGrasp.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarClawGrasp.Size = new System.Drawing.Size(42, 470);
            this.trackBarClawGrasp.TabIndex = 2;
            this.trackBarClawGrasp.TickFrequency = 10;
            this.trackBarClawGrasp.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarClawGrasp.Value = 1;
            this.trackBarClawGrasp.Scroll += new System.EventHandler(this.trackBarClawGrasp_Scroll);
            // 
            // trackBarClawTwist
            // 
            this.trackBarClawTwist.Location = new System.Drawing.Point(57, 19);
            this.trackBarClawTwist.Maximum = 100;
            this.trackBarClawTwist.Name = "trackBarClawTwist";
            this.trackBarClawTwist.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarClawTwist.Size = new System.Drawing.Size(42, 470);
            this.trackBarClawTwist.TabIndex = 1;
            this.trackBarClawTwist.TickFrequency = 10;
            this.trackBarClawTwist.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarClawTwist.Value = 1;
            this.trackBarClawTwist.Scroll += new System.EventHandler(this.trackBarClawTwist_Scroll);
            // 
            // trackBarClawVertical
            // 
            this.trackBarClawVertical.Location = new System.Drawing.Point(6, 19);
            this.trackBarClawVertical.Maximum = 100;
            this.trackBarClawVertical.Name = "trackBarClawVertical";
            this.trackBarClawVertical.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarClawVertical.Size = new System.Drawing.Size(42, 470);
            this.trackBarClawVertical.TabIndex = 0;
            this.trackBarClawVertical.TickFrequency = 10;
            this.trackBarClawVertical.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarClawVertical.Value = 1;
            this.trackBarClawVertical.Scroll += new System.EventHandler(this.trackBarClawVertical_Scroll);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(546, 535);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Calibration";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tmrUpdateStick
            // 
            this.tmrUpdateStick.Interval = 50;
            this.tmrUpdateStick.Tick += new System.EventHandler(this.tmrUpdateStick_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerConnectPhidget
            // 
            this.timerConnectPhidget.Enabled = true;
            this.timerConnectPhidget.Tick += new System.EventHandler(this.timerConnectPhidget_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 573);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(570, 600);
            this.MinimumSize = new System.Drawing.Size(570, 600);
            this.Name = "Form1";
            this.Text = "HoBOE-bot mk. III Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTrackRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTrackLeft)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarClawGrasp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarClawTwist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarClawVertical)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TrackBar trackBarClawVertical;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxClawGrasp;
        private System.Windows.Forms.TextBox textBoxClawTwist;
        private System.Windows.Forms.TextBox textBoxClawVertical;
        private System.Windows.Forms.TrackBar trackBarClawGrasp;
        private System.Windows.Forms.TrackBar trackBarClawTwist;
        private System.Windows.Forms.Timer tmrUpdateStick;
        private System.Windows.Forms.Button buttonConnectJoystick;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox serialInTextbox;
        private System.Windows.Forms.TextBox serialOutTextbox;
        private System.Windows.Forms.Button comConnectButt;
        private System.Windows.Forms.TextBox portTextbox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerConnectPhidget;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxTrackRight;
        private System.Windows.Forms.TextBox textBoxTrackLeft;
        private System.Windows.Forms.TrackBar trackBarTrackRight;
        private System.Windows.Forms.TrackBar trackBarTrackLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

