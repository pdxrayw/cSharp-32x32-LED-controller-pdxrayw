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

        public struct signalsStruct
        {   
                private signals signalName;
                private bool active;
                
                public signals SignalName
                {
                        get
                        {
                            return signalName;
                        }
                        set
                        {
                            signalName = value;
                        }
                }
                public bool Active
                                    {
                        get
                        {
                            return active;
                        }
                        set
                        {
                            active = value;
                        }
                }

        };

        public enum rgbColors
        {               ///rgb
            grey = 0,   ///000//black LED is off
            red = 1,    ///001
            green = 2,  ///010
            orange = 3, ///011
            blue = 4,   ///100
            purple = 5, ///101
            yellow = 6, ///110
            white = 7   ///111
        };

        public signalsStruct r0 = new signalsStruct();
        public signalsStruct g0 = new signalsStruct();
        public signalsStruct b0 = new signalsStruct();

        public signalsStruct OE = new signalsStruct();
        public signalsStruct clk = new signalsStruct();

        Stack<int> topRow = new Stack<int>();
        int[] bottomRow = new int[32];

        public Form1()
        {
            InitializeComponent();
            
            
            r0.SignalName = signals.r0;
            r0.Active = false;
            g0.SignalName = signals.g0;
            g0.Active = false;
            b0.SignalName = signals.b0;
            b0.Active = false;

           OE.SignalName = signals.OE;         
           OE.Active = true;

           clk.SignalName = signals.clk;
           clk.Active = false;
        }

        private void btnStrobe_Click(object sender, EventArgs e)
        {
            //send_data_toArduino(signals.stb); 
            send_signal_to_virtual_LED(signals.stb);
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
            //send_data_toArduino(signals.g0); 
            send_signal_to_virtual_LED(signals.g0);
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
            //send_data_toArduino(signals.r0); 
            send_signal_to_virtual_LED(signals.r0);
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
            //send_data_toArduino(signals.b0); 
            send_signal_to_virtual_LED(signals.b0);
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
            //send_data_toArduino(signals.clk); 
            send_signal_to_virtual_LED(signals.clk);
            clock();
            toolStripStatusLabel1.Text = "1 clock sent";
            statusStrip1.Refresh();
        }

        private void btnOutputEnable_Click(object sender, EventArgs e)
        {
            //send_data_toArduino(signals.OE); 
            send_signal_to_virtual_LED(signals.OE);
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
            //uncomment width height for real led
            //this.Width = 275;
            //.Height = 340;
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

        private void btnVirtReal_Click(object sender, EventArgs e)
        {

            if (VirtReal_State() == "Virtual")
            {
                btnVirtReal.Text = "Real";
                VirtReal_Change_State();
            }
            else
            {
                btnVirtReal.Text = "Virtual";
                VirtReal_Change_State();
            }
        }

        private String VirtReal_State()
        {
            String State = btnVirtReal.Text;
            return State;
        }

        private void VirtReal_Change_State()
        {
            //Check for the led array
            //if not pressent can not change to Real
            //if unplugged disable all buttons and error to virtual?
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            this.Width = 475;
            Button btnTEMP = (Button)sender;
            btnTEMP.Enabled = false;
            btnTEMP.BackColor = SystemColors.Control;

            
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            this.Width = 275;
            btnExpand.Enabled = true;
            btnExpand.BackColor = SystemColors.ActiveCaption;
            
        }

        private void pboxLEDmatrix_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int numOfCells = 32;
            int cellSize = 5;
            Pen p = new Pen(Color.Black);

            for (int y = 0; y <= numOfCells; ++y)
            {
                g.DrawLine(p, 0, y * cellSize, numOfCells * cellSize, y * cellSize);
            }

            for (int x = 0; x <= numOfCells; ++x)
            {
                g.DrawLine(p, x * cellSize, 0, x * cellSize, numOfCells * cellSize);
            }
        }
