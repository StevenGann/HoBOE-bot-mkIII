using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Phidgets;
using Phidgets.Events;

namespace HoBOEbotMkIII
{
    public partial class Form1 : Form
    {
        //private JoystickInterface.Joystick jst;
        private bool serialIsReady = false;

        static InterfaceKit ifKit;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trackBarClawVertical.Value = 50;
            trackBarClawTwist.Value = 50;
            trackBarClawGrasp.Value = 50;
            trackBarTrackLeft.Value = 50;
            trackBarTrackRight.Value = 50;

            textBoxClawVertical.Text = Convert.ToString(trackBarClawVertical.Value);
            textBoxClawTwist.Text = Convert.ToString(trackBarClawTwist.Value);
            textBoxClawGrasp.Text = Convert.ToString(trackBarClawGrasp.Value);
            textBoxTrackLeft.Text = Convert.ToString(trackBarTrackLeft.Value);
            textBoxTrackRight.Text = Convert.ToString(trackBarTrackRight.Value);
        }

        private void tmrUpdateStick_Tick(object sender, EventArgs e)
        {
            // get status
            //jst.UpdateStatus();
            // update the axes positions
            //Zbar.Value = (int)(100.0f * (((float)jst.AxisA) / 65535.0f));
            //Xbar.Value = (int)(100.0f * (((float)jst.AxisC) / 65535.0f));
            //Ybar.Value = 100 - (int)(100.0f * (((float)jst.AxisD) / 65535.0f));
        }

