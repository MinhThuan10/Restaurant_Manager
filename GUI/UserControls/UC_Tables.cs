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

namespace RestaurantManager.GUI.UserControls
{
    public partial class UC_Tables : UserControl
    {
        public UC_Tables()
        {
            InitializeComponent();
        }

        private void UC_Tables_Load(object sender, EventArgs e)
        {
            string Msg = "";
            TablesDG.DataSource = DataProvider.ExecuteQuery("SELECT * FROM BanAn", ref Msg);
           
        }

        private void TableSetBtn_Click(object sender, EventArgs e)
        {
            AddBillsSubForm addBillsSubForm = new AddBillsSubForm();
            addBillsSubForm.ShowDialog();
        }

        private void TablesDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ChangeTableBtn.Enabled = true;
            PayInTablesBtn.Enabled = true;
        }
    }
}
