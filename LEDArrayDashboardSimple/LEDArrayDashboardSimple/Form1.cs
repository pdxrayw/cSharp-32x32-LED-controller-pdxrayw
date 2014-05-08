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

        public enum signals { r0, g0, b0, r1, g1, b1, a, b, c, d, clk, stb, OE};
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStrobe_Click(object sender, EventArgs e)
        {
            if (btnStrobe.ForeColor == Color.Black)
            {
                btnStrobe.ForeColor = Color.DarkGray;
                btnStrobe.Font = new Font(btnStrobe.Font.Name, btnStrobe.Font.Size, FontStyle.Regular);
            }
            else
            {
                btnStrobe.ForeColor = Color.Black;
                btnStrobe.Font = new Font(btnStrobe.Font.Name, btnStrobe.Font.Size, FontStyle.Bold);
            }
        }

        private void btnColorGrn0_Click(object sender, EventArgs e)
        {
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
            //toolStripStatusLabel1.Text = "1 clock sent";
            //statusStrip1.Refresh();
        }

        private void btnOutputEnable_Click(object sender, EventArgs e)
        {
            if (btnOutputEnable.ForeColor == Color.Black)
            {
                btnOutputEnable.ForeColor = Color.DarkGray;
                btnOutputEnable.Font = new Font(btnOutputEnable.Font.Name, btnOutputEnable.Font.Size, FontStyle.Regular);
            }
            else
            {
                btnOutputEnable.ForeColor = Color.Black;
                btnOutputEnable.Font = new Font(btnOutputEnable.Font.Name, btnOutputEnable.Font.Size, FontStyle.Bold);
            }
        }

        private void btnNumOfCloks_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = txtNumOfClks.Text + " clocks sent";
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
                if (numberOfClocksEntered <= 32) btnNumOfCloks.Enabled = true;
                else if (numberOfClocksEntered >= 0) btnNumOfCloks.Enabled = true;
            }
           

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
           
            CheckBox chkTEMP = (CheckBox)sender;

            if (chkTEMP.Checked == true)
            {   
                send_data_toArduino(signals.a); 
                //send address "a" on to LED32 else off
                //toolStripStatusLabel1.Text = "Address a on"; //display actual
                //statusStrip1.Refresh();
            }
            else
            {
                toolStripStatusLabel1.Text = "Address a off"; //display actual
                statusStrip1.Refresh();   //send address "a" off signal to LED32
            }
        }

        private void send_data_toArduino(signals signal) 
        {
            toolStripStatusLabel1.Text = "Signal '" + signal + "' toggle sent to Arduino"; //display actual
            statusStrip1.Refresh();   //send address "a" off signal to LED32
        }
    }
}
