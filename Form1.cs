using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace TestSeriell
{
    public partial class Form_TestSerial : Form
    {
        string serialDataIn;
        bool trackbarXMouseDown = false;
        bool trackbarXScrolling = false;
        bool trackbarYMouseDown = false;
        bool trackbarYScrolling = false;
        bool trackbarZMouseDown = false;
        bool trackbarZScrolling = false;
        bool trackbarUMouseDown = false;
        bool trackbarUScrolling = false;
        bool trackbarVMouseDown = false;
        bool trackbarVScrolling = false;
        bool trackbarWMouseDown = false;
        bool trackbarWScrolling = false;
        bool trackbarFMouseDown = false;
        bool trackbarFScrolling = false;

        public Form_TestSerial()
        {
            InitializeComponent();
        }

     private void Form_TestSerial_Load(object sender, EventArgs e)
        {
            button_open.Enabled = true;
            button_close.Enabled = false;
            button_send.Enabled = false;
            progressBar_status.Value = 0;
            label.Text = "DISCONNECTED";
            label.ForeColor = Color.Red;

            comboBox_baudRate.Text = "9600";
            string[] portLists = SerialPort.GetPortNames();
            comboBox_comPort.Items.AddRange(portLists);
            textBox_textSent.Text = "";
            
            trackBar_F.Value = 1000;
            label_trackbarF.Text = trackBar_F.Value.ToString();
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBox_comPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBox_baudRate.Text);
                serialPort1.Open();

                button_open.Enabled = false;
                button_close.Enabled = true;
                button_send.Enabled = true;
                progressBar_status.Value = 100;
                label.Text = "CONNECTED";
                label.ForeColor = Color.Green;

            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();

                button_open.Enabled = true;
                button_close.Enabled = false;
                button_send.Enabled = false;
                progressBar_status.Value = 0;
                label.Text = "DISCONNECTED";
                label.ForeColor = Color.Red;

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Form_TestSerial_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write(textBox_textSent.Text + "#");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            serialDataIn = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));

        }

        private void ShowData(object sender, EventArgs e)
        {
            richTextBox_textReceived.Text += serialDataIn;

        }

        private void richTextBox_textReceived_TextChanged(object sender, EventArgs e)
        {
            richTextBox_textReceived.SelectionStart = richTextBox_textReceived.Text.Length;
            richTextBox_textReceived.ScrollToCaret();

        }

        private void trackBar_XPos_MouseDown(object sender, MouseEventArgs e)
        {
            trackbarXMouseDown = true;
        }
        private void trackBar_XPos_Scroll(object sender, EventArgs e)
        {
            trackbarXScrolling = true;
            label_trackbarXPos.Text = trackBar_XPos.Value.ToString();
        }

        private void trackBar_XPos_MouseUp(object sender, MouseEventArgs e)
        {
            if (trackbarXMouseDown == true && trackbarXScrolling == true)
            {
                trackbarXMouseDown = false;
                trackbarXScrolling = false;

                textBox_textSent.Text = "G1 X" + label_trackbarXPos.Text + " Y" + label_trackbarYPos.Text + " Z" + label_trackbarZPos.Text + " U" + label_trackbarZPos.Text + " V" + label_trackbarZPos.Text + " W" + label_trackbarZPos.Text + " F" + label_trackbarF.Text;
                try
                {
                    serialPort1.Write(textBox_textSent.Text + "#");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void trackBar_YPos_MouseDown(object sender, MouseEventArgs e)
        {
            trackbarYMouseDown = true;
        }

        private void trackBar_YPos_Scroll(object sender, EventArgs e)
        {
            trackbarYScrolling = true;
            label_trackbarYPos.Text = trackBar_YPos.Value.ToString();
        }

        private void trackBar_YPos_MouseUp(object sender, MouseEventArgs e)
        {
            if (trackbarYMouseDown == true && trackbarYScrolling == true)
            {
                trackbarYMouseDown = false;
                trackbarYScrolling = false;

                textBox_textSent.Text = "G1 X" + label_trackbarXPos.Text + " Y" + label_trackbarYPos.Text + " Z" + label_trackbarZPos.Text + " U" + label_trackbarZPos.Text + " V" + label_trackbarZPos.Text + " W" + label_trackbarZPos.Text + " F" + label_trackbarF.Text;
                try
                {
                    serialPort1.Write(textBox_textSent.Text + "#");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void trackBar_ZPos_MouseDown(object sender, MouseEventArgs e)
        {
            trackbarZMouseDown = true;
        }

        private void trackBar_ZPos_Scroll(object sender, EventArgs e)
        {
            trackbarZScrolling = true;
            label_trackbarZPos.Text = trackBar_ZPos.Value.ToString();
        }

        private void trackBar_ZPos_MouseUp(object sender, MouseEventArgs e)
        {
            if (trackbarZMouseDown == true && trackbarZScrolling == true)
            {
                trackbarZMouseDown = false;
                trackbarZScrolling = false;
                
                textBox_textSent.Text = "G1 X" + label_trackbarXPos.Text + " Y" + label_trackbarYPos.Text + " Z" + label_trackbarZPos.Text + " U" + label_trackbarZPos.Text + " V" + label_trackbarZPos.Text + " W" + label_trackbarZPos.Text + " F" + label_trackbarF.Text;
                try
                {
                    serialPort1.Write(textBox_textSent.Text + "#");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }
        private void trackBar_UPos_MouseDown(object sender, MouseEventArgs e)
        {
            trackbarUMouseDown = true;
        }

        private void trackBar_UPos_Scroll(object sender, EventArgs e)
        {
            trackbarUScrolling = true;
            label_trackbarUPos.Text = trackBar_UPos.Value.ToString();
        }

        private void trackBar_UPos_MouseUp(object sender, MouseEventArgs e)
        {
            if (trackbarUMouseDown == true && trackbarUScrolling == true)
            {
                trackbarUMouseDown = false;
                trackbarUScrolling = false;

                textBox_textSent.Text = "G1 X" + label_trackbarXPos.Text + " Y" + label_trackbarYPos.Text + " Z" + label_trackbarZPos.Text + " U" + label_trackbarZPos.Text + " V" + label_trackbarZPos.Text + " W" + label_trackbarZPos.Text + " F" + label_trackbarF.Text;
                try
                {
                    serialPort1.Write(textBox_textSent.Text + "#");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void trackBar_VPos_MouseDown(object sender, MouseEventArgs e)
        {
            trackbarVMouseDown = true;
        }

        private void trackBar_VPos_Scroll(object sender, EventArgs e)
        {
            trackbarVScrolling = true;
            label_trackbarVPos.Text = trackBar_VPos.Value.ToString();
        }

        private void trackBar_VPos_MouseUp(object sender, MouseEventArgs e)
        {
            if (trackbarVMouseDown == true && trackbarVScrolling == true)
            {
                trackbarVMouseDown = false;
                trackbarVScrolling = false;

                textBox_textSent.Text = "G1 X" + label_trackbarXPos.Text + " Y" + label_trackbarYPos.Text + " Z" + label_trackbarZPos.Text + " U" + label_trackbarZPos.Text + " V" + label_trackbarZPos.Text + " W" + label_trackbarZPos.Text + " F" + label_trackbarF.Text;
                try
                {
                    serialPort1.Write(textBox_textSent.Text + "#");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void trackBar_WPos_MouseDown(object sender, MouseEventArgs e)
        {
            trackbarWMouseDown = true;
        }

        private void trackBar_WPos_Scroll(object sender, EventArgs e)
        {
            trackbarWScrolling = true;
            label_trackbarWPos.Text = trackBar_WPos.Value.ToString();
        }

        private void trackBar_WPos_MouseUp(object sender, MouseEventArgs e)
        {
            if (trackbarWMouseDown == true && trackbarWScrolling == true)
            {
                trackbarWMouseDown = false;
                trackbarWScrolling = false;

                textBox_textSent.Text = "G1 X" + label_trackbarXPos.Text + " Y" + label_trackbarYPos.Text + " Z" + label_trackbarZPos.Text + " U" + label_trackbarZPos.Text + " V" + label_trackbarZPos.Text + " W" + label_trackbarZPos.Text + " F" + label_trackbarF.Text;
                try
                {
                    serialPort1.Write(textBox_textSent.Text + "#");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void trackBar_F_MouseDown(object sender, MouseEventArgs e)
        {
            trackbarFMouseDown = true;
        }

        private void trackBar_F_MouseUp(object sender, MouseEventArgs e)
        {
            if (trackbarFMouseDown == true && trackbarFScrolling == true)
            {
                trackbarFMouseDown = false;
                trackbarFScrolling = false;

                textBox_textSent.Text = "G1 X" + label_trackbarXPos.Text + " Y" + label_trackbarYPos.Text + " Z" + label_trackbarZPos.Text + " U" + label_trackbarZPos.Text + " V" + label_trackbarZPos.Text + " W" + label_trackbarZPos.Text + " F" + label_trackbarF.Text;
                try
                {
                    serialPort1.Write(textBox_textSent.Text + "#");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void trackBar_F_Scroll(object sender, EventArgs e)
        {
            trackbarFScrolling = true;
            label_trackbarF.Text = trackBar_F.Value.ToString();
        }

        private void button_Home_Click(object sender, EventArgs e)
        {
            try
            {
                trackBar_XPos.Value = 0;
                trackBar_YPos.Value = 0;
                trackBar_ZPos.Value = 0;
                trackBar_UPos.Value = 0;
                trackBar_VPos.Value = 0;
                trackBar_WPos.Value = 0;
                trackBar_F.Value = 1000;

                label_trackbarXPos.Text = trackBar_XPos.Value.ToString();
                label_trackbarYPos.Text = trackBar_YPos.Value.ToString();
                label_trackbarZPos.Text = trackBar_ZPos.Value.ToString();
                label_trackbarUPos.Text = trackBar_UPos.Value.ToString();
                label_trackbarVPos.Text = trackBar_VPos.Value.ToString();
                label_trackbarWPos.Text = trackBar_WPos.Value.ToString();
                label_trackbarF.Text = trackBar_F.Value.ToString();

                textBox_textSent.Text = "G1 X" + label_trackbarXPos.Text + " Y" + label_trackbarYPos.Text + " Z" + label_trackbarZPos.Text + " U" + label_trackbarZPos.Text + " V" + label_trackbarZPos.Text + " W" + label_trackbarZPos.Text + " F" + label_trackbarF.Text;
                try
                {
                    serialPort1.Write(textBox_textSent.Text + "#");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
