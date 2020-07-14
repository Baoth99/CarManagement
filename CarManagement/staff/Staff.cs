﻿using Data.daos;
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
        DataTable dtCar;
        DataTable dtCustomer;
        string filePath = "";
        public Staff()
        {
            InitializeComponent();
            data = new LoginSuccessfull(ReceiveData);
            loadData();
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

        private void loadData()
        {
            dgvCar.DataSource = null;
            dtCar = dao.getCarList();
            dgvCar.DataSource = dtCar;
            dgvCar.Columns["ImagesName"].Visible = false;
            dgvCar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtCustomer = daoCus.getCustomerList();
            dgvCustomer.DataSource = dtCustomer;
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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
                        loadData();
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
            //refesh text customer
            txtPhone.Enabled = true;
            txtPhone.Text = "";
            txtCustomerName.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";

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
        //Car

    }
}
