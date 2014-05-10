using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LEDArrayDashboardSimple
{   
    public partial class Form1 : Form
    {

        public enum signals {
            r0,
            g0,
            b0,
            r1,
            g1,
            b1,
            A,B,C,D,
            clk,
            stb,
            OE
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStrobe_Click(object sender, EventArgs e)
        {
            send_data_toArduino(signals.stb); 
            if (btnStrobe.ForeColor == Color.Black)
            {
                toolStripStatusLabel3.Text = "Stb off";
                statusStrip1.Refresh();
                btnStrobe.ForeColor = Color.DarkGray;
                btnStrobe.Font = new Font(btnStrobe.Font.Name, btnStrobe.Font.Size, FontStyle.Regular);
            }
            else
            {
                toolStripStatusLabel3.Text = "Stb on";
                statusStrip1.Refresh();
                btnStrobe.ForeColor = Color.Black;
                btnStrobe.Font = new Font(btnStrobe.Font.Name, btnStrobe.Font.Size, FontStyle.Bold);
            }
        }

        private void btnColorGrn0_Click(object sender, EventArgs e)
        {
            send_data_toArduino(signals.g0); 
            if (btnColorGrn0.ForeColor == Color.Green)
            {
                btnColorGrn0.ForeColor = Color.DarkGray;
                btnColorGrn0.Font = new Font(btnColorGrn0.Font.Name, btnColorGrn0.Font.Size, FontStyle.Regular);
            }
            else
            {
                
                btnColorGrn0.ForeColor = Color.Green;
                btnColorGrn0.Font = new Font(btnColorGrn0.Font.Name, btnColorGrn0.Font.Size, FontStyle.Bold);
            }
        }

        private void btnColorGrn1_Click(object sender, EventArgs e)
        {
            send_data_toArduino(signals.g1); 
            if (btnColorGrn1.ForeColor == Color.Green)
            {
                btnColorGrn1.ForeColor = Color.DarkGray;
                btnColorGrn1.Font = new Font(btnColorGrn1.Font.Name, btnColorGrn1.Font.Size, FontStyle.Regular);
            }
            else
            {
                btnColorGrn1.ForeColor = Color.Green;
                btnColorGrn1.Font = new Font(btnColorGrn1.Font.Name, btnColorGrn1.Font.Size, FontStyle.Bold);
            }
        }

        private void btnColorRed0_Click(object sender, EventArgs e)
        {
            send_data_toArduino(signals.r0); 
            if (btnColorRed0.ForeColor == Color.Crimson)
            {
                btnColorRed0.ForeColor = Color.DarkGray;
                btnColorRed0.Font = new Font(btnColorRed0.Font.Name, btnColorRed0.Font.Size, FontStyle.Regular);
            }
            else
            {
                btnColorRed0.ForeColor = Color.Crimson;
                btnColorRed0.Font = new Font(btnColorRed0.Font.Name, btnColorRed0.Font.Size, FontStyle.Bold);
            }
        }

        private void btnColorRed1_Click(object sender, EventArgs e)
        {
            send_data_toArduino(signals.r1); 
            if (btnColorRed1.ForeColor == Color.Crimson)
            {
                btnColorRed1.ForeColor = Color.DarkGray;
                btnColorRed1.Font = new Font(btnColorRed1.Font.Name, btnColorRed1.Font.Size, FontStyle.Regular);
            }
            else
            {
                btnColorRed1.ForeColor = Color.Crimson;
                btnColorRed1.Font = new Font(btnColorRed1.Font.Name, btnColorRed1.Font.Size, FontStyle.Bold);
            }
        }

        private void btnColorBlu0_Click(object sender, EventArgs e)
        {
            send_data_toArduino(signals.b0); 
            if (btnColorBlu0.ForeColor == Color.RoyalBlue)
            {
                btnColorBlu0.ForeColor = Color.DarkGray;
                btnColorBlu0.Font = new Font(btnColorBlu0.Font.Name, btnColorBlu0.Font.Size, FontStyle.Regular);
            }
            else
            {
                btnColorBlu0.ForeColor = Color.RoyalBlue;
                btnColorBlu0.Font = new Font(btnColorBlu0.Font.Name, btnColorBlu0.Font.Size, FontStyle.Bold);
            }
        }

        private void btnColorBlu1_Click(object sender, EventArgs e)
        {
            send_data_toArduino(signals.b1); 
            if (btnColorBlu1.ForeColor == Color.RoyalBlue)
            {
                btnColorBlu1.ForeColor = Color.DarkGray;
                btnColorBlu1.Font = new Font(btnColorBlu1.Font.Name, btnColorBlu1.Font.Size, FontStyle.Regular);
            }
            else
            {
                btnColorBlu1.ForeColor = Color.RoyalBlue;
                btnColorBlu1.Font = new Font(btnColorBlu1.Font.Name, btnColorBlu1.Font.Size, FontStyle.Bold);
            }
        }

        private void btnShiftOne_Click(object sender, EventArgs e)
        {
            send_data_toArduino(signals.clk); 
            toolStripStatusLabel1.Text = "1 clock sent";
            statusStrip1.Refresh();
        }

        private void btnOutputEnable_Click(object sender, EventArgs e)
        {
            send_data_toArduino(signals.OE); 
            if (btnOutputEnable.ForeColor == Color.Black)
            {
                toolStripStatusLabel5.Text = "OE High";
                statusStrip2.Refresh();
                btnOutputEnable.ForeColor = Color.DarkGray;
                btnOutputEnable.Font = new Font(btnOutputEnable.Font.Name, btnOutputEnable.Font.Size, FontStyle.Regular);
            }
            else
            {
                toolStripStatusLabel5.Text = "OE Low";
                statusStrip2.Refresh();
                btnOutputEnable.ForeColor = Color.Black;
                btnOutputEnable.Font = new Font(btnOutputEnable.Font.Name, btnOutputEnable.Font.Size, FontStyle.Bold);
            }
        }

        private void btnNumOfCloks_Click(object sender, EventArgs e)
        {
            int numberOfClocksEntered = Convert.ToInt32(txtNumOfClks.Text);

            for (int i = 0; i < numberOfClocksEntered+1; i++)
            {
                send_data_toArduino(signals.clk);
                toolStripStatusLabel1.Text = i + " clocks sent";
            }
            //txtNumOfClks.Text
            //toolStripStatusLabel1.Text = numberOfClocksEntered + " clocks sent";
            statusStrip1.Refresh();
        }

        private void txtNumOfClks_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txtTEMP = (TextBox)sender;
            if (txtTEMP.TextLength == 1)
            {
                if (e.KeyChar == (char)8){
                    btnNumOfCloks.Enabled = false; //if text feild empty no button
                }
                else if (txtTEMP.TextLength != 0) btnNumOfCloks.Enabled = true;
            }

            
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;         //Just Digits
            if (e.KeyChar == (char)8) e.Handled = false;            //Allow Backspace

            //if (e.KeyChar == (char)13) btnNumOfCloks_Click(sender, e);  //Allow Enter 
            if (e.KeyChar == (char)13) btnNumOfCloks.Enabled = true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnNumOfCloks.Enabled = false;
        }

        private void txtNumOfClks_TextChanged(object sender, EventArgs e)
        {

            TextBox txtTEMP = (TextBox)sender;
            if (txtTEMP.TextLength != 0)
            {
                int numberOfClocksEntered = Convert.ToInt32(txtTEMP.Text);
                if (numberOfClocksEntered > 32) btnNumOfCloks.Enabled = false;
                else if (numberOfClocksEntered > 0) btnNumOfCloks.Enabled = true;
                if (txtTEMP.Text == "00") btnNumOfCloks.Enabled = false;
                //if (txtTEMP.Text == "0 ") btnNumOfCloks.Enabled = false;
                //still need to handel case for 00 double zero should not turn on the send
            }
            if ((txtTEMP.TextLength == 1) && (txtTEMP.Text == "0")) btnNumOfCloks.Enabled = false;

        }

        private void btnSendABCD_Click(object sender, EventArgs e)
        {
            if (true)
            {
                
            }
            
            toolStripStatusLabel1.Text = "Address sent"; //display actual
            statusStrip1.Refresh();

        }

        private void chkAddrA_CheckedChanged(object sender, EventArgs e)
        {
            send_data_toArduino(signals.A); 
            //CheckBox chkTEMP = (CheckBox)sender;

            //if (chkTEMP.Checked == true)
            //{   
                
            //    //send address "a" on to LED32 else off
            //    //toolStripStatusLabel1.Text = "Address a on"; //display actual
            //    //statusStrip1.Refresh();
            //}
            //else
            //{
            //    toolStripStatusLabel1.Text = "Address a off"; //display actual
            //    statusStrip1.Refresh();   //send address "a" off signal to LED32
            //}
        }

        

        private void chkAddrB_CheckedChanged(object sender, EventArgs e)
        {   
            send_data_toArduino(signals.B);
            CheckBox chkTEMP = (CheckBox)sender;

            if (chkTEMP.Checked == true)
            {
                
                //send address "a" on to LED32 else off
                //toolStripStatusLabel1.Text = "Address a on"; //display actual
                //statusStrip1.Refresh();
            }
            else
            {
                //toolStripStatusLabel1.Text = "Address a off"; //display actual
                //statusStrip1.Refresh();   //send address "a" off signal to LED32
            }
        }

        private void chkAddrC_CheckedChanged(object sender, EventArgs e)
        {
            send_data_toArduino(signals.C);
        }

        private void chkAddrD_CheckedChanged(object sender, EventArgs e)
        {
            send_data_toArduino(signals.D);
        }

        private void txtNumOfClks_MouseClick(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter clocks from 0 - 32"; //display actual
            statusStrip1.Refresh();
        }
// Self created methods
        private void send_data_toArduino(signals signal)
        {
            serial_setup_andSend(signal);
            toolStripStatusLabel1.Text = "Signal '" + signal + "' toggle sent to Arduino"; //display actual
            statusStrip1.Refresh();   //send address "a" off signal to LED32
        }

        private void serial_setup_andSend(signals signal)
        {
            
            if (!serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Open();
                    serialPort1.Write(signal.ToString());
                    toolStripStatusLabel2.Text = serialPort1.ReadLine();
                    serialPort1.Close();
                }
                catch
                {
                    MessageBox.Show("There was an error. Please make sure that the correct port was selected, and the device, plugged in.");
                }
            }
        }

    
    //End of Form methods
    }
}
