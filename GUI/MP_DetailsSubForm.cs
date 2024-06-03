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
    public partial class MP_DetailsSubForm : Form
    {
        public MP_DetailsSubForm()
        {
            InitializeComponent();
        }
        string ErrMsg = null;
        MaterialPurchaseDAO MaPu_DAO = new MaterialPurchaseDAO();

        public void FillTheInfo(int MP_ID)
        {
            MPDetailsDG.DataSource = DataProvider.ExecuteQuery("SELECT * FROM V_ChiTietDonNhap WHERE MaDon = " + MP_ID.ToString(), ref ErrMsg);
            ShowMessage.CheckAndShowErr(ref ErrMsg);

            TotalTextbox.Text = DataProvider.ExecuteQuery("SELECT GiaTien FROM DonNhapTP where MaDon = " + MP_ID.ToString(), ref ErrMsg).Rows[0].ItemArray[0].ToString();
            ShowMessage.CheckAndShowErr(ref ErrMsg);
        }

        private void MPDetailsDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
