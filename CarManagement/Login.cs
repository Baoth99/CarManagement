using CarManagement.admin;
using CarManagement.staff;
using Data.daos;
using Data.dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tool.checkinput;

namespace CarManagement
{
    public partial class Login : Form
    {
        EmployeeDAO dao = new EmployeeDAO();
        EmployeeDTO dto = null;
        public Login()
        {
            InitializeComponent();
        }

        public void AdminForm()
        {
            Admin admin = new Admin();
            admin.data(dto);
            admin.ShowDialog();
        }
        public void StaffForm()
        {
            Staff staff = new Staff();
            staff.data(dto);
            staff.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            if (!Check.getString(userName))
            {
                MessageBox.Show("UserName Field is empty !", "Error Field");
                return;
            }
            if (!Check.getString(password))
            {
                MessageBox.Show("Password Field is empty !", "Error Field");
                return;
            }
            dto = dao.Login(userName, password);
            if (dto != null)
            {
                if (dto.status == true)
                {
                    if (dto.role == true)
                    {
                        this.Hide();
                        AdminForm();
                        this.Close();
                    }
                    else
                    {
                        this.Hide();
                        StaffForm();
                        this.Close();
                    }  
                }
                else
                {
                    MessageBox.Show("This account is not active !", "Error");
                }
            }
            else
            {
                MessageBox.Show("Username or Password is wrong !", "Error");
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
