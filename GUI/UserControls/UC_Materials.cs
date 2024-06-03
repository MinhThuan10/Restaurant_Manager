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
    public partial class UC_Materials : UserControl
    {
        public UC_Materials()
        {
            InitializeComponent();
        }
        string ErrMsg = null;
        MaterialDAO Material_DAO = new MaterialDAO();
        public SetParameterValueDelegate SetParameterValueCallback;

        private void UC_Materials_Load(object sender, EventArgs e)
        {
            MaterialsDG.DataSource = Material_DAO.GetAll(ref ErrMsg);
        }

        private void TableSetBtn_Click(object sender, EventArgs e)
        {
            AddMaterialsSubForm addMaterialsSubForm = new AddMaterialsSubForm();
            addMaterialsSubForm.ShowDialog();
            UC_Materials_Load(sender, e);
        }

        private void MaterialsDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DeleteMaterialBtn.Enabled = true;
            UpdateMaterialBtn.Enabled = true;
        }

        private void DeleteMaterialBtn_Click(object sender, EventArgs e)
        {
            //get the value of CustomerID
            int selectedRowIndex = MaterialsDG.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = MaterialsDG.Rows[selectedRowIndex];
            int selectedMaterialID = Convert.ToInt16(selectedRow.Cells[0].Value);
            // confirm box here
            if (ShowMessage.ConfirmationBox("Bạn có chắc chắn muốn xoá nguyên liệu có mã " + selectedMaterialID.ToString() + "?"))
            {
                Material_DAO.Delete(selectedMaterialID, ref ErrMsg);

                ShowMessage.CheckAndShowErr(ref ErrMsg);
                if (ErrMsg == null) { MessageBox.Show("Xoá nguyên liệu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information); }

                UC_Materials_Load(sender, e);
            }
        }

        private void UpdateMaterialBtn_Click(object sender, EventArgs e)
        {
            //get the value of EmployeeID
            int selectedRowIndex = MaterialsDG.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = MaterialsDG.Rows[selectedRowIndex];
            int selectedMaterialID = Convert.ToInt16(selectedRow.Cells[0].Value);

            UpdateMaterialsSubForm updateMaterialsSubForm = new UpdateMaterialsSubForm();
            SetParameterValueCallback += new SetParameterValueDelegate(updateMaterialsSubForm.FillTheInfoTextbox);
            SetParameterValueCallback(selectedMaterialID);
            updateMaterialsSubForm.ShowDialog();
            UC_Materials_Load(sender, e);
        }
    }
}
