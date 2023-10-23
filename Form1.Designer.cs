namespace TestSeriell
{
    partial class Form_TestSerial
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox_comSettings = new System.Windows.Forms.GroupBox();
            this.button_close = new System.Windows.Forms.Button();
            this.button_open = new System.Windows.Forms.Button();
            this.progressBar_status = new System.Windows.Forms.ProgressBar();
            this.label_status = new System.Windows.Forms.Label();
            this.comboBox_baudRate = new System.Windows.Forms.ComboBox();
            this.comboBox_comPort = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.label_baudRate = new System.Windows.Forms.Label();
            this.label_comPort = new System.Windows.Forms.Label();
            this.textBox_textSent = new System.Windows.Forms.TextBox();
            this.richTextBox_textReceived = new System.Windows.Forms.RichTextBox();
            this.button_send = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.trackBar_XPos = new System.Windows.Forms.TrackBar();
            this.label_trackbarXPos = new System.Windows.Forms.Label();
            this.label_trackbarUPos = new System.Windows.Forms.Label();
            this.trackBar_UPos = new System.Windows.Forms.TrackBar();
            this.label_trackbarVPos = new System.Windows.Forms.Label();
            this.trackBar_VPos = new System.Windows.Forms.TrackBar();
            this.label_trackbarWPos = new System.Windows.Forms.Label();
            this.trackBar_WPos = new System.Windows.Forms.TrackBar();
            this.label_U = new System.Windows.Forms.Label();
            this.label_V = new System.Windows.Forms.Label();
            this.label_W = new System.Windows.Forms.Label();
            this.label_X = new System.Windows.Forms.Label();
            this.label_Y = new System.Windows.Forms.Label();
            this.trackBar_YPos = new System.Windows.Forms.TrackBar();
            this.label_Z = new System.Windows.Forms.Label();
            this.trackBar_ZPos = new System.Windows.Forms.TrackBar();
            this.label_trackbarYPos = new System.Windows.Forms.Label();
            this.label_trackbarZPos = new System.Windows.Forms.Label();
            this.button_Home = new System.Windows.Forms.Button();
            this.label_trackbarF = new System.Windows.Forms.Label();
            this.label_F = new System.Windows.Forms.Label();
            this.trackBar_F = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox_comSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_XPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_UPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_VPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_WPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_YPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_ZPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_F)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_comSettings
            // 
            this.groupBox_comSettings.Controls.Add(this.button_close);
            this.groupBox_comSettings.Controls.Add(this.button_open);
            this.groupBox_comSettings.Controls.Add(this.progressBar_status);
            this.groupBox_comSettings.Controls.Add(this.label_status);
            this.groupBox_comSettings.Controls.Add(this.comboBox_baudRate);
            this.groupBox_comSettings.Controls.Add(this.comboBox_comPort);
            this.groupBox_comSettings.Controls.Add(this.label);
            this.groupBox_comSettings.Controls.Add(this.label_baudRate);
            this.groupBox_comSettings.Controls.Add(this.label_comPort);
            this.groupBox_comSettings.Location = new System.Drawing.Point(12, 12);
            this.groupBox_comSettings.Name = "groupBox_comSettings";
            this.groupBox_comSettings.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox_comSettings.Size = new System.Drawing.Size(269, 297);
            this.groupBox_comSettings.TabIndex = 0;
            this.groupBox_comSettings.TabStop = false;
            this.groupBox_comSettings.Text = "COM PORT SETTINGS";
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(142, 207);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 8;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(48, 207);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(75, 23);
            this.button_open.TabIndex = 7;
            this.button_open.Text = "Open";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // progressBar_status
            // 
            this.progressBar_status.Location = new System.Drawing.Point(123, 92);
            this.progressBar_status.Name = "progressBar_status";
            this.progressBar_status.Size = new System.Drawing.Size(121, 23);
            this.progressBar_status.TabIndex = 6;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(20, 94);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(68, 16);
            this.label_status.TabIndex = 5;
            this.label_status.Text = "STATUS :";
            // 
            // comboBox_baudRate
            // 
            this.comboBox_baudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_baudRate.FormattingEnabled = true;
            this.comboBox_baudRate.Items.AddRange(new object[] {
            "9600",
            "38400",
            "115200"});
            this.comboBox_baudRate.Location = new System.Drawing.Point(123, 62);
            this.comboBox_baudRate.Name = "comboBox_baudRate";
            this.comboBox_baudRate.Size = new System.Drawing.Size(121, 24);
            this.comboBox_baudRate.TabIndex = 4;
            // 
            // comboBox_comPort
            // 
            this.comboBox_comPort.FormattingEnabled = true;
            this.comboBox_comPort.Location = new System.Drawing.Point(123, 33);
            this.comboBox_comPort.Name = "comboBox_comPort";
            this.comboBox_comPort.Size = new System.Drawing.Size(121, 24);
            this.comboBox_comPort.TabIndex = 3;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(120, 119);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(114, 16);
            this.label.TabIndex = 2;
            this.label.Text = "DISCONNECTED";
            // 
            // label_baudRate
            // 
            this.label_baudRate.AutoSize = true;
            this.label_baudRate.Location = new System.Drawing.Point(20, 65);
            this.label_baudRate.Name = "label_baudRate";
            this.label_baudRate.Size = new System.Drawing.Size(91, 16);
            this.label_baudRate.TabIndex = 1;
            this.label_baudRate.Text = "BAUD RATE :";
            // 
            // label_comPort
            // 
            this.label_comPort.AutoSize = true;
            this.label_comPort.Location = new System.Drawing.Point(20, 36);
            this.label_comPort.Name = "label_comPort";
            this.label_comPort.Size = new System.Drawing.Size(84, 16);
            this.label_comPort.TabIndex = 0;
            this.label_comPort.Text = "COM PORT :";
            // 
            // textBox_textSent
            // 
            this.textBox_textSent.Location = new System.Drawing.Point(287, 25);
            this.textBox_textSent.Name = "textBox_textSent";
            this.textBox_textSent.Size = new System.Drawing.Size(532, 22);
            this.textBox_textSent.TabIndex = 1;
            // 
            // richTextBox_textReceived
            // 
            this.richTextBox_textReceived.Location = new System.Drawing.Point(287, 53);
            this.richTextBox_textReceived.Name = "richTextBox_textReceived";
            this.richTextBox_textReceived.Size = new System.Drawing.Size(613, 256);
            this.richTextBox_textReceived.TabIndex = 2;
            this.richTextBox_textReceived.Text = "";
            this.richTextBox_textReceived.TextChanged += new System.EventHandler(this.richTextBox_textReceived_TextChanged);
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(825, 24);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(75, 23);
            this.button_send.TabIndex = 9;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // trackBar_XPos
            // 
            this.trackBar_XPos.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.trackBar_XPos.LargeChange = 100;
            this.trackBar_XPos.Location = new System.Drawing.Point(91, 324);
            this.trackBar_XPos.Maximum = 2000;
            this.trackBar_XPos.Minimum = -2000;
            this.trackBar_XPos.Name = "trackBar_XPos";
            this.trackBar_XPos.Size = new System.Drawing.Size(250, 45);
            this.trackBar_XPos.TabIndex = 10;
            this.trackBar_XPos.Scroll += new System.EventHandler(this.trackBar_XPos_Scroll);
            this.trackBar_XPos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackBar_XPos_MouseDown);
            this.trackBar_XPos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar_XPos_MouseUp);
            // 
            // label_trackbarXPos
            // 
            this.label_trackbarXPos.AutoSize = true;
            this.label_trackbarXPos.Location = new System.Drawing.Point(347, 338);
            this.label_trackbarXPos.Name = "label_trackbarXPos";
            this.label_trackbarXPos.Size = new System.Drawing.Size(14, 16);
            this.label_trackbarXPos.TabIndex = 11;
            this.label_trackbarXPos.Text = "0";
            // 
            // label_trackbarUPos
            // 
            this.label_trackbarUPos.AutoSize = true;
            this.label_trackbarUPos.Location = new System.Drawing.Point(660, 338);
            this.label_trackbarUPos.Name = "label_trackbarUPos";
            this.label_trackbarUPos.Size = new System.Drawing.Size(14, 16);
            this.label_trackbarUPos.TabIndex = 13;
            this.label_trackbarUPos.Text = "0";
            // 
            // trackBar_UPos
            // 
            this.trackBar_UPos.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.trackBar_UPos.LargeChange = 100;
            this.trackBar_UPos.Location = new System.Drawing.Point(404, 324);
            this.trackBar_UPos.Maximum = 5000;
            this.trackBar_UPos.Minimum = -5000;
            this.trackBar_UPos.Name = "trackBar_UPos";
            this.trackBar_UPos.Size = new System.Drawing.Size(250, 45);
            this.trackBar_UPos.TabIndex = 12;
            this.trackBar_UPos.Scroll += new System.EventHandler(this.trackBar_UPos_Scroll);
            // 
            // label_trackbarVPos
            // 
            this.label_trackbarVPos.AutoSize = true;
            this.label_trackbarVPos.Location = new System.Drawing.Point(660, 371);
            this.label_trackbarVPos.Name = "label_trackbarVPos";
            this.label_trackbarVPos.Size = new System.Drawing.Size(14, 16);
            this.label_trackbarVPos.TabIndex = 15;
            this.label_trackbarVPos.Text = "0";
            // 
            // trackBar_VPos
            // 
            this.trackBar_VPos.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.trackBar_VPos.LargeChange = 100;
            this.trackBar_VPos.Location = new System.Drawing.Point(404, 357);
            this.trackBar_VPos.Maximum = 5000;
            this.trackBar_VPos.Minimum = -5000;
            this.trackBar_VPos.Name = "trackBar_VPos";
            this.trackBar_VPos.Size = new System.Drawing.Size(250, 45);
            this.trackBar_VPos.TabIndex = 14;
            this.trackBar_VPos.Scroll += new System.EventHandler(this.trackBar_VPos_Scroll);
            // 
            // label_trackbarWPos
            // 
            this.label_trackbarWPos.AutoSize = true;
            this.label_trackbarWPos.Location = new System.Drawing.Point(660, 405);
            this.label_trackbarWPos.Name = "label_trackbarWPos";
            this.label_trackbarWPos.Size = new System.Drawing.Size(14, 16);
            this.label_trackbarWPos.TabIndex = 17;
            this.label_trackbarWPos.Text = "0";
            // 
            // trackBar_WPos
            // 
            this.trackBar_WPos.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.trackBar_WPos.LargeChange = 100;
            this.trackBar_WPos.Location = new System.Drawing.Point(404, 389);
            this.trackBar_WPos.Maximum = 5000;
            this.trackBar_WPos.Minimum = -5000;
            this.trackBar_WPos.Name = "trackBar_WPos";
            this.trackBar_WPos.Size = new System.Drawing.Size(250, 45);
            this.trackBar_WPos.TabIndex = 16;
            this.trackBar_WPos.Scroll += new System.EventHandler(this.trackBar_WPos_Scroll);
            // 
            // label_U
            // 
            this.label_U.AutoSize = true;
            this.label_U.Location = new System.Drawing.Point(392, 338);
            this.label_U.Name = "label_U";
            this.label_U.Size = new System.Drawing.Size(17, 16);
            this.label_U.TabIndex = 18;
            this.label_U.Text = "U";
            // 
            // label_V
            // 
            this.label_V.AutoSize = true;
            this.label_V.Location = new System.Drawing.Point(392, 371);
            this.label_V.Name = "label_V";
            this.label_V.Size = new System.Drawing.Size(16, 16);
            this.label_V.TabIndex = 19;
            this.label_V.Text = "V";
            // 
            // label_W
            // 
            this.label_W.AutoSize = true;
            this.label_W.Location = new System.Drawing.Point(392, 405);
            this.label_W.Name = "label_W";
            this.label_W.Size = new System.Drawing.Size(20, 16);
            this.label_W.TabIndex = 20;
            this.label_W.Text = "W";
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.Location = new System.Drawing.Point(77, 338);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(15, 16);
            this.label_X.TabIndex = 21;
            this.label_X.Text = "X";
            // 
            // label_Y
            // 
            this.label_Y.AutoSize = true;
            this.label_Y.Location = new System.Drawing.Point(77, 371);
            this.label_Y.Name = "label_Y";
            this.label_Y.Size = new System.Drawing.Size(16, 16);
            this.label_Y.TabIndex = 23;
            this.label_Y.Text = "Y";
            // 
            // trackBar_YPos
            // 
            this.trackBar_YPos.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.trackBar_YPos.LargeChange = 100;
            this.trackBar_YPos.Location = new System.Drawing.Point(91, 357);
            this.trackBar_YPos.Maximum = 2400;
            this.trackBar_YPos.Minimum = -2400;
            this.trackBar_YPos.Name = "trackBar_YPos";
            this.trackBar_YPos.Size = new System.Drawing.Size(250, 45);
            this.trackBar_YPos.TabIndex = 22;
            this.trackBar_YPos.Scroll += new System.EventHandler(this.trackBar_YPos_Scroll);
            this.trackBar_YPos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackBar_YPos_MouseDown);
            this.trackBar_YPos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar_YPos_MouseUp);
            // 
            // label_Z
            // 
            this.label_Z.AutoSize = true;
            this.label_Z.Location = new System.Drawing.Point(77, 403);
            this.label_Z.Name = "label_Z";
            this.label_Z.Size = new System.Drawing.Size(15, 16);
            this.label_Z.TabIndex = 25;
            this.label_Z.Text = "Z";
            // 
            // trackBar_ZPos
            // 
            this.trackBar_ZPos.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.trackBar_ZPos.LargeChange = 100;
            this.trackBar_ZPos.Location = new System.Drawing.Point(91, 389);
            this.trackBar_ZPos.Maximum = 5000;
            this.trackBar_ZPos.Minimum = -5000;
            this.trackBar_ZPos.Name = "trackBar_ZPos";
            this.trackBar_ZPos.Size = new System.Drawing.Size(250, 45);
            this.trackBar_ZPos.TabIndex = 24;
            this.trackBar_ZPos.Scroll += new System.EventHandler(this.trackBar_ZPos_Scroll);
            // 
            // label_trackbarYPos
            // 
            this.label_trackbarYPos.AutoSize = true;
            this.label_trackbarYPos.Location = new System.Drawing.Point(347, 371);
            this.label_trackbarYPos.Name = "label_trackbarYPos";
            this.label_trackbarYPos.Size = new System.Drawing.Size(14, 16);
            this.label_trackbarYPos.TabIndex = 26;
            this.label_trackbarYPos.Text = "0";
            // 
            // label_trackbarZPos
            // 
            this.label_trackbarZPos.AutoSize = true;
            this.label_trackbarZPos.Location = new System.Drawing.Point(347, 405);
            this.label_trackbarZPos.Name = "label_trackbarZPos";
            this.label_trackbarZPos.Size = new System.Drawing.Size(14, 16);
            this.label_trackbarZPos.TabIndex = 27;
            this.label_trackbarZPos.Text = "0";
            // 
            // button_Home
            // 
            this.button_Home.Location = new System.Drawing.Point(785, 338);
            this.button_Home.Name = "button_Home";
            this.button_Home.Size = new System.Drawing.Size(95, 34);
            this.button_Home.TabIndex = 28;
            this.button_Home.Text = "HOME";
            this.button_Home.UseVisualStyleBackColor = true;
            this.button_Home.Click += new System.EventHandler(this.button_Home_Click);
            // 
            // label_trackbarF
            // 
            this.label_trackbarF.AutoSize = true;
            this.label_trackbarF.Location = new System.Drawing.Point(347, 456);
            this.label_trackbarF.Name = "label_trackbarF";
            this.label_trackbarF.Size = new System.Drawing.Size(14, 16);
            this.label_trackbarF.TabIndex = 31;
            this.label_trackbarF.Text = "0";
            // 
            // label_F
            // 
            this.label_F.AutoSize = true;
            this.label_F.Location = new System.Drawing.Point(77, 454);
            this.label_F.Name = "label_F";
            this.label_F.Size = new System.Drawing.Size(15, 16);
            this.label_F.TabIndex = 30;
            this.label_F.Text = "F";
            // 
            // trackBar_F
            // 
            this.trackBar_F.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.trackBar_F.LargeChange = 100;
            this.trackBar_F.Location = new System.Drawing.Point(91, 440);
            this.trackBar_F.Maximum = 15000;
            this.trackBar_F.Name = "trackBar_F";
            this.trackBar_F.Size = new System.Drawing.Size(250, 45);
            this.trackBar_F.TabIndex = 29;
            this.trackBar_F.Scroll += new System.EventHandler(this.trackBar_F_Scroll);
            this.trackBar_F.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackBar_F_MouseDown);
            this.trackBar_F.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar_F_MouseUp);
            // 
            // Form_TestSerial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 480);
            this.Controls.Add(this.label_trackbarF);
            this.Controls.Add(this.label_F);
            this.Controls.Add(this.trackBar_F);
            this.Controls.Add(this.button_Home);
            this.Controls.Add(this.label_trackbarZPos);
            this.Controls.Add(this.label_trackbarYPos);
            this.Controls.Add(this.label_Z);
            this.Controls.Add(this.trackBar_ZPos);
            this.Controls.Add(this.label_Y);
            this.Controls.Add(this.trackBar_YPos);
            this.Controls.Add(this.label_X);
            this.Controls.Add(this.label_W);
            this.Controls.Add(this.label_V);
            this.Controls.Add(this.label_U);
            this.Controls.Add(this.label_trackbarWPos);
            this.Controls.Add(this.trackBar_WPos);
            this.Controls.Add(this.label_trackbarVPos);
            this.Controls.Add(this.trackBar_VPos);
            this.Controls.Add(this.label_trackbarUPos);
            this.Controls.Add(this.trackBar_UPos);
            this.Controls.Add(this.label_trackbarXPos);
            this.Controls.Add(this.trackBar_XPos);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.richTextBox_textReceived);
            this.Controls.Add(this.textBox_textSent);
            this.Controls.Add(this.groupBox_comSettings);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_TestSerial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C# and Arduino";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_TestSerial_FormClosing);
            this.Load += new System.EventHandler(this.Form_TestSerial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox_comSettings.ResumeLayout(false);
            this.groupBox_comSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_XPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_UPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_VPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_WPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_YPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_ZPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_F)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox groupBox_comSettings;
        private System.Windows.Forms.ComboBox comboBox_comPort;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label_baudRate;
        private System.Windows.Forms.Label label_comPort;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.ComboBox comboBox_baudRate;
        private System.Windows.Forms.ProgressBar progressBar_status;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.TextBox textBox_textSent;
        private System.Windows.Forms.RichTextBox richTextBox_textReceived;
        private System.Windows.Forms.Button button_send;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TrackBar trackBar_XPos;
        private System.Windows.Forms.Label label_trackbarXPos;
        private System.Windows.Forms.Label label_trackbarUPos;
        private System.Windows.Forms.TrackBar trackBar_UPos;
        private System.Windows.Forms.Label label_trackbarVPos;
        private System.Windows.Forms.TrackBar trackBar_VPos;
        private System.Windows.Forms.Label label_trackbarWPos;
        private System.Windows.Forms.TrackBar trackBar_WPos;
        private System.Windows.Forms.Label label_U;
        private System.Windows.Forms.Label label_V;
        private System.Windows.Forms.Label label_W;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.Label label_Y;
        private System.Windows.Forms.TrackBar trackBar_YPos;
        private System.Windows.Forms.Label label_Z;
        private System.Windows.Forms.TrackBar trackBar_ZPos;
        private System.Windows.Forms.Label label_trackbarYPos;
        private System.Windows.Forms.Label label_trackbarZPos;
        private System.Windows.Forms.Button button_Home;
        private System.Windows.Forms.Label label_trackbarF;
        private System.Windows.Forms.Label label_F;
        private System.Windows.Forms.TrackBar trackBar_F;
    }
}