//Sart of user defined functions to draw in the leds
            public void send_signal_to_virtual_LED(signals signal)
            {
                //signals TMPsignal = (signals)signal;
                switch (signal)
                {
                    case signals.r0:
                        r0.Active = toggle_signal(r0);
                        break;
                    case signals.g0:
                        g0.Active = toggle_signal(g0);
                        break;
                    case signals.b0:
                        b0.Active = toggle_signal(b0);
                        break;
                    //case signals.r1:
                    //    signal = r1;
                    //    break;
                    //case signals.g1:
                    //    signal = g1;
                    //    break;
                    //case signals.b1:
                    //    signal = b1;
                    //    break;
                    //case signals.A:
                    //    signal = A;
                    //    break;
                    //case signals.B:
                    //    signal = B;
                    //    break;
                    //case signals.C:
                    //    signal = C;
                    //    break;
                    //case signals.D:
                    //    signal = D;
                    //    break;
                    case signals.stb:
                        
                        break;
                    case signals.clk:
                        clk.Active = toggle_signal(clk);
                        break;
                    case signals.OE:
                        OE.Active = toggle_signal(OE);
                        break;

                };
            }//end send signal to  LED

            private bool toggle_signal(signalsStruct signal){

                if (signal.Active == false)//if false make true and vise versus
                {
                    return true;

                }                
                
                return false;

                 
            }

            private void fill_row(int row_address, int rgb0, int rgb1)
            {
                //fill the row with the color for desired colors. Called one time per clock. 
                //pushed the color into the first column of the row all other colors shift 
                //into the row by one column

            }

            private void clear_row(int row_address)
            {
                //clears the row before changing the address
                //technically clears the row when a new address is selected.
            }


            private void clock()
            {
                rgbColors rgb0;
                rgbColors rgb1;
                //technically the drawing should be done from some buffer in another function
                //, hard coding for test
                //rgb0 = (rgbColors)get_color_rgb0();
                topRow.Push(get_color_rgb0());
                
                //Console.WriteLine("--- Stack contents ---");
                toolStripStatusLabel2.Text = "";
                foreach (int i in topRow)
                {
                    toolStripStatusLabel2.Text += i + " ";
                }
                //topRow.
                //Graphics g = e.Graphics;
                int numOfCells = 32;//use these for rectangle size and incriment
                int cellSize = 5;//use these for rectangle size and incriment
                int x = 0;//location of LED to paint row
                int y = 0;//location of LED to paint Column
                Graphics graphicsObj;

                
                //Draw a solid Rectangle of desired color
                graphicsObj = pboxLEDmatrix.CreateGraphics();
                SolidBrush myBrush = new SolidBrush(Color.Crimson);
                while (x < 160)
                {
                    Rectangle myRectangle1 = new Rectangle(x, y, 5, 5);
                    graphicsObj.FillRectangle(myBrush, myRectangle1);
                //suround the solid rectangle with a black rectangle for visual aestetics
                //graphicsObj = pictureBox1.CreateGraphics();
                    Pen myPen = new Pen(Color.Black, 1);
                    Rectangle myRectangle2 = new Rectangle(x, y, 5, 5);
                    //graphicsObj.DrawEllipse(myPen, myRectangle2);
                    
                    graphicsObj.DrawRectangle(myPen, myRectangle2);

                    x +=5;
                }



                //received clock input
                //not sure what parameters are needed yet
            }

            private bool OE_get()
            {
                return OE.Active;
                //if False allow to write directly to the LED after storage.
                //Allows the leds to be on
                //not sure what parameters are needed yet
                //This needs to be done first allowint drawing if true
            }

            private void OE_LED_enabled()//this needs to be called when the OE is toggled on
            {
                //after OE is toggled on display all/any pixel data stored in row buffer registers   
                //write directly to the LED after store. IE display results
                    //Allows the leds to be on
                    //not sure what parameters are needed yet
                    //This needs to be done first allowint drawing if true
            }
            private void stb(int row_address)
            {
                //Allows the leds to be on
                //not sure what parameters are needed yet
            }

            private void address_abcd_changed(int row_address)
            {
                //Allows the leds to be on
                //not sure what parameters are needed yet
            }

            private void get_address(int row_address)
            {
                //Allows the leds to be on
                //not sure what parameters are needed yet
            }

            private void set_address(int row_address)
            {
                //Allows the leds to be on
                //not sure what parameters are needed yet
            }

            private int get_color_rgb0()
            {   int color0 = 0;
            //color set to test only //remove for production
            //r0.Active = false;//remove for production
            //b0.Active = true;//remove for production
            //g0.Active = true;//remove for production

            color0 = Convert.ToInt32(r0.Active);
            color0 += (Convert.ToInt32(g0.Active))*2;
            color0 += (Convert.ToInt32(b0.Active)) * 4;
                //Allows the leds to be on
                //not sure what parameters are needed yet

            if (color0 == 1)
            { 
            }

            return color0;
            }
            private int get_color_rgb1()
            {
                int color1 = 1;
                //color set to test only //remove for production
                
                //uncomment below after created r1 g1 b1
                //color1 = Convert.ToInt32(r1.Active);
                //color1 += (Convert.ToInt32(g1.Active)) * 2;
                //color1 += (Convert.ToInt32(b1.Active)) * 4;
                //Allows the leds to be on
                //not sure what parameters are needed yet
                
                return color1;
            }

            private void set_color_rgb()
            {
                //Allows the leds to be on
                //not sure what parameters are needed yet
            }



            // Design idea. I thing the best thing to do might be to store the rgb0 and rgb1 colors in
            //an array which can then be re-drawn everytime rather than trying to actually shift a color
            //left one column  evertime the clock ticks Just a thought.....
            // if so will need two arrays 1X32 of ints or enum colors or one array 2X32
            //might be best two arrays top(32) bottom(32) one int or 4 address lines could just run a convert
            //to binary/decimal function for ease........
            // need bools for OE and stb maybe bools for abcd and rbg as well.......
            //the inputs need to be int he form of all the signals anyway may just be easiest to keep them 
            //that way
            //for testing hard wire in a few columns and colors do OE, then stb, then row then color
            //last clock..



    //End of Form methods
    }
}
