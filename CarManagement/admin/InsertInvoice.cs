using Data.daos;
using Data.dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManagement.admin
{
    public partial class InsertInvoice : Form
    {
        CustomerDAO cusDao = new CustomerDAO();
        InvoiceDAO inDao = new InvoiceDAO();
        CarDAO carDao = new CarDAO();
        CarDTO dto = null;
        string[] getTextBox = null;
        private string _id;
        private DataGridView _table;
        public InsertInvoice()
        {
            InitializeComponent();
        }

        public InsertInvoice(string id, DataGridView table) : this()
        {
            _id = id;
            lbEmpID.Text = _id;
            _table = table;
        }

        private void InsertInvoice_Load(object sender, EventArgs e)
        {
            AutoCompleteCustomer();
            AutoCompleteCar();
        }

        private void AutoCompleteCustomer()
        {
            AutoCompleteStringCollection coll = cusDao.getCutomerName();
            txtCustomer.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtCustomer.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtCustomer.AutoCompleteCustomSource = coll;
        }

        private void AutoCompleteCar()
        {
            AutoCompleteStringCollection coll = carDao.getCar();
            txtCarID.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtCarID.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtCarID.AutoCompleteCustomSource = coll;
        }

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            if (checkInfo())
            {
                    try
                    {
                        InvoiceDTO invoiceDTO = new InvoiceDTO()
                        {
                            carID = lbCarID.Text,
                            phone = lbCusPhone.Text,
                            id = _id

                        };
                        if (inDao.addNewInvoice(invoiceDTO))
                        {
                            MessageBox.Show("Invoice was created successfully !", "Successful");
                            if (carDao.updateSaleCar(lbCarID.Text))
                            {
                            _table.DataSource = null;
                            DataTable dtInvoice = inDao.getInvoiceList();
                            _table.DataSource = dtInvoice;
                            _table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Unsuccessfully !", "UnSuccessful");
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
            }
            
        }

        private void txtCustomer_TextChanged(object sender, EventArgs e)
        {
            getCustomerInfo();
        }

        public void getCustomerInfo()
        {
            try
            {
                if (txtCustomer.Text != "")
                {
                    getTextBox = txtCustomer.Text.Split('-');
                    if (getTextBox[0] != "")
                    {
                        CustomerDTO dto = cusDao.getCustomerByPhone(getTextBox[0]);
                        if (dto != null)
                        {
                            lbCusPhone.Text = dto.phone;
                            lnCusName.Text = dto.customerName;
                            lbEmail.Text = dto.email;
                            lbAddress.Text = dto.address;
                            getTextBox = null;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void getCarInfo()
        {
            try
            {
                if (txtCarID.Text != "")
                {
                    getTextBox = txtCarID.Text.Split('-');
                    if (getTextBox[0] != "")
                    {
                        dto = carDao.getCarByID(getTextBox[0]);
                        if (dto != null)
                        {
                            lbCarID.Text = dto.carID;
                            lbCarName.Text = dto.name;
                            lbType.Text = dto.type;
                            lbBrand.Text = dto.brand;
                            lbModel.Text = dto.model;
                            lbPrice.Text = dto.price.ToString();
                            getTextBox = null;
                        }
                    }

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void txtCarName_TextChanged(object sender, EventArgs e)
        {
            getCarInfo();
        }

        private bool checkInfo()
        {
            if (lbCusPhone.Text.Equals("..."))
            {
                MessageBox.Show("Please choose Customer !", "Error");
                return false;
            }
            if (lbCarID.Text.Equals("..."))
            {
                MessageBox.Show("Please choose Car !", "Error");
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
