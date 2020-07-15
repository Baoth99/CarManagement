namespace CarManagement.admin
{
    partial class Admin
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
            this.lbID = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.tbCustomer = new System.Windows.Forms.TabPage();
            this.pictureBoxCustomer = new System.Windows.Forms.PictureBox();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRefreshCus = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnUpdateCus = new System.Windows.Forms.Button();
            this.btnDeleteCus = new System.Windows.Forms.Button();
            this.btnAddCus = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lb100 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tpEmployee = new System.Windows.Forms.TabPage();
            this.tbCar = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtCarID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnDetail = new System.Windows.Forms.Button();
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.txtSearchCar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCar = new System.Windows.Forms.DataGridView();
            this.tpInvoice = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.dgvManageInvoice = new System.Windows.Forms.DataGridView();
            this.btnAddInvoice = new System.Windows.Forms.Button();
            this.tcAdmin.SuspendLayout();
            this.tbCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.panel3.SuspendLayout();
            this.tbCar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCar)).BeginInit();
            this.tpInvoice.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(52, 10);
            this.lbID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(59, 20);
            this.lbID.TabIndex = 2;
            this.lbID.Text = "label1";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(535, 25);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(157, 39);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tbCustomer);
            this.tcAdmin.Controls.Add(this.tpEmployee);
            this.tcAdmin.Controls.Add(this.tbCar);
            this.tcAdmin.Controls.Add(this.tpInvoice);
            this.tcAdmin.Location = new System.Drawing.Point(45, 87);
            this.tcAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(1520, 657);
            this.tcAdmin.TabIndex = 13;
            // 
            // tbCustomer
            // 
            this.tbCustomer.Controls.Add(this.pictureBoxCustomer);
            this.tbCustomer.Controls.Add(this.dgvCustomer);
            this.tbCustomer.Controls.Add(this.panel3);
            this.tbCustomer.Location = new System.Drawing.Point(4, 25);
            this.tbCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCustomer.Size = new System.Drawing.Size(1512, 628);
            this.tbCustomer.TabIndex = 2;
            this.tbCustomer.Text = "Customer";
            this.tbCustomer.UseVisualStyleBackColor = true;
            // 
            // pictureBoxCustomer
            // 
            this.pictureBoxCustomer.Location = new System.Drawing.Point(1096, 212);
            this.pictureBoxCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxCustomer.Name = "pictureBoxCustomer";
            this.pictureBoxCustomer.Size = new System.Drawing.Size(383, 366);
            this.pictureBoxCustomer.TabIndex = 17;
            this.pictureBoxCustomer.TabStop = false;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.AllowUserToResizeRows = false;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(23, 212);
            this.dgvCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.Size = new System.Drawing.Size(1065, 366);
            this.dgvCustomer.TabIndex = 11;
            this.dgvCustomer.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCustomer_CellMouseClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRefreshCus);
            this.panel3.Controls.Add(this.txtCustomerName);
            this.panel3.Controls.Add(this.txtSearchCustomer);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.btnUpdateCus);
            this.panel3.Controls.Add(this.btnDeleteCus);
            this.panel3.Controls.Add(this.btnAddCus);
            this.panel3.Controls.Add(this.txtAddress);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.lb100);
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Controls.Add(this.txtPhone);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Location = new System.Drawing.Point(29, 27);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1467, 146);
            this.panel3.TabIndex = 15;
            // 
            // btnRefreshCus
            // 
            this.btnRefreshCus.Location = new System.Drawing.Point(1263, 78);
            this.btnRefreshCus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefreshCus.Name = "btnRefreshCus";
            this.btnRefreshCus.Size = new System.Drawing.Size(187, 52);
            this.btnRefreshCus.TabIndex = 28;
            this.btnRefreshCus.Text = "Refresh";
            this.btnRefreshCus.UseVisualStyleBackColor = true;
            this.btnRefreshCus.Click += new System.EventHandler(this.btnRefreshCus_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(132, 55);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(216, 22);
            this.txtCustomerName.TabIndex = 4;
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Location = new System.Drawing.Point(268, 107);
            this.txtSearchCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(543, 22);
            this.txtSearchCustomer.TabIndex = 7;
            this.txtSearchCustomer.TextChanged += new System.EventHandler(this.txtSearchCustomer_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(193, 110);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 17);
            this.label15.TabIndex = 27;
            this.label15.Text = "Search:";
            // 
            // btnUpdateCus
            // 
            this.btnUpdateCus.Location = new System.Drawing.Point(1263, 10);
            this.btnUpdateCus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateCus.Name = "btnUpdateCus";
            this.btnUpdateCus.Size = new System.Drawing.Size(187, 53);
            this.btnUpdateCus.TabIndex = 9;
            this.btnUpdateCus.Text = "Update";
            this.btnUpdateCus.UseVisualStyleBackColor = true;
            this.btnUpdateCus.Click += new System.EventHandler(this.btnUpdateCus_Click);
            // 
            // btnDeleteCus
            // 
            this.btnDeleteCus.Location = new System.Drawing.Point(1064, 75);
            this.btnDeleteCus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteCus.Name = "btnDeleteCus";
            this.btnDeleteCus.Size = new System.Drawing.Size(187, 52);
            this.btnDeleteCus.TabIndex = 10;
            this.btnDeleteCus.Text = "Delete";
            this.btnDeleteCus.UseVisualStyleBackColor = true;
            this.btnDeleteCus.Click += new System.EventHandler(this.btnDeleteCus_Click);
            // 
            // btnAddCus
            // 
            this.btnAddCus.Location = new System.Drawing.Point(1064, 10);
            this.btnAddCus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddCus.Name = "btnAddCus";
            this.btnAddCus.Size = new System.Drawing.Size(187, 48);
            this.btnAddCus.TabIndex = 8;
            this.btnAddCus.Text = "Add New Customer";
            this.btnAddCus.UseVisualStyleBackColor = true;
            this.btnAddCus.Click += new System.EventHandler(this.btnAddCus_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(723, 6);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(216, 22);
            this.txtAddress.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(664, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 17);
            this.label17.TabIndex = 18;
            this.label17.Text = "Address:";
            // 
            // lb100
            // 
            this.lb100.AutoSize = true;
            this.lb100.Location = new System.Drawing.Point(13, 10);
            this.lb100.Name = "lb100";
            this.lb100.Size = new System.Drawing.Size(57, 17);
            this.lb100.TabIndex = 8;
            this.lb100.Text = "Phone: ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(723, 58);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(216, 22);
            this.txtEmail.TabIndex = 6;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(132, 7);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(216, 22);
            this.txtPhone.TabIndex = 3;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(664, 63);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(46, 17);
            this.label22.TabIndex = 12;
            this.label22.Text = "Email:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(13, 58);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(113, 17);
            this.label23.TabIndex = 10;
            this.label23.Text = "Customer Name:";
            // 
            // tpEmployee
            // 
            this.tpEmployee.Location = new System.Drawing.Point(4, 25);
            this.tpEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpEmployee.Name = "tpEmployee";
            this.tpEmployee.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpEmployee.Size = new System.Drawing.Size(1512, 628);
            this.tpEmployee.TabIndex = 0;
            this.tpEmployee.Text = "Employee";
            this.tpEmployee.UseVisualStyleBackColor = true;
            // 
            // tbCar
            // 
            this.tbCar.Controls.Add(this.btnRefresh);
            this.tbCar.Controls.Add(this.panel2);
            this.tbCar.Controls.Add(this.btnDetail);
            this.tbCar.Controls.Add(this.pictureBoxCar);
            this.tbCar.Controls.Add(this.txtSearchCar);
            this.tbCar.Controls.Add(this.label1);
            this.tbCar.Controls.Add(this.dgvCar);
            this.tbCar.Location = new System.Drawing.Point(4, 25);
            this.tbCar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCar.Name = "tbCar";
            this.tbCar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCar.Size = new System.Drawing.Size(1512, 628);
            this.tbCar.TabIndex = 1;
            this.tbCar.Text = "Car";
            this.tbCar.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1096, 175);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(183, 47);
            this.btnRefresh.TabIndex = 29;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnChooseImage);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.txtImage);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.cbStatus);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtColor);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtOrigin);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtModel);
            this.panel2.Controls.Add(this.txtBrand);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtType);
            this.panel2.Controls.Add(this.txtCarID);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Location = new System.Drawing.Point(29, 14);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1467, 146);
            this.panel2.TabIndex = 14;
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.Location = new System.Drawing.Point(1064, 34);
            this.btnChooseImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(171, 30);
            this.btnChooseImage.TabIndex = 25;
            this.btnChooseImage.Text = "Choose Image";
            this.btnChooseImage.UseVisualStyleBackColor = true;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1064, 78);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(187, 53);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1263, 78);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(187, 52);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtImage
            // 
            this.txtImage.Cursor = System.Windows.Forms.Cursors.No;
            this.txtImage.Enabled = false;
            this.txtImage.Location = new System.Drawing.Point(1064, 7);
            this.txtImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(169, 22);
            this.txtImage.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(979, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 17);
            this.label13.TabIndex = 24;
            this.label13.Text = "Image File: ";
            // 
            // cbStatus
            // 
            this.cbStatus.AutoSize = true;
            this.cbStatus.Location = new System.Drawing.Point(723, 117);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(53, 21);
            this.cbStatus.TabIndex = 23;
            this.cbStatus.Text = "Sell";
            this.cbStatus.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1263, 12);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(187, 48);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Add New Car";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(664, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "Status:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(723, 57);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(215, 22);
            this.txtPrice.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(664, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Price:";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(723, 6);
            this.txtColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(216, 22);
            this.txtColor.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(664, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Color:";
            // 
            // txtOrigin
            // 
            this.txtOrigin.Location = new System.Drawing.Point(397, 112);
            this.txtOrigin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(216, 22);
            this.txtOrigin.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(341, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Origin:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(344, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Model:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(397, 58);
            this.txtModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(216, 22);
            this.txtModel.TabIndex = 19;
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(397, 7);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(216, 22);
            this.txtBrand.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Brand:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Car ID:";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(71, 112);
            this.txtType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(216, 22);
            this.txtType.TabIndex = 17;
            // 
            // txtCarID
            // 
            this.txtCarID.Location = new System.Drawing.Point(71, 7);
            this.txtCarID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCarID.Name = "txtCarID";
            this.txtCarID.Size = new System.Drawing.Size(216, 22);
            this.txtCarID.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(71, 58);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(216, 22);
            this.txtName.TabIndex = 16;
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(1308, 175);
            this.btnDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(171, 48);
            this.btnDetail.TabIndex = 30;
            this.btnDetail.Text = "Detail";
            this.btnDetail.UseVisualStyleBackColor = true;
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.Location = new System.Drawing.Point(1096, 239);
            this.pictureBoxCar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(383, 366);
            this.pictureBoxCar.TabIndex = 3;
            this.pictureBoxCar.TabStop = false;
            // 
            // txtSearchCar
            // 
            this.txtSearchCar.Location = new System.Drawing.Point(100, 188);
            this.txtSearchCar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchCar.Name = "txtSearchCar";
            this.txtSearchCar.Size = new System.Drawing.Size(543, 22);
            this.txtSearchCar.TabIndex = 31;
            this.txtSearchCar.TextChanged += new System.EventHandler(this.txtSearchCar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search:";
            // 
            // dgvCar
            // 
            this.dgvCar.AllowUserToAddRows = false;
            this.dgvCar.AllowUserToDeleteRows = false;
            this.dgvCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCar.Location = new System.Drawing.Point(23, 239);
            this.dgvCar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCar.Name = "dgvCar";
            this.dgvCar.ReadOnly = true;
            this.dgvCar.RowHeadersWidth = 51;
            this.dgvCar.Size = new System.Drawing.Size(1065, 366);
            this.dgvCar.TabIndex = 0;
            this.dgvCar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCar_CellClick);
            // 
            // tpInvoice
            // 
            this.tpInvoice.Controls.Add(this.btnAddInvoice);
            this.tpInvoice.Controls.Add(this.dgvManageInvoice);
            this.tpInvoice.Location = new System.Drawing.Point(4, 25);
            this.tpInvoice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpInvoice.Name = "tpInvoice";
            this.tpInvoice.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpInvoice.Size = new System.Drawing.Size(1512, 628);
            this.tpInvoice.TabIndex = 3;
            this.tpInvoice.Text = "Manage Invoice";
            this.tpInvoice.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbID);
            this.panel1.Location = new System.Drawing.Point(49, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 52);
            this.panel1.TabIndex = 5;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(325, 10);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(59, 20);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(209, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID: ";
            // 
            // dgvManageInvoice
            // 
            this.dgvManageInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageInvoice.Location = new System.Drawing.Point(22, 170);
            this.dgvManageInvoice.Name = "dgvManageInvoice";
            this.dgvManageInvoice.RowHeadersWidth = 51;
            this.dgvManageInvoice.RowTemplate.Height = 24;
            this.dgvManageInvoice.Size = new System.Drawing.Size(862, 431);
            this.dgvManageInvoice.TabIndex = 0;
            // 
            // btnAddInvoice
            // 
            this.btnAddInvoice.Location = new System.Drawing.Point(22, 60);
            this.btnAddInvoice.Name = "btnAddInvoice";
            this.btnAddInvoice.Size = new System.Drawing.Size(184, 52);
            this.btnAddInvoice.TabIndex = 1;
            this.btnAddInvoice.Text = "Add Invoice";
            this.btnAddInvoice.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1595, 770);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tcAdmin);
            this.Controls.Add(this.btnLogout);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.tcAdmin.ResumeLayout(false);
            this.tbCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tbCar.ResumeLayout(false);
            this.tbCar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCar)).EndInit();
            this.tpInvoice.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageInvoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabControl tcAdmin;
        private System.Windows.Forms.TabPage tpEmployee;
        private System.Windows.Forms.TabPage tbCar;
        private System.Windows.Forms.TabPage tbCustomer;
        private System.Windows.Forms.TabPage tpInvoice;
        private System.Windows.Forms.TextBox txtSearchCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCar;
        private System.Windows.Forms.PictureBox pictureBoxCar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cbStatus;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUpdateCus;
        private System.Windows.Forms.Button btnDeleteCus;
        private System.Windows.Forms.Button btnAddCus;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lb100;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBoxCustomer;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Button btnRefreshCus;
        private System.Windows.Forms.Button btnAddInvoice;
        private System.Windows.Forms.DataGridView dgvManageInvoice;
    }
}