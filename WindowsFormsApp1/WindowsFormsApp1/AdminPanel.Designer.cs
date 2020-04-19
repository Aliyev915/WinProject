namespace WindowsFormsApp1
{
    partial class AdminPanel
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.lblUserCount = new System.Windows.Forms.Label();
            this.usersCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserEmail = new System.Windows.Forms.TextBox();
            this.cmbPrevilieges = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUsers = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activeUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletedUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicineTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(218)))), ((int)(((byte)(197)))));
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvUsers.Location = new System.Drawing.Point(0, 185);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(499, 147);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellDoubleClick);
            // 
            // lblUserCount
            // 
            this.lblUserCount.AutoSize = true;
            this.lblUserCount.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserCount.ForeColor = System.Drawing.Color.White;
            this.lblUserCount.Location = new System.Drawing.Point(351, 9);
            this.lblUserCount.Name = "lblUserCount";
            this.lblUserCount.Size = new System.Drawing.Size(96, 21);
            this.lblUserCount.TabIndex = 1;
            this.lblUserCount.Text = "New users :";
            // 
            // usersCount
            // 
            this.usersCount.AutoSize = true;
            this.usersCount.ForeColor = System.Drawing.Color.Red;
            this.usersCount.Location = new System.Drawing.Point(453, 17);
            this.usersCount.Name = "usersCount";
            this.usersCount.Size = new System.Drawing.Size(34, 13);
            this.usersCount.TabIndex = 2;
            this.usersCount.Text = "count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email :";
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserEmail.Location = new System.Drawing.Point(16, 92);
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.Size = new System.Drawing.Size(134, 22);
            this.txtUserEmail.TabIndex = 4;
            // 
            // cmbPrevilieges
            // 
            this.cmbPrevilieges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrevilieges.FormattingEnabled = true;
            this.cmbPrevilieges.Location = new System.Drawing.Point(182, 91);
            this.cmbPrevilieges.Name = "cmbPrevilieges";
            this.cmbPrevilieges.Size = new System.Drawing.Size(121, 24);
            this.cmbPrevilieges.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(179)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(322, 91);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(178, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Previligies :";
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.ForeColor = System.Drawing.Color.White;
            this.lblUsers.Location = new System.Drawing.Point(213, 147);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(90, 21);
            this.lblUsers.TabIndex = 8;
            this.lblUsers.Text = "New Users";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(0)))), ((int)(((byte)(238)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.medicineTypesToolStripMenuItem,
            this.medicinesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(499, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newUsersToolStripMenuItem,
            this.activeUsersToolStripMenuItem,
            this.deletedUsersToolStripMenuItem});
            this.usersToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // newUsersToolStripMenuItem
            // 
            this.newUsersToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(0)))), ((int)(((byte)(238)))));
            this.newUsersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.newUsersToolStripMenuItem.Name = "newUsersToolStripMenuItem";
            this.newUsersToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.newUsersToolStripMenuItem.Text = "New Users";
            this.newUsersToolStripMenuItem.Click += new System.EventHandler(this.newUsersToolStripMenuItem_Click);
            // 
            // activeUsersToolStripMenuItem
            // 
            this.activeUsersToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(0)))), ((int)(((byte)(238)))));
            this.activeUsersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.activeUsersToolStripMenuItem.Name = "activeUsersToolStripMenuItem";
            this.activeUsersToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.activeUsersToolStripMenuItem.Text = "Active Users";
            this.activeUsersToolStripMenuItem.Click += new System.EventHandler(this.activeUsersToolStripMenuItem_Click);
            // 
            // deletedUsersToolStripMenuItem
            // 
            this.deletedUsersToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(0)))), ((int)(((byte)(238)))));
            this.deletedUsersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.deletedUsersToolStripMenuItem.Name = "deletedUsersToolStripMenuItem";
            this.deletedUsersToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.deletedUsersToolStripMenuItem.Text = "Deleted Users";
            this.deletedUsersToolStripMenuItem.Click += new System.EventHandler(this.deletedUsersToolStripMenuItem_Click);
            // 
            // medicineTypesToolStripMenuItem
            // 
            this.medicineTypesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createTypeToolStripMenuItem,
            this.deleteTypeToolStripMenuItem});
            this.medicineTypesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicineTypesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.medicineTypesToolStripMenuItem.Name = "medicineTypesToolStripMenuItem";
            this.medicineTypesToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.medicineTypesToolStripMenuItem.Text = "Medicine Types";
            // 
            // createTypeToolStripMenuItem
            // 
            this.createTypeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(0)))), ((int)(((byte)(238)))));
            this.createTypeToolStripMenuItem.Name = "createTypeToolStripMenuItem";
            this.createTypeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createTypeToolStripMenuItem.Text = "Create Type";
            this.createTypeToolStripMenuItem.Click += new System.EventHandler(this.createTypeToolStripMenuItem_Click);
            // 
            // deleteTypeToolStripMenuItem
            // 
            this.deleteTypeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(0)))), ((int)(((byte)(238)))));
            this.deleteTypeToolStripMenuItem.Name = "deleteTypeToolStripMenuItem";
            this.deleteTypeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteTypeToolStripMenuItem.Text = "Delete Type";
            this.deleteTypeToolStripMenuItem.Click += new System.EventHandler(this.deleteTypeToolStripMenuItem_Click);
            // 
            // medicinesToolStripMenuItem
            // 
            this.medicinesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicinesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.medicinesToolStripMenuItem.Name = "medicinesToolStripMenuItem";
            this.medicinesToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.medicinesToolStripMenuItem.Text = "Medicines";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(0)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(499, 332);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbPrevilieges);
            this.Controls.Add(this.txtUserEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usersCount);
            this.Controls.Add(this.lblUserCount);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminPanel_FormClosing);
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Label lblUserCount;
        private System.Windows.Forms.Label usersCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserEmail;
        private System.Windows.Forms.ComboBox cmbPrevilieges;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activeUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletedUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicineTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicinesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}