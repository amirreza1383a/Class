namespace Project1
{
    partial class Form2
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
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.txtuname = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtrepass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtpass.Location = new System.Drawing.Point(105, 309);
            this.txtpass.Multiline = true;
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(214, 39);
            this.txtpass.TabIndex = 5;
            // 
            // txtnumber
            // 
            this.txtnumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtnumber.Location = new System.Drawing.Point(105, 218);
            this.txtnumber.Multiline = true;
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(214, 39);
            this.txtnumber.TabIndex = 6;
            // 
            // txtuname
            // 
            this.txtuname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtuname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuname.Location = new System.Drawing.Point(105, 129);
            this.txtuname.Multiline = true;
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(214, 39);
            this.txtuname.TabIndex = 7;
            // 
            // txtfname
            // 
            this.txtfname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfname.Location = new System.Drawing.Point(105, 47);
            this.txtfname.Multiline = true;
            this.txtfname.Name = "txtfname";
            this.txtfname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtfname.Size = new System.Drawing.Size(214, 39);
            this.txtfname.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(134, 501);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 49);
            this.button2.TabIndex = 9;
            this.button2.Text = "بازگشت";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(354, 501);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 49);
            this.button3.TabIndex = 11;
            this.button3.Text = "ثبت نام";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Mehr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(416, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 39);
            this.label1.TabIndex = 12;
            this.label1.Text = ": رمز عبور";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Mehr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(416, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 39);
            this.label2.TabIndex = 13;
            this.label2.Text = ": شماره تماس";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Mehr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(416, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 39);
            this.label3.TabIndex = 14;
            this.label3.Text = ": نام کاربری ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Mehr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(416, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 39);
            this.label4.TabIndex = 15;
            this.label4.Text = ": نام و نام خانوادگی";
            // 
            // txtrepass
            // 
            this.txtrepass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtrepass.Location = new System.Drawing.Point(105, 399);
            this.txtrepass.Multiline = true;
            this.txtrepass.Name = "txtrepass";
            this.txtrepass.Size = new System.Drawing.Size(214, 39);
            this.txtrepass.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Mehr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(416, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 39);
            this.label5.TabIndex = 17;
            this.label5.Text = ": تکرار رمزعبور";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 597);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtrepass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.txtuname);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.txtpass);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.TextBox txtuname;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtrepass;
        internal System.Windows.Forms.Label label5;
    }
}