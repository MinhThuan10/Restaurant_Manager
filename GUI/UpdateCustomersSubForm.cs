using RestaurantManager.DAO;
using RestaurantManager.DTO;
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
    public partial class UpdateCustomersSubForm : Form
    {
        public UpdateCustomersSubForm()
        {
            InitializeComponent();
        }
        string ErrMsg = null;
        CustomerDAO Customer_DAO = new CustomerDAO();
        CustomerDTO Customer_DTO;
        private void UpdateCustomersSubForm_Load(object sender, EventArgs e)
        {

        }
        public void FillTheInfoTextbox(int CustomerID)
        {

            Customer_DTO = Customer_DAO.GetOne(CustomerID, ref ErrMsg);
            ShowMessage.CheckAndShowErr(ref ErrMsg);

            CustomerNameTextbox.Text = Customer_DTO.Name;
            PhoneNumberTextbox.Text = Customer_DTO.PhoneNumber;
            AddressTextbox.Text = Customer_DTO.Address;
            GenderCB.Text = Customer_DTO.Gender;
        }

        private void UpdateCustomerBtn_Click(object sender, EventArgs e)
        {
            Customer_DAO.Update(new CustomerDTO(
                Customer_DTO.ID,
                CustomerNameTextbox.Text,
                PhoneNumberTextbox.Text,
                AddressTextbox.Text,
                GenderCB.Text,
                Customer_DTO.Points
                ), ref ErrMsg);
            if (ShowMessage.CheckAndShowErr(ref ErrMsg)) { MessageBox.Show("Cập nhật khách hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
    }
}
