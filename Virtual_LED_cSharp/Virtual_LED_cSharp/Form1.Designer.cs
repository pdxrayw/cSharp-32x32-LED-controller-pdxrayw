namespace Virtual_LED_cSharp
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPosX = new System.Windows.Forms.Label();
            this.lblPosY = new System.Windows.Forms.Label();
            this.txtPosX = new System.Windows.Forms.TextBox();
            this.txtPosY = new System.Windows.Forms.TextBox();
            this.txtAdjPosY = new System.Windows.Forms.TextBox();
            this.txtAdjPosX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 161);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // lblPosX
            // 
            this.lblPosX.AutoSize = true;
            this.lblPosX.Location = new System.Drawing.Point(200, 30);
            this.lblPosX.Name = "lblPosX";
            this.lblPosX.Size = new System.Drawing.Size(54, 13);
            this.lblPosX.TabIndex = 1;
            this.lblPosX.Text = "Position X";
            // 
            // lblPosY
            // 
            this.lblPosY.AutoSize = true;
            this.lblPosY.Location = new System.Drawing.Point(201, 56);
            this.lblPosY.Name = "lblPosY";
            this.lblPosY.Size = new System.Drawing.Size(54, 13);
            this.lblPosY.TabIndex = 2;
            this.lblPosY.Text = "Position Y";
            // 
            // txtPosX
            // 
            this.txtPosX.Location = new System.Drawing.Point(261, 27);
            this.txtPosX.Name = "txtPosX";
            this.txtPosX.Size = new System.Drawing.Size(100, 20);
            this.txtPosX.TabIndex = 3;
            // 
            // txtPosY
            // 
            this.txtPosY.Location = new System.Drawing.Point(261, 53);
            this.txtPosY.Name = "txtPosY";
            this.txtPosY.Size = new System.Drawing.Size(100, 20);
            this.txtPosY.TabIndex = 4;
            // 
            // txtAdjPosY
            // 
            this.txtAdjPosY.Location = new System.Drawing.Point(261, 125);
            this.txtAdjPosY.Name = "txtAdjPosY";
            this.txtAdjPosY.Size = new System.Drawing.Size(100, 20);
            this.txtAdjPosY.TabIndex = 8;
            // 
            // txtAdjPosX
            // 
            this.txtAdjPosX.Location = new System.Drawing.Point(261, 99);
            this.txtAdjPosX.Name = "txtAdjPosX";
            this.txtAdjPosX.Size = new System.Drawing.Size(100, 20);
            this.txtAdjPosX.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Position Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Position X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(202, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Adjusted Position";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(220, 168);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 214);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdjPosY);
            this.Controls.Add(this.txtAdjPosX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPosY);
            this.Controls.Add(this.txtPosX);
            this.Controls.Add(this.lblPosY);
            this.Controls.Add(this.lblPosX);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPosX;
        private System.Windows.Forms.Label lblPosY;
        private System.Windows.Forms.TextBox txtPosX;
        private System.Windows.Forms.TextBox txtPosY;
        private System.Windows.Forms.TextBox txtAdjPosY;
        private System.Windows.Forms.TextBox txtAdjPosX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReset;
    }
}

