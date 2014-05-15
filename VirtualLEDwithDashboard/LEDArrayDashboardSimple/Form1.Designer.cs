namespace LEDArrayDashboardSimple
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnColorGrn0 = new System.Windows.Forms.Button();
            this.btnColorRed0 = new System.Windows.Forms.Button();
            this.btnColorBlu0 = new System.Windows.Forms.Button();
            this.btnShiftOne = new System.Windows.Forms.Button();
            this.btnStrobe = new System.Windows.Forms.Button();
            this.btnOutputEnable = new System.Windows.Forms.Button();
            this.chkAddrA = new System.Windows.Forms.CheckBox();
            this.chkAddrB = new System.Windows.Forms.CheckBox();
            this.chkAddrC = new System.Windows.Forms.CheckBox();
            this.chkAddrD = new System.Windows.Forms.CheckBox();
            this.btnColorBlu1 = new System.Windows.Forms.Button();
            this.btnColorRed1 = new System.Windows.Forms.Button();
            this.btnColorGrn1 = new System.Windows.Forms.Button();
            this.btnNumOfCloks = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtNumOfClks = new System.Windows.Forms.TextBox();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVirtReal = new System.Windows.Forms.Button();
            this.btnExpand = new System.Windows.Forms.Button();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.pboxLEDmatrix = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLEDmatrix)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // btnColorGrn0
            // 
            this.btnColorGrn0.ForeColor = System.Drawing.Color.DarkGray;
            this.btnColorGrn0.Location = new System.Drawing.Point(92, 19);
            this.btnColorGrn0.Name = "btnColorGrn0";
            this.btnColorGrn0.Size = new System.Drawing.Size(75, 23);
            this.btnColorGrn0.TabIndex = 26;
            this.btnColorGrn0.TabStop = false;
            this.btnColorGrn0.Text = "Green 0";
            this.btnColorGrn0.UseVisualStyleBackColor = true;
            this.btnColorGrn0.Click += new System.EventHandler(this.btnColorGrn0_Click);
            // 
            // btnColorRed0
            // 
            this.btnColorRed0.ForeColor = System.Drawing.Color.DarkGray;
            this.btnColorRed0.Location = new System.Drawing.Point(10, 19);
            this.btnColorRed0.Name = "btnColorRed0";
            this.btnColorRed0.Size = new System.Drawing.Size(75, 23);
            this.btnColorRed0.TabIndex = 1;
            this.btnColorRed0.TabStop = false;
            this.btnColorRed0.Text = "Red 0";
            this.btnColorRed0.UseVisualStyleBackColor = true;
            this.btnColorRed0.Click += new System.EventHandler(this.btnColorRed0_Click);
            // 
            // btnColorBlu0
            // 
            this.btnColorBlu0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColorBlu0.ForeColor = System.Drawing.Color.DarkGray;
            this.btnColorBlu0.Location = new System.Drawing.Point(175, 19);
            this.btnColorBlu0.Name = "btnColorBlu0";
            this.btnColorBlu0.Size = new System.Drawing.Size(75, 23);
            this.btnColorBlu0.TabIndex = 2;
            this.btnColorBlu0.TabStop = false;
            this.btnColorBlu0.Text = "Blue 0";
            this.btnColorBlu0.UseVisualStyleBackColor = true;
            this.btnColorBlu0.Click += new System.EventHandler(this.btnColorBlu0_Click);
            // 
            // btnShiftOne
            // 
            this.btnShiftOne.Location = new System.Drawing.Point(48, 13);
            this.btnShiftOne.Name = "btnShiftOne";
            this.btnShiftOne.Size = new System.Drawing.Size(75, 23);
            this.btnShiftOne.TabIndex = 3;
            this.btnShiftOne.TabStop = false;
            this.btnShiftOne.Text = "Send 1 Clk";
            this.btnShiftOne.UseVisualStyleBackColor = true;
            this.btnShiftOne.Click += new System.EventHandler(this.btnShiftOne_Click);
            // 
            // btnStrobe
            // 
            this.btnStrobe.ForeColor = System.Drawing.Color.DarkGray;
            this.btnStrobe.Location = new System.Drawing.Point(138, 193);
            this.btnStrobe.Name = "btnStrobe";
            this.btnStrobe.Size = new System.Drawing.Size(75, 23);
            this.btnStrobe.TabIndex = 4;
            this.btnStrobe.TabStop = false;
            this.btnStrobe.Text = "Strobe";
            this.btnStrobe.UseVisualStyleBackColor = true;
            this.btnStrobe.Click += new System.EventHandler(this.btnStrobe_Click);
            // 
            // btnOutputEnable
            // 
            this.btnOutputEnable.ForeColor = System.Drawing.Color.DarkGray;
            this.btnOutputEnable.Location = new System.Drawing.Point(138, 222);
            this.btnOutputEnable.Name = "btnOutputEnable";
            this.btnOutputEnable.Size = new System.Drawing.Size(75, 23);
            this.btnOutputEnable.TabIndex = 5;
            this.btnOutputEnable.TabStop = false;
            this.btnOutputEnable.Text = "OE";
            this.btnOutputEnable.UseVisualStyleBackColor = true;
            this.btnOutputEnable.Click += new System.EventHandler(this.btnOutputEnable_Click);
            // 
            // chkAddrA
            // 
            this.chkAddrA.AutoSize = true;
            this.chkAddrA.Location = new System.Drawing.Point(53, 153);
            this.chkAddrA.Name = "chkAddrA";
            this.chkAddrA.Size = new System.Drawing.Size(33, 17);
            this.chkAddrA.TabIndex = 8;
            this.chkAddrA.TabStop = false;
            this.chkAddrA.Text = "A";
            this.chkAddrA.UseVisualStyleBackColor = true;
            this.chkAddrA.CheckedChanged += new System.EventHandler(this.chkAddrA_CheckedChanged);
            // 
            // chkAddrB
            // 
            this.chkAddrB.AutoSize = true;
            this.chkAddrB.Location = new System.Drawing.Point(53, 177);
            this.chkAddrB.Name = "chkAddrB";
            this.chkAddrB.Size = new System.Drawing.Size(33, 17);
            this.chkAddrB.TabIndex = 9;
            this.chkAddrB.TabStop = false;
            this.chkAddrB.Text = "B";
            this.chkAddrB.UseVisualStyleBackColor = true;
            this.chkAddrB.CheckedChanged += new System.EventHandler(this.chkAddrB_CheckedChanged);
            // 
            // chkAddrC
            // 
            this.chkAddrC.AutoSize = true;
            this.chkAddrC.Location = new System.Drawing.Point(53, 201);
            this.chkAddrC.Name = "chkAddrC";
            this.chkAddrC.Size = new System.Drawing.Size(33, 17);
            this.chkAddrC.TabIndex = 10;
            this.chkAddrC.TabStop = false;
            this.chkAddrC.Text = "C";
            this.chkAddrC.UseVisualStyleBackColor = true;
            this.chkAddrC.CheckedChanged += new System.EventHandler(this.chkAddrC_CheckedChanged);
            // 
            // chkAddrD
            // 
            this.chkAddrD.AutoSize = true;
            this.chkAddrD.Location = new System.Drawing.Point(53, 225);
            this.chkAddrD.Name = "chkAddrD";
            this.chkAddrD.Size = new System.Drawing.Size(34, 17);
            this.chkAddrD.TabIndex = 11;
            this.chkAddrD.TabStop = false;
            this.chkAddrD.Text = "D";
            this.chkAddrD.UseVisualStyleBackColor = true;
            this.chkAddrD.CheckedChanged += new System.EventHandler(this.chkAddrD_CheckedChanged);
            // 
            // btnColorBlu1
            // 
            this.btnColorBlu1.ForeColor = System.Drawing.Color.DarkGray;
            this.btnColorBlu1.Location = new System.Drawing.Point(175, 48);
            this.btnColorBlu1.Name = "btnColorBlu1";
            this.btnColorBlu1.Size = new System.Drawing.Size(75, 23);
            this.btnColorBlu1.TabIndex = 15;
            this.btnColorBlu1.TabStop = false;
            this.btnColorBlu1.Text = "Blue 1";
            this.btnColorBlu1.UseVisualStyleBackColor = true;
            this.btnColorBlu1.Click += new System.EventHandler(this.btnColorBlu1_Click);
            // 
            // btnColorRed1
            // 
            this.btnColorRed1.ForeColor = System.Drawing.Color.DarkGray;
            this.btnColorRed1.Location = new System.Drawing.Point(10, 48);
            this.btnColorRed1.Name = "btnColorRed1";
            this.btnColorRed1.Size = new System.Drawing.Size(75, 23);
            this.btnColorRed1.TabIndex = 14;
            this.btnColorRed1.TabStop = false;
            this.btnColorRed1.Text = "Red 1";
            this.btnColorRed1.UseVisualStyleBackColor = true;
            this.btnColorRed1.Click += new System.EventHandler(this.btnColorRed1_Click);
            // 
            // btnColorGrn1
            // 
            this.btnColorGrn1.ForeColor = System.Drawing.Color.DarkGray;
            this.btnColorGrn1.Location = new System.Drawing.Point(92, 48);
            this.btnColorGrn1.Name = "btnColorGrn1";
            this.btnColorGrn1.Size = new System.Drawing.Size(75, 23);
            this.btnColorGrn1.TabIndex = 13;
            this.btnColorGrn1.TabStop = false;
            this.btnColorGrn1.Text = "Green 1";
            this.btnColorGrn1.UseVisualStyleBackColor = true;
            this.btnColorGrn1.Click += new System.EventHandler(this.btnColorGrn1_Click);
            // 
            // btnNumOfCloks
            // 
            this.btnNumOfCloks.Location = new System.Drawing.Point(158, 38);
            this.btnNumOfCloks.Name = "btnNumOfCloks";
            this.btnNumOfCloks.Size = new System.Drawing.Size(51, 23);
            this.btnNumOfCloks.TabIndex = 17;
            this.btnNumOfCloks.TabStop = false;
            this.btnNumOfCloks.Text = "Send";
            this.btnNumOfCloks.UseVisualStyleBackColor = true;
            this.btnNumOfCloks.Click += new System.EventHandler(this.btnNumOfCloks_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = " - OR - ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel5});
            this.statusStrip1.Location = new System.Drawing.Point(0, 277);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(459, 24);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(389, 19);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "Set RGB0 and RGB1 then clk and stobe";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.AutoSize = false;
            this.toolStripStatusLabel5.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel5.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(55, 19);
            this.toolStripStatusLabel5.Text = "OE High";
            // 
            // txtNumOfClks
            // 
            this.txtNumOfClks.Location = new System.Drawing.Point(129, 39);
            this.txtNumOfClks.MaxLength = 2;
            this.txtNumOfClks.Name = "txtNumOfClks";
            this.txtNumOfClks.Size = new System.Drawing.Size(26, 20);
            this.txtNumOfClks.TabIndex = 21;
            this.txtNumOfClks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNumOfClks_MouseClick);
            this.txtNumOfClks.TextChanged += new System.EventHandler(this.txtNumOfClks_TextChanged);
            this.txtNumOfClks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumOfClks_KeyPress);
            // 
            // statusStrip2
            // 
            this.statusStrip2.AutoSize = false;
            this.statusStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.statusStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip2.Location = new System.Drawing.Point(0, 253);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(459, 24);
            this.statusStrip2.TabIndex = 22;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(389, 19);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.AutoSize = false;
            this.toolStripStatusLabel3.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel3.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.toolStripStatusLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(55, 19);
            this.toolStripStatusLabel3.Text = "Stb Off";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Enter number of clocks";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShiftOne);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnNumOfCloks);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNumOfClks);
            this.groupBox1.Location = new System.Drawing.Point(22, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 69);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send Clocks";
            // 
            // btnVirtReal
            // 
            this.btnVirtReal.Enabled = false;
            this.btnVirtReal.Location = new System.Drawing.Point(138, 164);
            this.btnVirtReal.Name = "btnVirtReal";
            this.btnVirtReal.Size = new System.Drawing.Size(75, 23);
            this.btnVirtReal.TabIndex = 25;
            this.btnVirtReal.TabStop = false;
            this.btnVirtReal.Text = "Virtual";
            this.btnVirtReal.UseVisualStyleBackColor = true;
            this.btnVirtReal.Click += new System.EventHandler(this.btnVirtReal_Click);
            // 
            // btnExpand
            // 
            this.btnExpand.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExpand.Location = new System.Drawing.Point(219, 163);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(31, 23);
            this.btnExpand.TabIndex = 0;
            this.btnExpand.Text = ">>";
            this.btnExpand.UseVisualStyleBackColor = false;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // btnCollapse
            // 
            this.btnCollapse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCollapse.Location = new System.Drawing.Point(9, 205);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(31, 23);
            this.btnCollapse.TabIndex = 1;
            this.btnCollapse.Text = "<<";
            this.btnCollapse.UseVisualStyleBackColor = false;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // pboxLEDmatrix
            // 
            this.pboxLEDmatrix.BackColor = System.Drawing.Color.Gray;
            this.pboxLEDmatrix.Location = new System.Drawing.Point(9, 19);
            this.pboxLEDmatrix.Name = "pboxLEDmatrix";
            this.pboxLEDmatrix.Size = new System.Drawing.Size(161, 161);
            this.pboxLEDmatrix.TabIndex = 28;
            this.pboxLEDmatrix.TabStop = false;
            this.pboxLEDmatrix.Paint += new System.Windows.Forms.PaintEventHandler(this.pboxLEDmatrix_Paint);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(67, 205);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 29;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.pboxLEDmatrix);
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.btnCollapse);
            this.groupBox2.Location = new System.Drawing.Point(268, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 231);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Virtual LED";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Reset Turns LED Off/ON";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 301);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnExpand);
            this.Controls.Add(this.btnVirtReal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnColorBlu1);
            this.Controls.Add(this.btnColorRed1);
            this.Controls.Add(this.btnColorGrn1);
            this.Controls.Add(this.chkAddrD);
            this.Controls.Add(this.chkAddrC);
            this.Controls.Add(this.chkAddrB);
            this.Controls.Add(this.chkAddrA);
            this.Controls.Add(this.btnOutputEnable);
            this.Controls.Add(this.btnStrobe);
            this.Controls.Add(this.btnColorBlu0);
            this.Controls.Add(this.btnColorRed0);
            this.Controls.Add(this.btnColorGrn0);
            this.Name = "Form1";
            this.Text = "LED Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLEDmatrix)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnColorGrn0;
        private System.Windows.Forms.Button btnColorRed0;
        private System.Windows.Forms.Button btnColorBlu0;
        private System.Windows.Forms.Button btnShiftOne;
        private System.Windows.Forms.Button btnStrobe;
        private System.Windows.Forms.Button btnOutputEnable;
        private System.Windows.Forms.CheckBox chkAddrA;
        private System.Windows.Forms.CheckBox chkAddrB;
        private System.Windows.Forms.CheckBox chkAddrC;
        private System.Windows.Forms.CheckBox chkAddrD;
        private System.Windows.Forms.Button btnColorBlu1;
        private System.Windows.Forms.Button btnColorRed1;
        private System.Windows.Forms.Button btnColorGrn1;
        private System.Windows.Forms.Button btnNumOfCloks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox txtNumOfClks;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVirtReal;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.Button btnCollapse;
        private System.Windows.Forms.PictureBox pboxLEDmatrix;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
    }
}

