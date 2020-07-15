namespace CarManagement.admin
{
    partial class InsertInvoice
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
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCarID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbModel = new System.Windows.Forms.Label();
            this.lbBrand = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.lbCarName = new System.Windows.Forms.Label();
            this.lbCarID = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lnCusName = new System.Windows.Forms.Label();
            this.lbCusPhone = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddInvoice = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCustomer
            // 
            this.txtCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCustomer.Location = new System.Drawing.Point(275, 40);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(354, 22);
            this.txtCustomer.TabIndex = 0;
            this.txtCustomer.TextChanged += new System.EventHandler(this.txtCustomer_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Customer Phone:";
            // 
            // txtCarID
            // 
            this.txtCarID.Location = new System.Drawing.Point(275, 147);
            this.txtCarID.Name = "txtCarID";
            this.txtCarID.Size = new System.Drawing.Size(354, 22);
            this.txtCarID.TabIndex = 2;
            this.txtCarID.TextChanged += new System.EventHandler(this.txtCarName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter CarID:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbPrice);
            this.panel1.Controls.Add(this.lbModel);
            this.panel1.Controls.Add(this.lbBrand);
            this.panel1.Controls.Add(this.lbType);
            this.panel1.Controls.Add(this.lbCarName);
            this.panel1.Controls.Add(this.lbCarID);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbEmail);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.lbAddress);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lnCusName);
            this.panel1.Controls.Add(this.lbCusPhone);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(31, 240);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 293);
            this.panel1.TabIndex = 4;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(485, 233);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(20, 17);
            this.lbPrice.TabIndex = 20;
            this.lbPrice.Text = "...";
            // 
            // lbModel
            // 
            this.lbModel.AutoSize = true;
            this.lbModel.Location = new System.Drawing.Point(485, 189);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(20, 17);
            this.lbModel.TabIndex = 19;
            this.lbModel.Text = "...";
            // 
            // lbBrand
            // 
            this.lbBrand.AutoSize = true;
            this.lbBrand.Location = new System.Drawing.Point(485, 150);
            this.lbBrand.Name = "lbBrand";
            this.lbBrand.Size = new System.Drawing.Size(20, 17);
            this.lbBrand.TabIndex = 18;
            this.lbBrand.Text = "...";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(485, 114);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(20, 17);
            this.lbType.TabIndex = 17;
            this.lbType.Text = "...";
            // 
            // lbCarName
            // 
            this.lbCarName.AutoSize = true;
            this.lbCarName.Location = new System.Drawing.Point(485, 72);
            this.lbCarName.Name = "lbCarName";
            this.lbCarName.Size = new System.Drawing.Size(20, 17);
            this.lbCarName.TabIndex = 16;
            this.lbCarName.Text = "...";
            // 
            // lbCarID
            // 
            this.lbCarID.AutoSize = true;
            this.lbCarID.Location = new System.Drawing.Point(485, 26);
            this.lbCarID.Name = "lbCarID";
            this.lbCarID.Size = new System.Drawing.Size(20, 17);
            this.lbCarID.TabIndex = 15;
            this.lbCarID.Text = "...";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(369, 237);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "Price:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(369, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "Model:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(369, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Brand: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(369, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Type: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(369, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Car Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Car ID:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(173, 110);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(20, 17);
            this.lbEmail.TabIndex = 8;
            this.lbEmail.Text = "...";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(29, 110);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(50, 17);
            this.label.TabIndex = 7;
            this.label.Text = "Email: ";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(173, 150);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(20, 17);
            this.lbAddress.TabIndex = 6;
            this.lbAddress.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Address: ";
            // 
            // lnCusName
            // 
            this.lnCusName.AutoSize = true;
            this.lnCusName.Location = new System.Drawing.Point(173, 72);
            this.lnCusName.Name = "lnCusName";
            this.lnCusName.Size = new System.Drawing.Size(20, 17);
            this.lnCusName.TabIndex = 4;
            this.lnCusName.Text = "...";
            // 
            // lbCusPhone
            // 
            this.lbCusPhone.AutoSize = true;
            this.lbCusPhone.Location = new System.Drawing.Point(173, 26);
            this.lbCusPhone.Name = "lbCusPhone";
            this.lbCusPhone.Size = new System.Drawing.Size(20, 17);
            this.lbCusPhone.TabIndex = 3;
            this.lbCusPhone.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Customer Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Customer Phone: ";
            // 
            // btnAddInvoice
            // 
            this.btnAddInvoice.Location = new System.Drawing.Point(274, 576);
            this.btnAddInvoice.Name = "btnAddInvoice";
            this.btnAddInvoice.Size = new System.Drawing.Size(169, 44);
            this.btnAddInvoice.TabIndex = 5;
            this.btnAddInvoice.Text = "Add";
            this.btnAddInvoice.UseVisualStyleBackColor = true;
            this.btnAddInvoice.Click += new System.EventHandler(this.btnAddInvoice_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(515, 577);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(166, 42);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // InsertInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 684);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddInvoice);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCarID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCustomer);
            this.Name = "InsertInvoice";
            this.Text = "InsertInvoice";
            this.Load += new System.EventHandler(this.InsertInvoice_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCusPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbModel;
        private System.Windows.Forms.Label lbBrand;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbCarName;
        private System.Windows.Forms.Label lbCarID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lnCusName;
        private System.Windows.Forms.Button btnAddInvoice;
        private System.Windows.Forms.Button btnCancel;
    }
}