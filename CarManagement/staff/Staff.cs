using Data.dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManagement.staff
{
    public partial class Staff : Form
    {
        public delegate void LoginSuccessfull(EmployeeDTO dto);
        public LoginSuccessfull data;
        public Staff()
        {
            InitializeComponent();
            data = new LoginSuccessfull(ReceiveData);
        }
        private void ReceiveData(EmployeeDTO dto)
        {
            lbName.Text = dto.id;
        }
    }
}
