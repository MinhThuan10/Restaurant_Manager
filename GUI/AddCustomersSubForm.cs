using RestaurantManager.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManager.GUI
{
    public partial class AddCustomersSubForm : Form
    {
        public AddCustomersSubForm()
        {
            InitializeComponent();
        }
        CustomerDAO Customer_DAO = new CustomerDAO();
        string Msg = null;
        private void AddCustomersSubForm_Load(object sender, EventArgs e)
        {
           
        }

        private void AddCustomerBtn_Click(object sender, EventArgs e)
        {
            Customer_DAO.Insert( new DTO.CustomerDTO(
                0,
                CustomerNameTextbox.Text,
                PhoneNumberTextbox.Text,
                AddressTextbox.Text,
                GenderCB.Text,
                0
                ), ref Msg);
                
            if(ShowMessage.CheckAndShowErr(ref Msg)) { MessageBox.Show("Thêm khách hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
    }
}
