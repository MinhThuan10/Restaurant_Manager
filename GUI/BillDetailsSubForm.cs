using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManager.DAO
{
    public partial class BillDetailsSubForm : Form
    {
        public BillDetailsSubForm()
        {
            InitializeComponent();
        }
        string ErrMsg = null;
        BillDetailsDAO BillDetails_DAO = new BillDetailsDAO();

        private void BillDetailsSubForm_Load(object sender, EventArgs e)
        {

        }
        public void FillTheInfo(int BillID)
        {
            BillDetailsDG.DataSource = BillDetails_DAO.GetAllByBillID(BillID, ref ErrMsg);
            ShowMessage.CheckAndShowErr(ref ErrMsg);
            TotalTextbox.Text = DataProvider.ExecuteQuery("SELECT TriGiaHD FROM HoaDon where MaHD = " + BillID.ToString(), ref ErrMsg).Rows[0].ItemArray[0].ToString();
            ShowMessage.CheckAndShowErr(ref ErrMsg);
        }

        private void BillDetailsDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
