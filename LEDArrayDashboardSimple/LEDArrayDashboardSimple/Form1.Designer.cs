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
            this.btnAddress1 = new System.Windows.Forms.Button();
            this.btnAddress2 = new System.Windows.Forms.Button();
            this.chkAddrA = new System.Windows.Forms.CheckBox();
            this.chkAddrB = new System.Windows.Forms.CheckBox();
            this.chkAddrC = new System.Windows.Forms.CheckBox();
            this.chkAddrD = new System.Windows.Forms.CheckBox();
            this.btnSendABCD = new System.Windows.Forms.Button();
            this.btnColorBlu1 = new System.Windows.Forms.Button();
            this.btnColorRed1 = new System.Windows.Forms.Button();
            this.btnColorGrn1 = new System.Windows.Forms.Button();
            this.txtNumOfClks = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // btnColorGrn0
            // 
            this.btnColorGrn0.ForeColor = System.Drawing.Color.DarkGray;
            this.btnColorGrn0.Location = new System.Drawing.Point(9, 19);
            this.btnColorGrn0.Name = "btnColorGrn0";
            this.btnColorGrn0.Size = new System.Drawing.Size(75, 23);
            this.btnColorGrn0.TabIndex = 0;
            this.btnColorGrn0.Text = "Green 0";
            this.btnColorGrn0.UseVisualStyleBackColor = true;
            this.btnColorGrn0.Click += new System.EventHandler(this.btnColorGrn0_Click);
            // 
            // btnColorRed0
            // 
            this.btnColorRed0.ForeColor = System.Drawing.Color.DarkGray;
            this.btnColorRed0.Location = new System.Drawing.Point(91, 18);
            this.btnColorRed0.Name = "btnColorRed0";
            this.btnColorRed0.Size = new System.Drawing.Size(75, 23);
            this.btnColorRed0.TabIndex = 1;
            this.btnColorRed0.Text = "Red 0";
            this.btnColorRed0.UseVisualStyleBackColor = true;
            this.btnColorRed0.Click += new System.EventHandler(this.btnColorRed0_Click);
            // 
            // btnColorBlu0
            // 
            this.btnColorBlu0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColorBlu0.ForeColor = System.Drawing.Color.DarkGray;
            this.btnColorBlu0.Location = new System.Drawing.Point(173, 19);
            this.btnColorBlu0.Name = "btnColorBlu0";
            this.btnColorBlu0.Size = new System.Drawing.Size(75, 23);
            this.btnColorBlu0.TabIndex = 2;
            this.btnColorBlu0.Text = "Blue 0";
            this.btnColorBlu0.UseVisualStyleBackColor = true;
            this.btnColorBlu0.Click += new System.EventHandler(this.btnColorBlu0_Click);
            // 
            // btnShiftOne
            // 
            this.btnShiftOne.Location = new System.Drawing.Point(12, 89);
            this.btnShiftOne.Name = "btnShiftOne";
            this.btnShiftOne.Size = new System.Drawing.Size(75, 23);
            this.btnShiftOne.TabIndex = 3;
            this.btnShiftOne.Text = "Shift 1 Clk";
            this.btnShiftOne.UseVisualStyleBackColor = true;
            this.btnShiftOne.Click += new System.EventHandler(this.btnShiftOne_Click);
            // 
            // btnStrobe
            // 
            this.btnStrobe.ForeColor = System.Drawing.Color.DarkGray;
            this.btnStrobe.Location = new System.Drawing.Point(101, 118);
            this.btnStrobe.Name = "btnStrobe";
            this.btnStrobe.Size = new System.Drawing.Size(75, 23);
            this.btnStrobe.TabIndex = 4;
            this.btnStrobe.Text = "Strobe";
            this.btnStrobe.UseVisualStyleBackColor = true;
            this.btnStrobe.Click += new System.EventHandler(this.btnStrobe_Click);
            // 
            // btnOutputEnable
            // 
            this.btnOutputEnable.ForeColor = System.Drawing.Color.DarkGray;
            this.btnOutputEnable.Location = new System.Drawing.Point(101, 252);
            this.btnOutputEnable.Name = "btnOutputEnable";
            this.btnOutputEnable.Size = new System.Drawing.Size(75, 23);
            this.btnOutputEnable.TabIndex = 5;
            this.btnOutputEnable.Text = "OE";
            this.btnOutputEnable.UseVisualStyleBackColor = true;
            this.btnOutputEnable.Click += new System.EventHandler(this.btnOutputEnable_Click);
            // 
            // btnAddress1
            // 
            this.btnAddress1.Location = new System.Drawing.Point(34, 155);
            this.btnAddress1.Name = "btnAddress1";
            this.btnAddress1.Size = new System.Drawing.Size(75, 23);
            this.btnAddress1.TabIndex = 6;
            this.btnAddress1.Text = "Address 1";
            this.btnAddress1.UseVisualStyleBackColor = true;
            // 
            // btnAddress2
            // 
            this.btnAddress2.Location = new System.Drawing.Point(34, 203);
            this.btnAddress2.Name = "btnAddress2";
            this.btnAddress2.Size = new System.Drawing.Size(75, 23);
            this.btnAddress2.TabIndex = 7;
            this.btnAddress2.Text = "Address 2";
            this.btnAddress2.UseVisualStyleBackColor = true;
            // 
            // chkAddrA
            // 
            this.chkAddrA.AutoSize = true;
            this.chkAddrA.Location = new System.Drawing.Point(132, 155);
            this.chkAddrA.Name = "chkAddrA";
            this.chkAddrA.Size = new System.Drawing.Size(33, 17);
            this.chkAddrA.TabIndex = 8;
            this.chkAddrA.Text = "A";
            this.chkAddrA.UseVisualStyleBackColor = true;
            // 
            // chkAddrB
            // 
            this.chkAddrB.AutoSize = true;
            this.chkAddrB.Location = new System.Drawing.Point(132, 179);
            this.chkAddrB.Name = "chkAddrB";
            this.chkAddrB.Size = new System.Drawing.Size(33, 17);
            this.chkAddrB.TabIndex = 9;
            this.chkAddrB.Text = "B";
            this.chkAddrB.UseVisualStyleBackColor = true;
            // 
            // chkAddrC
            // 
            this.chkAddrC.AutoSize = true;
            this.chkAddrC.Location = new System.Drawing.Point(132, 203);
            this.chkAddrC.Name = "chkAddrC";
            this.chkAddrC.Size = new System.Drawing.Size(33, 17);
            this.chkAddrC.TabIndex = 10;
            this.chkAddrC.Text = "C";
            this.chkAddrC.UseVisualStyleBackColor = true;
            // 
            // chkAddrD
            // 
            this.chkAddrD.AutoSize = true;
            this.chkAddrD.Location = new System.Drawing.Point(132, 227);
            this.chkAddrD.Name = "chkAddrD";
            this.chkAddrD.Size = new System.Drawing.Size(34, 17);
            this.chkAddrD.TabIndex = 11;
            this.chkAddrD.Text = "D";
            this.chkAddrD.UseVisualStyleBackColor = true;
            // 
            // btnSendABCD
            // 
            this.btnSendABCD.Location = new System.Drawing.Point(183, 227);
            this.btnSendABCD.Name = "btnSendABCD";
            this.btnSendABCD.Size = new System.Drawing.Size(75, 23);
            this.btnSendABCD.TabIndex = 12;
            this.btnSendABCD.Text = "Send abcd";
            this.btnSendABCD.UseVisualStyleBackColor = true;
            // 
            // btnColorBlu1
            // 
            this.btnColorBlu1.ForeColor = System.Drawing.Color.DarkGray;
            this.btnColorBlu1.Location = new System.Drawing.Point(173, 48);
            this.btnColorBlu1.Name = "btnColorBlu1";
            this.btnColorBlu1.Size = new System.Drawing.Size(75, 23);
            this.btnColorBlu1.TabIndex = 15;
            this.btnColorBlu1.Text = "Blue 1";
            this.btnColorBlu1.UseVisualStyleBackColor = true;
            this.btnColorBlu1.Click += new System.EventHandler(this.btnColorBlu1_Click);
            // 
            // btnColorRed1
            // 
            this.btnColorRed1.ForeColor = System.Drawing.Color.DarkGray;
            this.btnColorRed1.Location = new System.Drawing.Point(91, 47);
            this.btnColorRed1.Name = "btnColorRed1";
            this.btnColorRed1.Size = new System.Drawing.Size(75, 23);
            this.btnColorRed1.TabIndex = 14;
            this.btnColorRed1.Text = "Red 1";
            this.btnColorRed1.UseVisualStyleBackColor = true;
            this.btnColorRed1.Click += new System.EventHandler(this.btnColorRed1_Click);
            // 
            // btnColorGrn1
            // 
            this.btnColorGrn1.ForeColor = System.Drawing.Color.DarkGray;
            this.btnColorGrn1.Location = new System.Drawing.Point(9, 48);
            this.btnColorGrn1.Name = "btnColorGrn1";
            this.btnColorGrn1.Size = new System.Drawing.Size(75, 23);
            this.btnColorGrn1.TabIndex = 13;
            this.btnColorGrn1.Text = "Green 1";
            this.btnColorGrn1.UseVisualStyleBackColor = true;
            this.btnColorGrn1.Click += new System.EventHandler(this.btnColorGrn1_Click);
            // 
            // txtNumOfClks
            // 
            this.txtNumOfClks.Location = new System.Drawing.Point(122, 91);
            this.txtNumOfClks.Name = "txtNumOfClks";
            this.txtNumOfClks.Size = new System.Drawing.Size(44, 20);
            this.txtNumOfClks.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Clocks";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "OR";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 280);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(284, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 302);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNumOfClks);
            this.Controls.Add(this.btnColorBlu1);
            this.Controls.Add(this.btnColorRed1);
            this.Controls.Add(this.btnColorGrn1);
            this.Controls.Add(this.btnSendABCD);
            this.Controls.Add(this.chkAddrD);
            this.Controls.Add(this.chkAddrC);
            this.Controls.Add(this.chkAddrB);
            this.Controls.Add(this.chkAddrA);
            this.Controls.Add(this.btnAddress2);
            this.Controls.Add(this.btnAddress1);
            this.Controls.Add(this.btnOutputEnable);
            this.Controls.Add(this.btnStrobe);
            this.Controls.Add(this.btnShiftOne);
            this.Controls.Add(this.btnColorBlu0);
            this.Controls.Add(this.btnColorRed0);
            this.Controls.Add(this.btnColorGrn0);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button btnAddress1;
        private System.Windows.Forms.Button btnAddress2;
        private System.Windows.Forms.CheckBox chkAddrA;
        private System.Windows.Forms.CheckBox chkAddrB;
        private System.Windows.Forms.CheckBox chkAddrC;
        private System.Windows.Forms.CheckBox chkAddrD;
        private System.Windows.Forms.Button btnSendABCD;
        private System.Windows.Forms.Button btnColorBlu1;
        private System.Windows.Forms.Button btnColorRed1;
        private System.Windows.Forms.Button btnColorGrn1;
        private System.Windows.Forms.TextBox txtNumOfClks;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

