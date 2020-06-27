﻿using Data.daos;
using Data.dtos;
using Microsoft.Win32.SafeHandles;
using System;
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
        CarDAO dao = new CarDAO();
        DataTable dtCar;
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
            dtCar = dao.getCarList();
            dgvCar.DataSource = dtCar;
            dgvCar.Columns["ImagesName"].Visible = false;
            dgvCar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login();
            this.Close();
        }

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
                        MessageBox.Show("Successfully insert car with an ID of" + dto.carID, "Message");
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

        private bool checkField()
        {
            if(!Check.getString(txtCarID.Text))
            {
                MessageBox.Show("CarID Field is empty !", "Error");
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
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refress();
        }

        private void dgvCar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                pictureBoxCar.DataBindings.Clear();
                int numRow = e.RowIndex;
                string imageName = dgvCar.Rows[numRow].Cells[9].Value.ToString();
                showImage(imageName);
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
