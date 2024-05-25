namespace cSharp_Calculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.n1 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.ndot = new System.Windows.Forms.Button();
            this.bc = new System.Windows.Forms.Button();
            this.bad = new System.Windows.Forms.Button();
            this.bsub = new System.Windows.Forms.Button();
            this.bdiv = new System.Windows.Forms.Button();
            this.bmul = new System.Windows.Forms.Button();
            this.nequal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(605, 84);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // n1
            // 
            this.n1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.n1.Location = new System.Drawing.Point(105, 124);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(80, 70);
            this.n1.TabIndex = 1;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = false;
            this.n1.Click += new System.EventHandler(this.n1_Click);
            // 
            // n2
            // 
            this.n2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n2.Location = new System.Drawing.Point(211, 124);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(80, 70);
            this.n2.TabIndex = 2;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = false;
            this.n2.Click += new System.EventHandler(this.n2_Click);
            // 
            // n3
            // 
            this.n3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.n3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n3.Location = new System.Drawing.Point(319, 124);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(80, 70);
            this.n3.TabIndex = 3;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = false;
            this.n3.Click += new System.EventHandler(this.n3_Click);
            // 
            // n4
            // 
            this.n4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.n4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n4.Location = new System.Drawing.Point(105, 211);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(80, 70);
            this.n4.TabIndex = 4;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = false;
            this.n4.Click += new System.EventHandler(this.n4_Click);
            // 
            // n5
            // 
            this.n5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.n5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n5.Location = new System.Drawing.Point(211, 211);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(80, 70);
            this.n5.TabIndex = 5;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = false;
            this.n5.Click += new System.EventHandler(this.n5_Click);
            // 
            // n6
            // 
            this.n6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.n6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n6.Location = new System.Drawing.Point(319, 211);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(80, 70);
            this.n6.TabIndex = 6;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = false;
            this.n6.Click += new System.EventHandler(this.n6_Click);
            // 
            // n7
            // 
            this.n7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.n7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n7.Location = new System.Drawing.Point(105, 302);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(80, 70);
            this.n7.TabIndex = 7;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = false;
            this.n7.Click += new System.EventHandler(this.n7_Click);
            // 
            // n8
            // 
            this.n8.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.n8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n8.Location = new System.Drawing.Point(211, 302);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(80, 70);
            this.n8.TabIndex = 8;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = false;
            this.n8.Click += new System.EventHandler(this.n8_Click);
            // 
            // n9
            // 
            this.n9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.n9.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n9.Location = new System.Drawing.Point(319, 302);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(80, 70);
            this.n9.TabIndex = 9;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = false;
            this.n9.Click += new System.EventHandler(this.n9_Click);
            // 
            // n0
            // 
            this.n0.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.n0.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n0.Location = new System.Drawing.Point(211, 397);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(80, 70);
            this.n0.TabIndex = 10;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = false;
            this.n0.Click += new System.EventHandler(this.n0_Click);
            // 
            // ndot
            // 
            this.ndot.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ndot.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndot.Location = new System.Drawing.Point(105, 397);
            this.ndot.Name = "ndot";
            this.ndot.Size = new System.Drawing.Size(80, 70);
            this.ndot.TabIndex = 11;
            this.ndot.Text = ".";
            this.ndot.UseVisualStyleBackColor = false;
            this.ndot.Click += new System.EventHandler(this.ndot_Click);
            // 
            // bc
            // 
            this.bc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bc.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bc.Location = new System.Drawing.Point(319, 397);
            this.bc.Name = "bc";
            this.bc.Size = new System.Drawing.Size(80, 70);
            this.bc.TabIndex = 12;
            this.bc.Text = "C";
            this.bc.UseVisualStyleBackColor = false;
            this.bc.Click += new System.EventHandler(this.bc_Click);
            // 
            // bad
            // 
            this.bad.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bad.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bad.Location = new System.Drawing.Point(437, 397);
            this.bad.Name = "bad";
            this.bad.Size = new System.Drawing.Size(80, 70);
            this.bad.TabIndex = 13;
            this.bad.Text = "+";
            this.bad.UseVisualStyleBackColor = false;
            this.bad.Click += new System.EventHandler(this.bad_Click);
            // 
            // bsub
            // 
            this.bsub.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsub.Location = new System.Drawing.Point(437, 302);
            this.bsub.Name = "bsub";
            this.bsub.Size = new System.Drawing.Size(80, 70);
            this.bsub.TabIndex = 14;
            this.bsub.Text = "-";
            this.bsub.UseVisualStyleBackColor = false;
            this.bsub.Click += new System.EventHandler(this.bsub_Click);
            // 
            // bdiv
            // 
            this.bdiv.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bdiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdiv.Location = new System.Drawing.Point(437, 124);
            this.bdiv.Name = "bdiv";
            this.bdiv.Size = new System.Drawing.Size(80, 70);
            this.bdiv.TabIndex = 15;
            this.bdiv.Text = "/";
            this.bdiv.UseVisualStyleBackColor = false;
            this.bdiv.Click += new System.EventHandler(this.bdiv_Click);
            // 
            // bmul
            // 
            this.bmul.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bmul.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmul.Location = new System.Drawing.Point(437, 211);
            this.bmul.Name = "bmul";
            this.bmul.Size = new System.Drawing.Size(80, 70);
            this.bmul.TabIndex = 16;
            this.bmul.Text = "*";
            this.bmul.UseVisualStyleBackColor = false;
            this.bmul.Click += new System.EventHandler(this.bmul_Click);
            // 
            // nequal
            // 
            this.nequal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.nequal.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nequal.Location = new System.Drawing.Point(254, 506);
            this.nequal.Name = "nequal";
            this.nequal.Size = new System.Drawing.Size(80, 70);
            this.nequal.TabIndex = 17;
            this.nequal.Text = "=";
            this.nequal.UseVisualStyleBackColor = false;
            this.nequal.Click += new System.EventHandler(this.nequal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 626);
            this.Controls.Add(this.nequal);
            this.Controls.Add(this.bmul);
            this.Controls.Add(this.bdiv);
            this.Controls.Add(this.bsub);
            this.Controls.Add(this.bad);
            this.Controls.Add(this.bc);
            this.Controls.Add(this.ndot);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Button n0;
        private System.Windows.Forms.Button ndot;
        private System.Windows.Forms.Button bc;
        private System.Windows.Forms.Button bad;
        private System.Windows.Forms.Button bsub;
        private System.Windows.Forms.Button bdiv;
        private System.Windows.Forms.Button bmul;
        private System.Windows.Forms.Button nequal;
    }
}

