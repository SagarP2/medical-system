namespace Medical_system
{
    partial class Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxaddstock = new System.Windows.Forms.GroupBox();
            this.txtcompany = new System.Windows.Forms.TextBox();
            this.dateexpire = new System.Windows.Forms.DateTimePicker();
            this.txtlocation = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.txtiprice = new System.Windows.Forms.TextBox();
            this.txtiqnt = new System.Windows.Forms.TextBox();
            this.txtidetail = new System.Windows.Forms.TextBox();
            this.txtiname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBoxupdatestock = new System.Windows.Forms.GroupBox();
            this.textBoxiname = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtcurentqnt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.txtnewqnt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBoxDeletestock = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnDeletestock = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBoxviewstock = new System.Windows.Forms.GroupBox();
            this.dataGridView12 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxaddstock.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBoxupdatestock.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBoxDeletestock.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBoxviewstock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView12)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BIZ UDGothic", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Turquoise;
            this.label1.Location = new System.Drawing.Point(162, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(860, 47);
            this.label1.TabIndex = 5;
            this.label1.Text = "ADD / UPDATE / DELETE STOCK HERE !!";
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(200, 35);
            this.tabControl1.Location = new System.Drawing.Point(97, 74);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(991, 527);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Turquoise;
            this.tabPage1.Controls.Add(this.groupBoxaddstock);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(983, 484);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add New Stock";
            // 
            // groupBoxaddstock
            // 
            this.groupBoxaddstock.Controls.Add(this.txtcompany);
            this.groupBoxaddstock.Controls.Add(this.dateexpire);
            this.groupBoxaddstock.Controls.Add(this.txtlocation);
            this.groupBoxaddstock.Controls.Add(this.label12);
            this.groupBoxaddstock.Controls.Add(this.label11);
            this.groupBoxaddstock.Controls.Add(this.btnAddStock);
            this.groupBoxaddstock.Controls.Add(this.txtiprice);
            this.groupBoxaddstock.Controls.Add(this.txtiqnt);
            this.groupBoxaddstock.Controls.Add(this.txtidetail);
            this.groupBoxaddstock.Controls.Add(this.txtiname);
            this.groupBoxaddstock.Controls.Add(this.label10);
            this.groupBoxaddstock.Controls.Add(this.label9);
            this.groupBoxaddstock.Controls.Add(this.label8);
            this.groupBoxaddstock.Controls.Add(this.label7);
            this.groupBoxaddstock.Controls.Add(this.label6);
            this.groupBoxaddstock.Location = new System.Drawing.Point(162, 47);
            this.groupBoxaddstock.Name = "groupBoxaddstock";
            this.groupBoxaddstock.Size = new System.Drawing.Size(647, 430);
            this.groupBoxaddstock.TabIndex = 3;
            this.groupBoxaddstock.TabStop = false;
            this.groupBoxaddstock.Text = "Add Stock";
            // 
            // txtcompany
            // 
            this.txtcompany.BackColor = System.Drawing.Color.Honeydew;
            this.txtcompany.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcompany.Location = new System.Drawing.Point(293, 231);
            this.txtcompany.Name = "txtcompany";
            this.txtcompany.Size = new System.Drawing.Size(218, 36);
            this.txtcompany.TabIndex = 14;
            // 
            // dateexpire
            // 
            this.dateexpire.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateexpire.Location = new System.Drawing.Point(293, 324);
            this.dateexpire.Name = "dateexpire";
            this.dateexpire.Size = new System.Drawing.Size(218, 36);
            this.dateexpire.TabIndex = 11;
            // 
            // txtlocation
            // 
            this.txtlocation.BackColor = System.Drawing.Color.Honeydew;
            this.txtlocation.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlocation.Location = new System.Drawing.Point(293, 278);
            this.txtlocation.Name = "txtlocation";
            this.txtlocation.Size = new System.Drawing.Size(218, 36);
            this.txtlocation.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(134, 330);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 28);
            this.label12.TabIndex = 13;
            this.label12.Text = "Expire Date :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(131, 281);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 28);
            this.label11.TabIndex = 12;
            this.label11.Text = "Location :";
            // 
            // btnAddStock
            // 
            this.btnAddStock.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStock.Location = new System.Drawing.Point(238, 383);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(160, 37);
            this.btnAddStock.TabIndex = 12;
            this.btnAddStock.Text = "ADD STOCK";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // txtiprice
            // 
            this.txtiprice.BackColor = System.Drawing.Color.Honeydew;
            this.txtiprice.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtiprice.Location = new System.Drawing.Point(293, 136);
            this.txtiprice.Name = "txtiprice";
            this.txtiprice.Size = new System.Drawing.Size(218, 36);
            this.txtiprice.TabIndex = 7;
            // 
            // txtiqnt
            // 
            this.txtiqnt.BackColor = System.Drawing.Color.Honeydew;
            this.txtiqnt.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtiqnt.Location = new System.Drawing.Point(293, 184);
            this.txtiqnt.Name = "txtiqnt";
            this.txtiqnt.Size = new System.Drawing.Size(218, 36);
            this.txtiqnt.TabIndex = 8;
            // 
            // txtidetail
            // 
            this.txtidetail.BackColor = System.Drawing.Color.Honeydew;
            this.txtidetail.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidetail.Location = new System.Drawing.Point(293, 88);
            this.txtidetail.Name = "txtidetail";
            this.txtidetail.Size = new System.Drawing.Size(218, 36);
            this.txtidetail.TabIndex = 6;
            // 
            // txtiname
            // 
            this.txtiname.BackColor = System.Drawing.Color.Honeydew;
            this.txtiname.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtiname.Location = new System.Drawing.Point(293, 38);
            this.txtiname.Name = "txtiname";
            this.txtiname.Size = new System.Drawing.Size(218, 36);
            this.txtiname.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(131, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 28);
            this.label10.TabIndex = 4;
            this.label10.Text = "Company Name :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(131, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 28);
            this.label9.TabIndex = 3;
            this.label9.Text = "Qauntity :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(134, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 28);
            this.label8.TabIndex = 2;
            this.label8.Text = "Item Price :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(134, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 28);
            this.label7.TabIndex = 1;
            this.label7.Text = "Item Detail :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(134, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Item Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(286, -10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(398, 71);
            this.label2.TabIndex = 2;
            this.label2.Text = "ADD NEW STOCK";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Turquoise;
            this.tabPage2.Controls.Add(this.groupBoxupdatestock);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(983, 484);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update Stock";
            // 
            // groupBoxupdatestock
            // 
            this.groupBoxupdatestock.Controls.Add(this.textBoxiname);
            this.groupBoxupdatestock.Controls.Add(this.btnSelect);
            this.groupBoxupdatestock.Controls.Add(this.txtcurentqnt);
            this.groupBoxupdatestock.Controls.Add(this.label13);
            this.groupBoxupdatestock.Controls.Add(this.btnUpdateStock);
            this.groupBoxupdatestock.Controls.Add(this.txtnewqnt);
            this.groupBoxupdatestock.Controls.Add(this.label16);
            this.groupBoxupdatestock.Controls.Add(this.label19);
            this.groupBoxupdatestock.Location = new System.Drawing.Point(167, 89);
            this.groupBoxupdatestock.Name = "groupBoxupdatestock";
            this.groupBoxupdatestock.Size = new System.Drawing.Size(647, 331);
            this.groupBoxupdatestock.TabIndex = 4;
            this.groupBoxupdatestock.TabStop = false;
            this.groupBoxupdatestock.Text = "Update Stock";
            // 
            // textBoxiname
            // 
            this.textBoxiname.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxiname.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxiname.Location = new System.Drawing.Point(259, 64);
            this.textBoxiname.Name = "textBoxiname";
            this.textBoxiname.ReadOnly = true;
            this.textBoxiname.Size = new System.Drawing.Size(157, 36);
            this.textBoxiname.TabIndex = 17;
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(455, 118);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(111, 41);
            this.btnSelect.TabIndex = 13;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtcurentqnt
            // 
            this.txtcurentqnt.BackColor = System.Drawing.Color.Honeydew;
            this.txtcurentqnt.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcurentqnt.Location = new System.Drawing.Point(259, 118);
            this.txtcurentqnt.Name = "txtcurentqnt";
            this.txtcurentqnt.ReadOnly = true;
            this.txtcurentqnt.Size = new System.Drawing.Size(157, 36);
            this.txtcurentqnt.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(111, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 28);
            this.label13.TabIndex = 13;
            this.label13.Text = "Current Qnt :";
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStock.Location = new System.Drawing.Point(255, 255);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Size = new System.Drawing.Size(161, 37);
            this.btnUpdateStock.TabIndex = 16;
            this.btnUpdateStock.Text = "UPDATE STOCK";
            this.btnUpdateStock.UseVisualStyleBackColor = true;
            this.btnUpdateStock.Click += new System.EventHandler(this.btnUpdateStock_Click);
            // 
            // txtnewqnt
            // 
            this.txtnewqnt.BackColor = System.Drawing.Color.Honeydew;
            this.txtnewqnt.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnewqnt.Location = new System.Drawing.Point(259, 172);
            this.txtnewqnt.Name = "txtnewqnt";
            this.txtnewqnt.Size = new System.Drawing.Size(157, 36);
            this.txtnewqnt.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(111, 175);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 28);
            this.label16.TabIndex = 3;
            this.label16.Text = "Qauntity :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label19.Location = new System.Drawing.Point(111, 67);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(111, 28);
            this.label19.TabIndex = 0;
            this.label19.Text = "Item Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(323, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(364, 71);
            this.label3.TabIndex = 3;
            this.label3.Text = "UPDATE STOCK";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Turquoise;
            this.tabPage3.Controls.Add(this.groupBoxDeletestock);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(983, 484);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Remove Stock";
            // 
            // groupBoxDeletestock
            // 
            this.groupBoxDeletestock.Controls.Add(this.comboBox2);
            this.groupBoxDeletestock.Controls.Add(this.btnDeletestock);
            this.groupBoxDeletestock.Controls.Add(this.label17);
            this.groupBoxDeletestock.Location = new System.Drawing.Point(165, 128);
            this.groupBoxDeletestock.Name = "groupBoxDeletestock";
            this.groupBoxDeletestock.Size = new System.Drawing.Size(647, 278);
            this.groupBoxDeletestock.TabIndex = 5;
            this.groupBoxDeletestock.TabStop = false;
            this.groupBoxDeletestock.Text = "Delete Stock";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(283, 79);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(247, 36);
            this.comboBox2.TabIndex = 12;
            // 
            // btnDeletestock
            // 
            this.btnDeletestock.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletestock.Location = new System.Drawing.Point(221, 169);
            this.btnDeletestock.Name = "btnDeletestock";
            this.btnDeletestock.Size = new System.Drawing.Size(187, 37);
            this.btnDeletestock.TabIndex = 13;
            this.btnDeletestock.Text = "DELETE STOCK";
            this.btnDeletestock.UseVisualStyleBackColor = true;
            this.btnDeletestock.Click += new System.EventHandler(this.btnDeletestock_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(127, 82);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(111, 28);
            this.label17.TabIndex = 0;
            this.label17.Text = "Item Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(312, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(353, 71);
            this.label4.TabIndex = 3;
            this.label4.Text = "DELETE STOCK";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Turquoise;
            this.tabPage4.Controls.Add(this.groupBoxviewstock);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(983, 484);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "View Stock";
            // 
            // groupBoxviewstock
            // 
            this.groupBoxviewstock.Controls.Add(this.dataGridView12);
            this.groupBoxviewstock.Location = new System.Drawing.Point(48, 55);
            this.groupBoxviewstock.Name = "groupBoxviewstock";
            this.groupBoxviewstock.Size = new System.Drawing.Size(892, 346);
            this.groupBoxviewstock.TabIndex = 6;
            this.groupBoxviewstock.TabStop = false;
            this.groupBoxviewstock.Text = "View Stock";
            // 
            // dataGridView12
            // 
            this.dataGridView12.BackgroundColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView12.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView12.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView12.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView12.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridView12.Location = new System.Drawing.Point(21, 25);
            this.dataGridView12.Name = "dataGridView12";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Purple;
            this.dataGridView12.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView12.Size = new System.Drawing.Size(851, 311);
            this.dataGridView12.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(334, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(297, 71);
            this.label5.TabIndex = 4;
            this.label5.Text = "VIEW STOCK";
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Stock";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBoxaddstock.ResumeLayout(false);
            this.groupBoxaddstock.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBoxupdatestock.ResumeLayout(false);
            this.groupBoxupdatestock.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBoxDeletestock.ResumeLayout(false);
            this.groupBoxDeletestock.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBoxviewstock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBoxaddstock;
        private System.Windows.Forms.DateTimePicker dateexpire;
        private System.Windows.Forms.TextBox txtlocation;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.TextBox txtiprice;
        private System.Windows.Forms.TextBox txtiqnt;
        private System.Windows.Forms.TextBox txtidetail;
        private System.Windows.Forms.TextBox txtiname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBoxupdatestock;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtcurentqnt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnUpdateStock;
        private System.Windows.Forms.TextBox txtnewqnt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBoxDeletestock;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnDeletestock;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBoxviewstock;
        private System.Windows.Forms.DataGridView dataGridView12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcompany;
        private System.Windows.Forms.TextBox textBoxiname;
    }
}