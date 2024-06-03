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

namespace RestaurantManager.GUI.UserControls
{
    public delegate void SetParameterValueDelegate(int ID);
    public partial class UC_Customers : UserControl
    {
        public UC_Customers()
        {
            InitializeComponent();
        }
        string ErrMsg = null;
        CustomerDAO Customer_DAO = new CustomerDAO();
        public SetParameterValueDelegate SetParameterValueCallback;


        private void UC_Customers_Load(object sender, EventArgs e)
        {
            CustomersDG.DataSource = Customer_DAO.GetAll(ref ErrMsg);
        }

        private void InsertCustomerBtn_Click(object sender, EventArgs e)
        {
            AddCustomersSubForm addCustomersSubForm = new AddCustomersSubForm();
            addCustomersSubForm.ShowDialog();
            UC_Customers_Load(sender, e);
        }

        private void SearchCustomerBtn_Click(object sender, EventArgs e)
        {
            if(PhoneNumberTextbox.Text == "")
            {
                UC_Customers_Load(sender, e);
            }
            else
            {
                CustomersDG.DataSource = Customer_DAO.SearchByPhoneNumber(PhoneNumberTextbox.Text, ref ErrMsg);
                ShowMessage.CheckAndShowErr(ref ErrMsg);
            }

        }

        private void DeleteCustomerBtn_Click(object sender, EventArgs e)
        {
            //get the value of CustomerID
            int selectedRowIndex = CustomersDG.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = CustomersDG.Rows[selectedRowIndex];
            int selectedCustomerID = Convert.ToInt16(selectedRow.Cells[0].Value);

            // confirm box here
            if(ShowMessage.ConfirmationBox("Bạn có chắc chắn muốn xoá khách hàng có mã " + selectedCustomerID.ToString() + "?"))
            {
                Customer_DAO.Delete(selectedCustomerID, ref ErrMsg);

                ShowMessage.CheckAndShowErr(ref ErrMsg);
                if (ErrMsg == null) { MessageBox.Show("Xoá Khách hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information); }

                UC_Customers_Load(sender, e);
            }
        }

        private void CustomersDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DeleteCustomerBtn.Enabled = true;
            UpdateCustomerBtn.Enabled = true;
        }

        private void UpdateCustomerBtn_Click(object sender, EventArgs e)
        {
            //get the value of EmployeeID
            int selectedRowIndex = CustomersDG.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = CustomersDG.Rows[selectedRowIndex];
            int selectedCustomerID = Convert.ToInt16(selectedRow.Cells[0].Value);

            UpdateCustomersSubForm updateCustomersSubform = new UpdateCustomersSubForm();
            SetParameterValueCallback += new SetParameterValueDelegate(updateCustomersSubform.FillTheInfoTextbox);
            SetParameterValueCallback(selectedCustomerID);
            updateCustomersSubform.ShowDialog();
            UC_Customers_Load(sender, e);
        }
    }
}
