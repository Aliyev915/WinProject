namespace WindowsFormsApp1
{
    partial class Register
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
            this.txtRegisterPssw = new System.Windows.Forms.TextBox();
            this.txtRegisterEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoginRegister = new System.Windows.Forms.Button();
            this.txtRegisterConfirmPssw = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRegisterPssw
            // 
            this.txtRegisterPssw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterPssw.Location = new System.Drawing.Point(8, 149);
            this.txtRegisterPssw.Name = "txtRegisterPssw";
            this.txtRegisterPssw.Size = new System.Drawing.Size(171, 26);
            this.txtRegisterPssw.TabIndex = 7;
            this.txtRegisterPssw.UseSystemPasswordChar = true;
            this.txtRegisterPssw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRegisterPssw_KeyDown);
            // 
            // txtRegisterEmail
            // 
            this.txtRegisterEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterEmail.Location = new System.Drawing.Point(16, 33);
            this.txtRegisterEmail.Name = "txtRegisterEmail";
            this.txtRegisterEmail.Size = new System.Drawing.Size(171, 26);
            this.txtRegisterEmail.TabIndex = 6;
            this.txtRegisterEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRegisterEmail_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(8, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password :";
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Email :";
            // 
            // btnLoginRegister
            // 
            this.btnLoginRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(218)))), ((int)(((byte)(197)))));
            this.btnLoginRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginRegister.Location = new System.Drawing.Point(8, 290);
            this.btnLoginRegister.Name = "btnLoginRegister";
            this.btnLoginRegister.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLoginRegister.Size = new System.Drawing.Size(167, 34);
            this.btnLoginRegister.TabIndex = 8;
            this.btnLoginRegister.Text = "Register";
            this.btnLoginRegister.UseVisualStyleBackColor = false;
            this.btnLoginRegister.Click += new System.EventHandler(this.btnLoginRegister_Click);
            // 
            // txtRegisterConfirmPssw
            // 
            this.txtRegisterConfirmPssw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterConfirmPssw.Location = new System.Drawing.Point(8, 219);
            this.txtRegisterConfirmPssw.Name = "txtRegisterConfirmPssw";
            this.txtRegisterConfirmPssw.Size = new System.Drawing.Size(171, 26);
            this.txtRegisterConfirmPssw.TabIndex = 10;
            this.txtRegisterConfirmPssw.UseSystemPasswordChar = true;
            this.txtRegisterConfirmPssw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRegisterConfirmPssw_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(8, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Confirm Password :";
            // 
            // txtFullname
            // 
            this.txtFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullname.Location = new System.Drawing.Point(12, 86);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(171, 26);
            this.txtFullname.TabIndex = 12;
            this.txtFullname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFullname_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fullname :";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(0)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(203, 336);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRegisterConfirmPssw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLoginRegister);
            this.Controls.Add(this.txtRegisterPssw);
            this.Controls.Add(this.txtRegisterEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Register_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRegisterPssw;
        private System.Windows.Forms.TextBox txtRegisterEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoginRegister;
        private System.Windows.Forms.TextBox txtRegisterConfirmPssw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label label4;
    }
}