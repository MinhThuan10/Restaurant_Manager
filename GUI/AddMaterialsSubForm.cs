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
    public partial class AddMaterialsSubForm : Form
    {
        public AddMaterialsSubForm()
        {
            InitializeComponent();
        }
        MaterialDAO Material_DAO = new MaterialDAO();
        string ErrMsg = null;
        private void AddMaterialBtn_Click(object sender, EventArgs e)
        {
            Material_DAO.Insert(new DTO.MaterialDTO(
                0,
                NameTextbox.Text,
                UnitTextbox.Text,
                int.Parse(QuantityTextbox.Text),
                int.Parse(EmployeeIDTextbox.Text),
                int.Parse(QuantityLimitTextbox.Text))
                , ref ErrMsg);
                if (ShowMessage.CheckAndShowErr(ref ErrMsg)) { MessageBox.Show("Thêm nguyên liệu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
    }
}
