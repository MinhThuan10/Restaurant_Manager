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
    public partial class UpdateEmployeesSubForm : Form
    {
        public UpdateEmployeesSubForm()
        {
            InitializeComponent();
        }
        string ErrMsg = null;
        EmployeeDAO Employee_DAO = new EmployeeDAO();
        EmployeeDTO Employee_DTO;

        public void FillTheInfoTextbox(int EmployeeID)
        {

            Employee_DTO = Employee_DAO.GetOne(EmployeeID, ref ErrMsg);
            ShowMessage.CheckAndShowErr(ref ErrMsg);

            EmpLastNameTextbox.Text = Employee_DTO.LastName;
            EmpFirstNameTextbox.Text = Employee_DTO.FirstName;
            BirthDateTimePicker.Value = Employee_DTO.BirthDate;
            GenderCB.Text = Employee_DTO.Gender;
            PhoneNumberTextbox.Text = Employee_DTO.PhoneNumber;
            AddressTextbox.Text = Employee_DTO.Address;
            StartingDateTimePicker.Value = Employee_DTO.StartingDate;

            DataTable JobsDT = DataProvider.ExecuteQuery("SELECT * FROM CongViec", ref ErrMsg);
            foreach (DataRow row in JobsDT.Rows)
            {
                JobTitlesCB.Items.Add(row[1]);
            }
            JobTitlesCB.Text = JobsDT.Rows[Employee_DTO.JobID - 1].ToString();
            JobTitlesCB.Text = "chọn cv";
        }

        private void UpdateEmployeesSubForm_Load(object sender, EventArgs e)
        {

        }

        private void UpdateEmployeeBtn_Click(object sender, EventArgs e)
        {
            Employee_DAO.Update(new EmployeeDTO(
                Employee_DTO.ID,
                EmpLastNameTextbox.Text,
                EmpFirstNameTextbox.Text,
                AddressTextbox.Text,
                BirthDateTimePicker.Value,
                GenderCB.Text,
                PhoneNumberTextbox.Text,
                StartingDateTimePicker.Value,
                JobTitlesCB.SelectedIndex + 1, "", ""
               ), ref ErrMsg);
            if (ShowMessage.CheckAndShowErr(ref ErrMsg)) { MessageBox.Show("Cập nhật nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
    }
}
