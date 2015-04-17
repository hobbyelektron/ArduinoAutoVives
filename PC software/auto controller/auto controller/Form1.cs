using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace auto_controller
{
    public partial class Form1 : Form
    {
        byte Verlichting = Convert.ToByte(0);
        byte vooruit = 0;
        byte achteruit = 0;

        byte links = 0;
        byte rechts = 0;

        public Form1()
        {
            InitializeComponent();
            Verlichting = Convert.ToByte(0);
        }

        

        //BT verbindings gedeelte
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnConnect.Text == "Verbind")
                {
                    lblStatus.Text = "Bezig met verbinden!";
                    serialPort1.PortName = txbComPoort.Text;
                    serialPort1.Open();
                    timer1.Enabled = true;
                    lblStatus.Text = "Verbonden!";
                    btnConnect.Text = "Verbreek";
                }
                else if (btnConnect.Text == "Verbreek")
                {
                    lblStatus.Text = "Bezig met verbreken";
                    timer1.Enabled = false;
                    serialPort1.Close();
                    lblStatus.Text = "Niet verbonden!";
                    btnConnect.Text = "Verbind";
                }
            }
            catch
            {
                lblStatus.Text = "Fout bij het verbinden!";
                MessageBox.Show("Fout bij het verbinden!");
            }
            
            
        }

        private void btnVooruit_Click(object sender, EventArgs e)
        {
            vooruit = Convert.ToByte(255);
            achteruit = Convert.ToByte(0);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            vooruit = Convert.ToByte(0);
            achteruit = Convert.ToByte(0);
            links = Convert.ToByte(0);
            rechts = Convert.ToByte(0);
        }

        private void btnAchteruit_Click(object sender, EventArgs e)
        {
            achteruit = Convert.ToByte(255);
            vooruit = Convert.ToByte(0);
        }

        private void btnLinks_Click(object sender, EventArgs e)
        {
            links = Convert.ToByte(255);
            rechts = Convert.ToByte(0);
        }

        private void btnRechts_Click(object sender, EventArgs e)
        {
            links = Convert.ToByte(0);
            rechts = Convert.ToByte(255);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                byte[] data = new byte[6];

                data[5] = Convert.ToByte(trackBar1.Value);
                data[4] = Verlichting;
                data[3] = achteruit;
                data[2] = vooruit;
                data[1] = links;
                data[0] = rechts;
                serialPort1.Write(data, 0, data.Length);
            }
            catch
            {
                timer1.Enabled = false;
                serialPort1.Close();
                lblStatus.Text = "Verbinding verbroken!";
                MessageBox.Show("Verbinding verbroken!");
            }
            
        }
        private void btnLicht2Aan_Click(object sender, EventArgs e)
        {
            if (Verlichting == Convert.ToByte(0))
            {
                Verlichting = Convert.ToByte(1);
                btnLicht2Aan.Text = "Voorlicht UIT";
            }
            else if (Verlichting == Convert.ToByte(1))
            {
                Verlichting = Convert.ToByte(0);
                btnLicht2Aan.Text = "Voorlicht AAN";
            }
            else if (Verlichting == Convert.ToByte(2))
            {
                Verlichting = Convert.ToByte(3);
                btnLicht2Aan.Text = "Voorlicht UIT";
            }
            else if (Verlichting == Convert.ToByte(3))
            {
                Verlichting = Convert.ToByte(2);
                btnLicht2Aan.Text = "Voorlicht AAN";
            }
        }

        
        private void btnLichtAAN_Click(object sender, EventArgs e)
        {
            if (Verlichting == Convert.ToByte(0))
            {
                Verlichting = Convert.ToByte(2);
                btnLichtAAN.Text = "Achterlicht UIT";
            }
            else if (Verlichting == Convert.ToByte(1))
            {
                Verlichting = Convert.ToByte(3);
                btnLichtAAN.Text = "Achterlicht UIT";
            }
            else if (Verlichting == Convert.ToByte(2))
            {
                Verlichting = Convert.ToByte(0);
                btnLichtAAN.Text = "Achterlicht AAN";
            }
            else if (Verlichting == Convert.ToByte(3))
            {
                Verlichting = Convert.ToByte(1);
                btnLichtAAN.Text = "Achterlicht AAN";
            }
        }
        //Bij verandering van scrollbaar
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblServo.Text = "Servo: " + trackBar1.Value + "°";
        }

        

        
    }
}