        private void buttonConnectJoystick_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Loading");
            // grab the joystick
            //jst = new JoystickInterface.Joystick(this.Handle);
            //string[] sticks = jst.FindJoysticks();
            //jst.AcquireJoystick(sticks[0]);
            //MessageBox.Show("Joystick Acquired");
            // start updating positions
            //tmrUpdateStick.Enabled = true;
        }

        private void trackBarClawVertical_Scroll(object sender, EventArgs e)
        {
            textBoxClawVertical.Text = Convert.ToString(trackBarClawVertical.Value);
            //sendPacket();
        }

        private void trackBarClawTwist_Scroll(object sender, EventArgs e)
        {
            textBoxClawTwist.Text = Convert.ToString(trackBarClawTwist.Value);
            //sendPacket();
        }

        private void trackBarClawGrasp_Scroll(object sender, EventArgs e)
        {
            textBoxClawGrasp.Text = Convert.ToString(trackBarClawGrasp.Value);
            //sendPacket();
        }

        private void trackBarTrackLeft_Scroll(object sender, EventArgs e)
        {
            textBoxTrackLeft.Text = Convert.ToString(trackBarTrackLeft.Value);
        }

        private void trackBarTrackRight_Scroll(object sender, EventArgs e)
        {
            textBoxTrackRight.Text = Convert.ToString(trackBarTrackRight.Value);
        }

        private void sendPacket()
        {
            if (serialIsReady == true)
            {
                //============= Calculate claw servo values.===========
                // Scaled
                // Clamped
                int vertVal = servoScaleLinear(trackBarClawVertical.Value, 40, 180);
                int twistVal = servoScaleLinear(trackBarClawTwist.Value, 0, 180);
                int graspVal = servoScaleLinear(trackBarClawGrasp.Value, 0, 180);


                int leftVal = servoScaleTrack(trackBarTrackLeft.Value, 93, 2);
                int rightVal = servoScaleTrack(trackBarTrackRight.Value, 93, 2);



                serialOutTextbox.Text = "-1," + Convert.ToString(leftVal) + "," + Convert.ToString(rightVal) + "," + Convert.ToString(vertVal) + "," + Convert.ToString(twistVal) + "," + Convert.ToString(graspVal);
                serialPort1.Write(serialOutTextbox.Text + "/n");

                //serialInTextbox.Text = serialPort1.ReadLine();
            }
        }

        private int differentialTransformX(int x, int y, int offset)
        {
            int result = 0;
            //x -= 50;
            //y -= 50;

            double r = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            double t = Math.Atan((float)y / (float)x);

            if (y > 0 && x < 0) { t += 180; }
            else if (y < 0 && x < 0) { t += 180; }
            else if (y < 0 && x > 0) { t += 360; }

            t += offset;

            result = Convert.ToInt16(r * Math.Cos(t));// +50;

            return result;
        }

        private int differentialTransformY(int x, int y, int offset)
        {
            int result = 0;
            //x -= 50;
            //y -= 50;

            double r = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            double t = Math.Atan((float)y / (float)x);

            if (y > 0 && x < 0) { t += 180; }
            else if (y < 0 && x < 0) { t += 180; }
            else if (y < 0 && x > 0) { t += 360; }

            t += offset;

            result = Convert.ToInt16(r * Math.Sin(t));// +50;

            return result;
        }

        private int servoScaleTrack(int percent, int center, int dead)
        {
            int result = center;

            if (percent < (50 - dead) || percent > (50 + dead))
            {
                result = Convert.ToInt16((float)percent * 180.0f/100.0f);
            }

            return result;
        }

        private int servoScaleLinear(int percent, int min, int max)
        {
            int result = 0;

            result = Convert.ToInt16((double)percent * (((double)max - (double)min) / 100.0f) + (double)min);

            return result;
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string line = serialPort1.ReadLine();
            this.BeginInvoke(new LineReceivedEvent(LineReceived), line);
        }

        private delegate void LineReceivedEvent(string line);
        private void LineReceived(string line)
        {
            //What to do with the received line here
            serialInTextbox.Text = line;
        }

        private void comConnectButt_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = portTextbox.Text;
                serialPort1.Open();
                serialPort1.Write("T");
                serialIsReady = true;
                sendPacket();
                //serialPort1.Close();
            }
            catch
            {
                MessageBox.Show("There was an error. Please make sure that the correct port was selected, and the Xbee plugged in.");
                serialPort1.Close();
                serialIsReady = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sendPacket();
        }

        private void timerConnectPhidget_Tick(object sender, EventArgs e)
        {
            try
            {
                //Initialize the InterfaceKit object
                ifKit = new InterfaceKit();

                //Hook the basic event handlers
                ifKit.Attach += new AttachEventHandler(ifKit_Attach);
                ifKit.Detach += new DetachEventHandler(ifKit_Detach);
                ifKit.Error += new ErrorEventHandler(ifKit_Error);

                //Hook the phidget specific event handlers
                ifKit.InputChange += new InputChangeEventHandler(ifKit_InputChange);
                ifKit.OutputChange += new OutputChangeEventHandler(ifKit_OutputChange);
                ifKit.SensorChange += new SensorChangeEventHandler(ifKit_SensorChange);

                //Open the object for device connections
                ifKit.open();

                

                //Wait for an InterfaceKit phidget to be attached
                //ifKit.waitForAttachment();
                
                //Wait for user input so that we can wait and watch for some event data 
                //from the phidget
                //Console.WriteLine("Press any key to end...");
                //Console.Read();

                
            }
            catch (PhidgetException ex)
            {
                MessageBox.Show(ex.Description);
            }
        }

        private void ifKit_SensorChange(object sender, SensorChangeEventArgs e)
        {
            //Update digital values based on physical values
            //MessageBox.Show(Convert.ToString(e.Index) + " = " + Convert.ToString(e.Value.ToString()));

            int index = e.Index;

            switch (index)
            {
                case 0:
                    trackBarTrackLeft.Value = Convert.ToInt16((double)e.Value / 10.0f);//differentialTransformX(Convert.ToInt16((double)e.Value / 10.0f), trackBarTrackRight.Value, -45);
                    textBoxTrackLeft.Text = Convert.ToString(trackBarTrackLeft.Value);
                    break;
                case 1:
                    trackBarTrackRight.Value = Convert.ToInt16((double)e.Value / 10.0f);//differentialTransformY(trackBarTrackLeft.Value, Convert.ToInt16((double)e.Value / 10.0f), -45);
                    textBoxTrackRight.Text = Convert.ToString(trackBarTrackRight.Value);
                    break;
                case 2:
                    trackBarClawVertical.Value = 100 - Convert.ToInt16(Convert.ToDouble(e.Value) / 10.0f);
                    textBoxClawVertical.Text = Convert.ToString(trackBarClawVertical.Value);
                    break;
                case 3:
                    trackBarClawGrasp.Value = 100 - Convert.ToInt16(Convert.ToDouble(e.Value) / 10.0f);
                    textBoxClawGrasp.Text = Convert.ToString(trackBarClawGrasp.Value);
                    break;
                case 4:
                    trackBarClawTwist.Value = Convert.ToInt16(Convert.ToDouble(e.Value) / 10.0f);
                    textBoxClawTwist.Text = Convert.ToString(trackBarClawTwist.Value);
                    break;
                default:
                    break;
            }
        }

        private void ifKit_OutputChange(object sender, OutputChangeEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void ifKit_InputChange(object sender, InputChangeEventArgs e)
        {
            

        }

        private void ifKit_Error(object sender, ErrorEventArgs e)
        {
            //MessageBox.Show(e.Description);
        }

        private void ifKit_Detach(object sender, DetachEventArgs e)
        {
            timerConnectPhidget.Enabled = true;
            MessageBox.Show("Interface board disconnected!");
        }

        private void ifKit_Attach(object sender, AttachEventArgs e)
        {
            timerConnectPhidget.Enabled = false;
            //MessageBox.Show("Interface board connected!");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //User input was rad so we'll terminate the program, so close the object
                ifKit.close();

                //set the object to null to get it out of memory
                ifKit = null;
            }
            catch { }
        }

        
    }
}
