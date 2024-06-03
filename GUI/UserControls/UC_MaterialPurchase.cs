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
    public partial class UC_MaterialPurchase : UserControl
    {
        public UC_MaterialPurchase()
        {
            InitializeComponent();
        }
        string ErrMsg = null;
        MaterialPurchaseDAO MaterialPurchase_DAO = new MaterialPurchaseDAO();
        public SetParameterValueDelegate SetParameterValueCallback;


        private int GetTheMP_ID()
        {
            // get the ID
            int selectedRowIndex = MaterialPurchasesDG.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = MaterialPurchasesDG.Rows[selectedRowIndex];
            return Convert.ToInt16(selectedRow.Cells[0].Value);
        }
        private void UC_MaterialPurchase_Load(object sender, EventArgs e)
        {
            MaterialPurchasesDG.DataSource = MaterialPurchase_DAO.GetAll(ref ErrMsg);
        }

        private void DeletePurchaseBtn_Click(object sender, EventArgs e)
        {
            // get the ID
            int MP_ID = GetTheMP_ID();

            MaterialPurchase_DAO.Delete(MP_ID, ref ErrMsg);
            ShowMessage.ConfirmationBox("Bạn có muốn xoá đơn nhập có mã đơn " + MP_ID.ToString() + "?");
            if(ShowMessage.CheckAndShowErr(ref ErrMsg)) { MessageBox.Show("Xoá đơn nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            UC_MaterialPurchase_Load(sender, e);
        }

        private void AddMPBtn_Click(object sender, EventArgs e)
        {
            AddMaterialPurchaseSubForm addMaterialPurchaseSubForm = new AddMaterialPurchaseSubForm();
            addMaterialPurchaseSubForm.ShowDialog();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (TimeUnitCB.Text == "Ngày")
            {
                MaterialPurchasesDG.DataSource = MaterialPurchase_DAO.GetAllForDay(DateTimePicker.Value, ref ErrMsg);
                ShowMessage.CheckAndShowErr(ref ErrMsg);
            }
            else if (TimeUnitCB.Text == "Tháng")
            {
                MaterialPurchasesDG.DataSource = MaterialPurchase_DAO.GetAllForMonth(DateTimePicker.Value, ref ErrMsg);
                ShowMessage.CheckAndShowErr(ref ErrMsg);
            }
            else if (TimeUnitCB.Text == "Năm")
            {
                MaterialPurchasesDG.DataSource = MaterialPurchase_DAO.GetAllForYear(DateTimePicker.Value, ref ErrMsg);
                ShowMessage.CheckAndShowErr(ref ErrMsg);
            }
            else
            {
                UC_MaterialPurchase_Load(sender, e);
            }
        }

        private void MPDetailsBtn_Click(object sender, EventArgs e)
        {
            // get the ID
            int MP_ID = GetTheMP_ID();

            MP_DetailsSubForm MP_Details_SubForm = new MP_DetailsSubForm();
            SetParameterValueCallback += new SetParameterValueDelegate(MP_Details_SubForm.FillTheInfo);
            SetParameterValueCallback(MP_ID);
            MP_Details_SubForm.ShowDialog();
        }

        private void MaterialPurchasesDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MPDetailsBtn.Enabled = true;
            DeleteMPBtn.Enabled = true;
        }
    }
}
