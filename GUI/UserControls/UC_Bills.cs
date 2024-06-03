using RestaurantManager.DAO;
using RestaurantManager.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManager.GUI.UserControls
{
    public partial class UC_Bills : UserControl
    {
        public UC_Bills()
        {
            InitializeComponent();
        }
        string ErrMsg = null;
        BillDAO Bill_DAO = new BillDAO();
        BillDTO Bill_DTO;
        public SetParameterValueDelegate SetParameterValueCallback;


        private int GetTheSelectedBillID()
        {
            int selectedRowIndex = BillsDG.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = BillsDG.Rows[selectedRowIndex];
            return Convert.ToInt16(selectedRow.Cells[0].Value);
        }
        private void UC_Bills_Load(object sender, EventArgs e)
        {
            BillsDG.DataSource = Bill_DAO.GetAll(ref ErrMsg);
            TimeUnitCB.Text = "--Chọn--";
        }

        private void TableSetBtn_Click(object sender, EventArgs e)
        {
            AddBillsSubForm addBillsSubForm = new AddBillsSubForm();
            addBillsSubForm.ShowDialog();
            UC_Bills_Load(sender, e);
        }

        private void BillDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void PayBtn_Click(object sender, EventArgs e)
        {
            // get the BillID
            int selectedBillID = GetTheSelectedBillID();

            // get the Bill by the ID
            Bill_DTO = Bill_DAO.GetOne(selectedBillID, ref ErrMsg);
            Bill_DTO.State = "Hoàn thành";
            

            Bill_DAO.Update(Bill_DTO, ref ErrMsg);
            
            if (ShowMessage.CheckAndShowErr(ref ErrMsg)) { MessageBox.Show("Thanh toán hoá đơn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            UC_Bills_Load(sender, e);
        }

        private void BillsDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PayBtn.Enabled = true;
            DeleteBillBtn.Enabled = true;
            BillDetailsBtn.Enabled = true;
        }

        private void FilterBtn_Click(object sender, EventArgs e)
        {
            if(TimeUnitCB.Text == "Ngày")
            {
                BillsDG.DataSource = Bill_DAO.GetAllForDay(BillDateTimePicker.Value, ref ErrMsg);
                ShowMessage.CheckAndShowErr(ref ErrMsg);
            }
            else if(TimeUnitCB.Text == "Tháng")
            {
                BillsDG.DataSource = Bill_DAO.GetAllForMonth(BillDateTimePicker.Value, ref ErrMsg);
                ShowMessage.CheckAndShowErr(ref ErrMsg);
            }
            else if(TimeUnitCB.Text == "Năm") 
            {
                BillsDG.DataSource = Bill_DAO.GetAllForYear(BillDateTimePicker.Value, ref ErrMsg);
                ShowMessage.CheckAndShowErr(ref ErrMsg);
            }
            else
            {
                UC_Bills_Load(sender, e);
            }
        }

        private void BillDetailsBtn_Click(object sender, EventArgs e)
        {
            // get the BillID
            int selectedBillID = GetTheSelectedBillID();

            BillDetailsSubForm billDetailsSubForm = new BillDetailsSubForm();
            SetParameterValueCallback += new SetParameterValueDelegate(billDetailsSubForm.FillTheInfo);
            SetParameterValueCallback(selectedBillID);
            billDetailsSubForm.ShowDialog();
        }

        private void DeleteBillBtn_Click(object sender, EventArgs e)
        {
            // get the BillID
            int selectedBillID = GetTheSelectedBillID();
            
            // delete the bill
            Bill_DAO.Delete(selectedBillID, ref ErrMsg);

            if (ShowMessage.CheckAndShowErr(ref ErrMsg)) { MessageBox.Show("Xoá hoá đơn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            UC_Bills_Load(sender, e);
        }
    }
}
