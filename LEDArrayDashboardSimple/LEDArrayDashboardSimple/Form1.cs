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
            //cycle the clk one time
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

        private void button1_Click(object sender, EventArgs e)
        {
            statusStrip1.Text = "This is a single-panel status bar";
            //simpleStatusBar.Text = "This is a single-panel status bar";
        }
    }
}
