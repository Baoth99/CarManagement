﻿using CarManagement.admin;
using Data.daos;
using Data.dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tool.checkinput;

namespace CarManagement.staff
{
    public partial class Staff : Form
    {
        public delegate void LoginSuccessfull(EmployeeDTO dto);
        public LoginSuccessfull data;
        readonly CarDAO dao = new CarDAO();
        readonly CustomerDAO daoCus = new CustomerDAO();
        readonly InvoiceDAO daoInv = new InvoiceDAO();
        DataTable dtCar;
        DataTable dtCustomer;
        DataTable dtInvoice;
        string filePath = "";
        public Staff()
        {
            InitializeComponent();
            data = new LoginSuccessfull(ReceiveData);
            loadData(false);
            refress();
            setCombobox();
        }
        public void Login()
        {
            Login login = new Login();
            login.ShowDialog();
        }
        private void ReceiveData(EmployeeDTO dto)
        {
            lbID.Text = dto.id;
            lbName.Text = dto.fullName;
        }

        private void loadData(bool sold)
        {
            dgvCar.DataSource = null;
            dtCar = dao.getCarList(sold);
            dgvCar.DataSource = dtCar;
            dgvCar.Columns["ImagesName"].Visible = false;
            dgvCar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ///
            dtCustomer = daoCus.getCustomerList();
            dgvCustomer.DataSource = dtCustomer;
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ///
            dgvManageInvoice.DataSource = null;
            dtInvoice = daoInv.getInvoiceList();
            dgvManageInvoice.DataSource = dtInvoice;
            dgvManageInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool check = checkFieldCar("INSERT");
            if (check)
            {
                string appPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
                string fileName = Path.GetFileNameWithoutExtension(txtImage.Text);
                string extension = Path.GetExtension(txtImage.Text);
                fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                CarDTO dto = new CarDTO()
                {
                    carID = txtCarID.Text,
                    name = txtName.Text,
                    type = txtType.Text,
                    brand = txtBrand.Text,
                    model = txtModel.Text,
                    origin = txtOrigin.Text,
                    color = txtColor.Text,
                    price = float.Parse(txtPrice.Text),
                    status = cbStatus.Checked,
                    imageName = fileName
                };
                try
                {
                    if (dao.insertNewCar(dto))
                    {
                        string path = Path.Combine(appPath + "\\images\\" + dto.imageName);
                        FileInfo fi = new FileInfo(filePath);
                        fi.CopyTo(path);
                        MessageBox.Show("Successfully insert car with an ID of: " + dto.carID, "Message");
                        filePath = "";
                        openFile.FileName = "";
                        loadData(false);
                        refress();
                    }
                    else
                    {
                        MessageBox.Show("UnSuccessfully insert car", "Message");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            else
            {
                return;
            }
        }

        private bool checkFieldCar(string action)
        {
            if (!Check.getString(txtCarID.Text))
            {
                MessageBox.Show("CarID Field is empty !", "Error");
                txtCarID.Focus();
                return false;
            }
            if (action.Equals("INSERT"))
            {
                if (!dao.checkIDDulicate(txtCarID.Text))
                {
                    MessageBox.Show("CarID is duplicate !", "Error");
                    txtCarID.Focus();
                    return false;
                }
            }
            if (!Check.getString(txtName.Text))
            {
                MessageBox.Show("Name Field is empty !", "Error");
                txtName.Focus();
                return false;
            }
            if (!Check.getString(txtType.Text))
            {
                MessageBox.Show("Type Field is empty !", "Error");
                txtName.Focus();
                return false;
            }
            if (!Check.getString(txtBrand.Text))
            {
                MessageBox.Show("Brand Field is empty !", "Error");
                txtBrand.Focus();
                return false;
            }
            if (!Check.getString(txtModel.Text))
            {
                MessageBox.Show("Model Field is empty !", "Error");
                txtModel.Focus();
                return false;
            }
            if (!Check.getString(txtOrigin.Text))
            {
                MessageBox.Show("Origin Field is empty !", "Error");
                txtOrigin.Focus();
                return false;
            }
            if (!Check.getString(txtColor.Text))
            {
                MessageBox.Show("Color Field is empty !", "Error");
                txtColor.Focus();
                return false;
            }
            if (!Check.getString(txtPrice.Text))
            {
                MessageBox.Show("Price Filed is empty !", "Error");
                txtPrice.Focus();
                return false;
            }
            if (!Check.getFloat(txtPrice.Text))
            {
                MessageBox.Show("Price is number !", "Error");
                txtPrice.Focus();
                return false;
            }
            if (!Check.getString(txtImage.Text))
            {
                MessageBox.Show("Choose Image !", "Error");
                return false;
            }

            return true;
        }
        //check fieled cus
        private bool checkFiledCustomer()
        {
            if (!Check.getString(txtPhone.Text))
            {
                MessageBox.Show("Phone number is empty!", "Error");
                txtPhone.Focus();
                return false;
            }
            if (!Check.checkPhone(txtPhone.Text))
            {
                MessageBox.Show("Phone number is 10 number,begin with 0 " +
                    "and contain numeric characters only (0 – 9)", "Error");
                return false;
            }
            if (!daoCus.checkPhoneDulicate(txtPhone.Text))
            {
                MessageBox.Show("Phone number is duplicate!", "Error");
            }
            if (!Check.getString(txtCustomerName.Text))
            {
                MessageBox.Show("Customer Name is empty!", "Error");
                txtCustomerName.Focus();
                return false;
            }
            if (!Check.getString(txtAddress.Text))
            {
                MessageBox.Show("Address is empty!", "Error");
                txtAddress.Focus();
                return false;
            }
            if (!Check.getString(txtEmail.Text))
            {
                MessageBox.Show("Email is empty!", "Error");
                txtEmail.Focus();
                return false;
            }
            if (!Check.checkEmail(txtEmail.Text))
            {
                MessageBox.Show("Email: max length is 30, contain only one “@” character" +
                    ", do not contain special characters (!, #, $)", "Error");
                txtEmail.Focus();
                return false;
            }
            return true;
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            try
            {
                openFile.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    txtImage.Text = openFile.SafeFileName;
                    filePath = openFile.FileName;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void showImage(string imageName)
        {
            try
            {
                string appPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
                this.pictureBoxCar.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxCar.Image = new Bitmap(appPath + "//images//" + imageName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void refress()
        {
            txtCarID.Enabled = true;
            txtCarID.Text = "";
            txtName.Text = "";
            txtType.Text = "";
            txtBrand.Text = "";
            txtModel.Text = "";
            txtOrigin.Text = "";
            txtColor.Text = "";
            txtPrice.Text = "";
            cbStatus.Checked = false;
            txtImage.Text = "";
            filePath = "";
            pictureBoxCar.Image = null;
            openFile.FileName = "";
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnAdd.Enabled = true;
            //refesh text customer
            txtPhone.Enabled = true;
            txtPhone.Text = "";
            txtCustomerName.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            btnUpdateCus.Enabled = false;
            btnAddCus.Enabled = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refress();
            databindings_clear_Car();
        }

        private void databindings_clear_Car()
        {
            txtCarID.DataBindings.Clear();
            txtName.DataBindings.Clear();
            txtType.DataBindings.Clear();
            txtBrand.DataBindings.Clear();
            txtModel.DataBindings.Clear();
            txtOrigin.DataBindings.Clear();
            txtColor.DataBindings.Clear();
            txtPrice.DataBindings.Clear();
            cbStatus.DataBindings.Clear();
            txtImage.DataBindings.Clear();
        }

        private void showTextBoxCar()
        {
            txtCarID.Enabled = false;
            txtCarID.DataBindings.Add("Text", dtCar, "CarID");
            txtName.DataBindings.Add("Text", dtCar, "Name");
            txtType.DataBindings.Add("Text", dtCar, "Type");
            txtBrand.DataBindings.Add("Text", dtCar, "Brand");
            txtModel.DataBindings.Add("Text", dtCar, "Model");
            txtOrigin.DataBindings.Add("Text", dtCar, "Origin");
            txtColor.DataBindings.Add("Text", dtCar, "Color");
            txtPrice.DataBindings.Add("Text", dtCar, "Price");
            cbStatus.DataBindings.Add("Checked", dtCar, "Status");
            txtImage.DataBindings.Add("Text", dtCar, "ImagesName");
        }

        private void dgvCar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvCar.RowCount == 0)
                {
                    return;
                }
                else
                {
                    databindings_clear_Car();
                    showTextBoxCar();
                    string imageName = "";
                    imageName = txtImage.Text;
                    showImage(imageName);
                    openFile.FileName = "";
                    filePath = "";
                    if (cbSale.GetItemText(cbSale.SelectedItem).Equals("Not sold yet"))
                    {
                        btnUpdate.Enabled = true;
                        btnDelete.Enabled = true;
                        btnChooseImage.Enabled = true;
                    }
                    btnAdd.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!Check.getString(txtCarID.Text))
            {
                MessageBox.Show("Please choose car that you want to delete !", "Error");
                txtCarID.Focus();
                return;
            }
            try
            {
                MessageBoxButtons button = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Do you want to delete car " + txtCarID.Text + " ? ", "Delete Car", button);
                if (result.Equals(DialogResult.Yes))
                {
                    string mess = (dao.deleteCar(txtCarID.Text) == true) ? "Sucessfull !" : "Fail !";
                    MessageBox.Show("Delete Car " + txtCarID.Text + " is " + mess + " !", "Delete Car");
                    loadData(false);
                    filePath = "";
                    openFile.FileName = "";
                    pictureBoxCar.Image = null;
                    refress();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CarDTO dto = null;
            bool check = checkFieldCar("UPDATE");
            if (check)
            {
                dto = new CarDTO()
                {
                    carID = txtCarID.Text,
                    name = txtName.Text,
                    type = txtType.Text,
                    brand = txtBrand.Text,
                    model = txtModel.Text,
                    origin = txtOrigin.Text,
                    color = txtColor.Text,
                    price = float.Parse(txtPrice.Text),
                    status = cbStatus.Checked
                };
                if (filePath.Length > 0 && filePath != "")
                {
                    txtImage.Text = openFile.SafeFileName;
                    string appPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
                    string fileName = Path.GetFileNameWithoutExtension(txtImage.Text);
                    string extension = Path.GetExtension(txtImage.Text);
                    fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    dto.imageName = txtImage.Text;
                    string path = Path.Combine(appPath + "\\images\\" + dto.imageName);
                    FileInfo fi = new FileInfo(filePath);
                    fi.CopyTo(path);
                }
                else
                {
                    dto.imageName = txtImage.Text;
                }
                try
                {
                    if (dao.updateCar(dto))
                    {
                        MessageBox.Show("Successfully update car with an ID of: " + dto.carID, "Message");
                        filePath = "";
                        openFile.FileName = "";
                        showImage(dto.imageName);
                        loadData(false);
                    }
                    else
                    {
                        MessageBox.Show("UnSuccessfully update car", "Message");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        private void btnAddCus_Click(object sender, EventArgs e)
        {
            bool check = checkFiledCustomer();
            if (check)
            {
                CustomerDTO dtoCus = new CustomerDTO()
                {
                    phone = txtPhone.Text,
                    customerName = txtCustomerName.Text,
                    email = txtEmail.Text,
                    address = txtAddress.Text,
                };
                try
                {
                    if (daoCus.addNewCustomer(dtoCus))
                    {
                        MessageBox.Show("Successfully add Customer with phone: " + dtoCus.phone, "Message");
                        loadData(false);
                        refress();
                    }
                    else
                    {
                        MessageBox.Show("UnSuccessfully add Customer", "Message");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            else
            {
                return;
            }
        }

        private void btnRefreshCus_Click(object sender, EventArgs e)
        {
            refress();
            databindings_clear_Customer();
        }


        private void databindings_clear_Customer()
        {
            txtPhone.DataBindings.Clear();
            txtCustomerName.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtAddress.DataBindings.Clear();
        }

        private void showTextBox_Customer()
        {
            txtPhone.Enabled = false;
            txtPhone.DataBindings.Add("Text", dtCustomer, "Phone");
            txtCustomerName.DataBindings.Add("Text", dtCustomer, "CustomerName");
            txtEmail.DataBindings.Add("Text", dtCustomer, "Email");
            txtAddress.DataBindings.Add("Text", dtCustomer, "Address");
        }

        private void dgvCustomer_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                databindings_clear_Customer();
                showTextBox_Customer();
                btnAddCus.Enabled = false;
                btnUpdateCus.Enabled = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnUpdateCus_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchCar_TextChanged(object sender, EventArgs e)
        {
            databindings_clear_Car();
            DataView dv = dtCar.DefaultView;
            string filter = "Name like '%" + txtSearchCar.Text + "%'";
            dv.RowFilter = filter;
        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            databindings_clear_Customer();
            DataView dv = dtCustomer.DefaultView;
            string filter = "CustomerName like '%" + txtSearchCustomer.Text + "%'";
            dv.RowFilter = filter;
        }

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            InsertInvoice form = new InsertInvoice(lbID.Text, dgvManageInvoice);
            form.Show();
        }

        private void setCombobox()
        {
            cbSale.Items.Add("Not sold yet");
            cbSale.Items.Add("Sold");
            cbSale.SelectedIndex = 0;
        }

        private void cbSale_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSale.GetItemText(cbSale.SelectedItem).Equals("Not sold yet"))
            {
                loadData(false);
                openFile.FileName = "";
                pictureBoxCar.Image = null;
                filePath = "";
                refress();
                btnAdd.Enabled = true;
                btnRefresh.Enabled = true;
            }
            else
            {
                loadData(true);
                openFile.FileName = "";
                pictureBoxCar.Image = null;
                filePath = "";
                refress();
                btnAdd.Enabled = false;
                btnChooseImage.Enabled = false;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                btnRefresh.Enabled = false;
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///

        private void dgvManageInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvManageInvoice.RowCount == 0)
                {
                    return;
                }
                else
                {
                    DataGridViewRow row = dgvManageInvoice.Rows[e.RowIndex];
                    InvoiceDTO dto = new InvoiceDTO()
                    {
                        invoiceID = row.Cells[0].Value.ToString(),
                        carID = row.Cells[1].Value.ToString(),
                        phone = row.Cells[2].Value.ToString(),
                        dateSell = row.Cells[3].Value.ToString(),
                        id = row.Cells[4].Value.ToString(),
                    };
                    string[] obj = getInfoInvoice(dto);
                    if (obj != null)
                    {
                        lbInvoiceID.Text = dto.invoiceID;
                        lbCusName.Text = obj[4];
                        lbPhone.Text = dto.phone;
                        lbAddress.Text = obj[6];
                        lbEmail.Text = obj[5];
                        lbCarID.Text = dto.carID;
                        lbCarName.Text = obj[0];
                        lbCarType.Text = obj[1];
                        lbBrand.Text = obj[2];
                        lbPrice.Text = obj[3].ToString();
                        lbEmpID.Text = dto.id;
                        lbEmpName.Text = obj[7];
                        lbDate.Text = dto.dateSell;
                    }
                }
            }
            catch (Exception)
            {

                return;
            }
        }

        private string[] getInfoInvoice(InvoiceDTO dto)
        {
            string[] obj = null;
            try
            {
                obj = daoInv.getInvoiceInfo(dto);
            }
            catch (Exception)
            {
                throw;
            }
            return obj;
        }

        private void txtSearchInvoice_TextChanged(object sender, EventArgs e)
        {
            invoiceEmpty();
            DataView dv = dtInvoice.DefaultView;
            string filter = "invoiceID like '%" + txtSearchInvoice.Text + "%'";
            dv.RowFilter = filter;
        }


        private void invoiceEmpty()
        {
            lbInvoiceID.Text = "";
            lbCusName.Text = "";
            lbPhone.Text = "";
            lbAddress.Text = "";
            lbEmail.Text = "";
            lbCarID.Text = "";
            lbCarName.Text = "";
            lbCarType.Text = "";
            lbBrand.Text = "";
            lbPrice.Text = "";
            lbEmpID.Text = "";
            lbEmpName.Text = "";
            lbDate.Text = "";
        }

        private void btnRefressInvoice_Click(object sender, EventArgs e)
        {
            invoiceEmpty();
        }
        //Car

    }
}
