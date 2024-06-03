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
    public partial class AddEmployeesSubForm : Form
    {
        public AddEmployeesSubForm()
        {
            InitializeComponent();
        }
        EmployeeDAO Employee_DAO = new EmployeeDAO();
        private void AddEmployeesSubForm_Load(object sender, EventArgs e)
        {
            string ErrMsg = null;
            DataTable JobsDT = DataProvider.ExecuteQuery("SELECT * FROM CongViec", ref ErrMsg);
            foreach (DataRow row in JobsDT.Rows)
            {
                JobTitlesCB.Items.Add(row[1]);
            }
        }

        private void AddEmployeeBtn_Click(object sender, EventArgs e)
        {
            string Msg = null;
            Employee_DAO.Insert( new EmployeeDTO(
                0,
                EmpLastNameTextbox.Text,
                EmpFirstNameTextbox.Text,
                AddressTextbox.Text,
                BirthDateTimePicker.Value,
                GenderCB.Text,
                PhoneNumberTextbox.Text,
                StartingDateTimePicker.Value,
                JobTitlesCB.SelectedIndex + 1,
                UsernameTextbox.Text,
                PasswordTextbox.Text
                ), ref Msg);
            if (ShowMessage.CheckAndShowErr(ref Msg)) { MessageBox.Show("Thêm nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
    }
}
