namespace WindowsFormsApp1
{
    partial class CreateType
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
            this.txtCreateType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCreateType
            // 
            this.txtCreateType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateType.Location = new System.Drawing.Point(16, 76);
            this.txtCreateType.Name = "txtCreateType";
            this.txtCreateType.Size = new System.Drawing.Size(171, 26);
            this.txtCreateType.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type :";
            // 
            // btnCreateType
            // 
            this.btnCreateType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(218)))), ((int)(((byte)(197)))));
            this.btnCreateType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateType.Location = new System.Drawing.Point(16, 171);
            this.btnCreateType.Name = "btnCreateType";
            this.btnCreateType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCreateType.Size = new System.Drawing.Size(167, 34);
            this.btnCreateType.TabIndex = 6;
            this.btnCreateType.Text = "Create Type";
            this.btnCreateType.UseVisualStyleBackColor = false;
            this.btnCreateType.Click += new System.EventHandler(this.btnCreateType_Click);
            // 
            // CreateType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(0)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(204, 277);
            this.Controls.Add(this.btnCreateType);
            this.Controls.Add(this.txtCreateType);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCreateType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateType;
    }
}