namespace Medical_system
{
    partial class MangeUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MangeUser));
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxAddlogin = new System.Windows.Forms.GroupBox();
            this.bntAddUser = new System.Windows.Forms.Button();
            this.txtcpass = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lbladd = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBoxDeletelogin = new System.Windows.Forms.GroupBox();
            this.txtUname = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbluserName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBoxviewloginuser = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxAddlogin.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBoxDeletelogin.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBoxviewloginuser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BIZ UDGothic", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Turquoise;
            this.label1.Location = new System.Drawing.Point(299, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(620, 47);
            this.label1.TabIndex = 6;
            this.label1.Text = "MANAGE LOGIN USER HERE !!";
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.ItemSize = new System.Drawing.Size(103, 35);
            this.tabControl.Location = new System.Drawing.Point(97, 121);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(991, 459);
            this.tabControl.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Turquoise;
            this.tabPage1.Controls.Add(this.groupBoxAddlogin);
            this.tabPage1.Controls.Add(this.lbladd);
            this.tabPage1.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(983, 416);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add New User";
            // 
            // groupBoxAddlogin
            // 
            this.groupBoxAddlogin.Controls.Add(this.bntAddUser);
            this.groupBoxAddlogin.Controls.Add(this.txtcpass);
            this.groupBoxAddlogin.Controls.Add(this.txtpass);
            this.groupBoxAddlogin.Controls.Add(this.txtname);
            this.groupBoxAddlogin.Controls.Add(this.lblConfirm);
            this.groupBoxAddlogin.Controls.Add(this.lblPassword);
            this.groupBoxAddlogin.Controls.Add(this.lblName);
            this.groupBoxAddlogin.Location = new System.Drawing.Point(157, 70);
            this.groupBoxAddlogin.Name = "groupBoxAddlogin";
            this.groupBoxAddlogin.Size = new System.Drawing.Size(647, 318);
            this.groupBoxAddlogin.TabIndex = 3;
            this.groupBoxAddlogin.TabStop = false;
            this.groupBoxAddlogin.Text = "Add Login User";
            // 
            // bntAddUser
            // 
            this.bntAddUser.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAddUser.Location = new System.Drawing.Point(268, 234);
            this.bntAddUser.Name = "bntAddUser";
            this.bntAddUser.Size = new System.Drawing.Size(109, 40);
            this.bntAddUser.TabIndex = 11;
            this.bntAddUser.Text = "ADD USER";
            this.bntAddUser.UseVisualStyleBackColor = true;
            this.bntAddUser.Click += new System.EventHandler(this.bntAddUser_Click);
            // 
            // txtcpass
            // 
            this.txtcpass.BackColor = System.Drawing.Color.Honeydew;
            this.txtcpass.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcpass.Location = new System.Drawing.Point(324, 154);
            this.txtcpass.Name = "txtcpass";
            this.txtcpass.PasswordChar = '*';
            this.txtcpass.Size = new System.Drawing.Size(160, 36);
            this.txtcpass.TabIndex = 9;
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.Honeydew;
            this.txtpass.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(324, 108);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(160, 36);
            this.txtpass.TabIndex = 6;
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.Honeydew;
            this.txtname.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(324, 62);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(160, 36);
            this.txtname.TabIndex = 5;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblConfirm.Location = new System.Drawing.Point(147, 157);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(175, 28);
            this.lblConfirm.TabIndex = 2;
            this.lblConfirm.Text = "Confirm-Password :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblPassword.Location = new System.Drawing.Point(147, 111);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(99, 28);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblName.Location = new System.Drawing.Point(147, 65);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(110, 28);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "User Name :";
            // 
            // lbladd
            // 
            this.lbladd.AutoSize = true;
            this.lbladd.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladd.ForeColor = System.Drawing.Color.Transparent;
            this.lbladd.Location = new System.Drawing.Point(304, 14);
            this.lbladd.Name = "lbladd";
            this.lbladd.Size = new System.Drawing.Size(342, 65);
            this.lbladd.TabIndex = 2;
            this.lbladd.Text = "ADD NEW USER";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Turquoise;
            this.tabPage3.Controls.Add(this.groupBoxDeletelogin);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(983, 416);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Delete User";
            // 
            // groupBoxDeletelogin
            // 
            this.groupBoxDeletelogin.Controls.Add(this.txtUname);
            this.groupBoxDeletelogin.Controls.Add(this.btnDelete);
            this.groupBoxDeletelogin.Controls.Add(this.lbluserName);
            this.groupBoxDeletelogin.Location = new System.Drawing.Point(163, 78);
            this.groupBoxDeletelogin.Name = "groupBoxDeletelogin";
            this.groupBoxDeletelogin.Size = new System.Drawing.Size(647, 301);
            this.groupBoxDeletelogin.TabIndex = 4;
            this.groupBoxDeletelogin.TabStop = false;
            this.groupBoxDeletelogin.Text = "Delete Login User";
            // 
            // txtUname
            // 
            this.txtUname.Location = new System.Drawing.Point(301, 100);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(144, 36);
            this.txtUname.TabIndex = 12;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(270, 178);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 37);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "DELETE USER";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbluserName
            // 
            this.lbluserName.AutoSize = true;
            this.lbluserName.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbluserName.Location = new System.Drawing.Point(162, 103);
            this.lbluserName.Name = "lbluserName";
            this.lbluserName.Size = new System.Drawing.Size(110, 28);
            this.lbluserName.TabIndex = 0;
            this.lbluserName.Text = "User Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(342, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 65);
            this.label4.TabIndex = 3;
            this.label4.Text = "DELETE USER";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Turquoise;
            this.tabPage4.Controls.Add(this.groupBoxviewloginuser);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(983, 416);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "User List";
            // 
            // groupBoxviewloginuser
            // 
            this.groupBoxviewloginuser.Controls.Add(this.dataGridView1);
            this.groupBoxviewloginuser.Location = new System.Drawing.Point(152, 58);
            this.groupBoxviewloginuser.Name = "groupBoxviewloginuser";
            this.groupBoxviewloginuser.Size = new System.Drawing.Size(677, 325);
            this.groupBoxviewloginuser.TabIndex = 5;
            this.groupBoxviewloginuser.TabStop = false;
            this.groupBoxviewloginuser.Text = "View Login User";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.Turquoise;
            this.dataGridView1.Location = new System.Drawing.Point(208, 35);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Purple;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(243, 277);
            this.dataGridView1.TabIndex = 0;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "U_Name";
            this.UserName.Frozen = true;
            this.UserName.HeaderText = "UserName";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 200;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(311, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(347, 65);
            this.label5.TabIndex = 4;
            this.label5.Text = "VIEW USER LIST";
            // 
            // MangeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl);
            this.Name = "MangeUser";
            this.Text = "MangeUser";
            this.Load += new System.EventHandler(this.MangeUser_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBoxAddlogin.ResumeLayout(false);
            this.groupBoxAddlogin.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBoxDeletelogin.ResumeLayout(false);
            this.groupBoxDeletelogin.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBoxviewloginuser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBoxAddlogin;
        private System.Windows.Forms.Button bntAddUser;
        private System.Windows.Forms.TextBox txtcpass;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lbladd;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBoxDeletelogin;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lbluserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBoxviewloginuser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUname;
    }
}