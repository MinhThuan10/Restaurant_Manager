using RestaurantManager.DAO;
using RestaurantManager.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace RestaurantManager.GUI
{
    public partial class AddBillsSubForm : Form
    {
      
        static ProductDAO productDAO = new ProductDAO();
        static BillDAO Bill_DAO = new BillDAO();
        static BillDetailsDAO BillDetails_DAO = new BillDetailsDAO();

        static string ErrMsg = null;
        DataTable ProductsDT = productDAO.GetAll(ref ErrMsg);
        DataTable TablesDT = DataProvider.ExecuteQuery("SELECT * FROM BanAn", ref ErrMsg);

        public AddBillsSubForm()
        {
            InitializeComponent();
        }
        private void UpdateTotal()
        {
            double Total = 0;
            for(int i = 0; i < ProductListDG.Rows.Count - 1; i++)
            {
               Total += int.Parse(ProductListDG.Rows[i].Cells[1].Value.ToString()) * double.Parse(ProductListDG.Rows[i].Cells[2].Value.ToString());
            }
            TotalTextbox.Text = Total.ToString();
        }

        private void AddBillsSubForm_Load(object sender, EventArgs e)
        {
            // load products to combobox
            foreach (DataRow Row in ProductsDT.Rows)
            {
                ProductsCB.Items.Add(Row[1]);
            }
            // load tables to combobox
            foreach (DataRow Row in TablesDT.Rows)
            {
                TablesIDCB.Items.Add(Row[0]);
            }
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            if(ProductsCB.Text.Length == 0)
            {
                return;
            }
            string NameOfProduct = ProductsDT.Rows[ProductsCB.SelectedIndex][1].ToString();
            int Quantity = int.Parse(QuantityTextbox.Text);
            double Price = double.Parse(ProductsDT.Rows[ProductsCB.SelectedIndex][2].ToString());
            
            DataGridViewRow dataRow = (DataGridViewRow)ProductListDG.Rows[0].Clone();
            dataRow.Cells[0].Value = NameOfProduct;
            dataRow.Cells[1].Value = Quantity;
            dataRow.Cells[2].Value = Price;
           
            ProductListDG.Rows.Add(dataRow);
            UpdateTotal();
        }

        private void ProductsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            QuantityTextbox.Text = "1";
        }

        private void AddBillBtn_Click(object sender, EventArgs e)
        {
            if(TotalTextbox.Text == "0")
            {
                return;
            }
            // add Bill to DB

            Bill_DAO.Insert(new BillDTO(0, DateTime.Now, "", 0, 1, 1, 1), ref ErrMsg);
            ShowMessage.CheckAndShowErr(ref ErrMsg);

            // add Billdetail to DB
            int Quantity;
            string ProductName;
            for (int i = 0; i < ProductListDG.Rows.Count - 1; i++)
            {
                Quantity = int.Parse(ProductListDG.Rows[i].Cells[1].Value.ToString());
                ProductName = ProductListDG.Rows[i].Cells[0].Value.ToString();
                BillDetails_DAO.Insert(DataProvider.NextID("HoaDon"), ProductName, Quantity, ref ErrMsg);
                ShowMessage.CheckAndShowErr(ref ErrMsg);
            }
            // update the bills total
                // get the CustomerID from phone number
                // Update the table state
            Bill_DAO.Update(new BillDTO(DataProvider.NextID("HoaDon"), DateTime.Now,"Chưa thanh toán", 
                float.Parse(TotalTextbox.Text.ToString()), 1, 1, int.Parse(TablesIDCB.Text.ToString())),
                ref ErrMsg);
            if (ShowMessage.CheckAndShowErr(ref ErrMsg)) { MessageBox.Show("Thêm hoá đơn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void ProductListDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DeleteBtn.Enabled = true;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            ProductListDG.Rows.RemoveAt(ProductListDG.SelectedRows[0].Index);
            UpdateTotal();
            DeleteBtn.Enabled = false;
        }
    }
}
