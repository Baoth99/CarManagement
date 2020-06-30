using Data.daos;
using Data.dtos;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tool.checkinput;

namespace CarManagement.admin
{
    public partial class Admin : Form
    {
        public delegate void LoginSuccessfull(EmployeeDTO dto);
        public LoginSuccessfull data;
        readonly CarDAO dao = new CarDAO();
        readonly CustomerDAO daoCus = new CustomerDAO();
        DataTable dtCar;
        DataTable dtCustomer;
        string filePath = "";
        public Admin()
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

        //Car
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool check = checkField();
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
                        MessageBox.Show("Successfully insert car with an ID of: " + dto.carID, "Message");
                        string path = Path.Combine(appPath + "\\images\\" + dto.imageName);
                        FileInfo fi = new FileInfo(filePath);
                        fi.CopyTo(path);
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

        private bool checkField()
        {
            if(!Check.getString(txtCarID.Text))
            {
                MessageBox.Show("CarID Field is empty !", "Error");
                txtCarID.Focus();
                return false;
            }
            if (!dao.checkIDDulicate(txtCarID.Text))
            {
                MessageBox.Show("CarID is duplicate !", "Error");
                txtCarID.Focus();
                return false;
            }
            if(!Check.getString(txtName.Text))
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
            if(!Check.getString(txtOrigin.Text))
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
        }//end checkField
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
        }//end Customer check field

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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refress();
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
                /* pictureBoxCar.DataBindings.Clear();
                 int numRow = e.RowIndex;
                 if (numRow < 0)
                 {
                     return;
                 }
                 else
                 {
                     string imageName = dgvCar.Rows[numRow].Cells[9].Value.ToString();
                     showImage(imageName);
                 }*/
                databindings_clear_Car();
                showTextBoxCar();
                string imageName = txtImage.Text;
                showImage(imageName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
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
                    loadData();
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
            bool check = checkField();
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
                    if (dao.updateCar(dto))
                    {
                        MessageBox.Show("Successfully insert car with an ID of: " + dto.carID, "Message");
                        string path = Path.Combine(appPath + "\\images\\" + dto.imageName);
                        FileInfo fi = new FileInfo(filePath);
                        fi.CopyTo(path);
                        filePath = "";
                        loadData();
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
        //Customer
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
                        loadData();
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
        }

        private void btnDeleteCus_Click(object sender, EventArgs e)
        {
            if (!Check.getString(txtPhone.Text))
            {
                MessageBox.Show("Please choose Customer that you want to delete!", "Error");
                txtPhone.Focus();
                return;
            }
            try
            {
                MessageBoxButtons button = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Do you want to delete Customer " + txtPhone.Text + " ? ", "Delete Customer", button);
                if (result.Equals(DialogResult.Yes))
                {
                    string mess = (daoCus.deleteCustomer(txtPhone.Text) == true) ? "Sucessfull !" : "Fail !";
                    MessageBox.Show("Delete Customer " + txtPhone.Text + " is " + mess + " !", "Delete Customer");
                    loadData();
                    refress();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }//end Delete Customer

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
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

       
    }
}
