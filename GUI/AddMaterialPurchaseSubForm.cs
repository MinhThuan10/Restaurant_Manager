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
    public partial class AddMaterialPurchaseSubForm : Form
    {
        public AddMaterialPurchaseSubForm()
        {
            InitializeComponent();
        }
        string ErrMsg = null;
        ProviderDAO Provider_DAO = new ProviderDAO();
        MaterialPurchaseDAO MaterialPurchase_DAO = new MaterialPurchaseDAO();
        DataTable MaterialsDT;

        private void UpdateTotalTextbox()
        {
            TotalTextbox.Text = (int.Parse(TotalTextbox.Text) + int.Parse(QuantityTextbox.Text) * int.Parse(MaterialsCB.Text.Substring(MaterialsCB.Text.IndexOf(":") + 1))).ToString();
        }
        private void AddMaterialPurchaseSubForm_Load(object sender, EventArgs e)
        {
            // load provider combobox
            DataTable ProviderDT = Provider_DAO.GetAll(ref ErrMsg);
            foreach(DataRow Row in ProviderDT.Rows)
            {
                ProvidersCB.Items.Add(Row[1]);
            }
        }

        private void ProvidersCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ProviderID = ProvidersCB.SelectedIndex + 1;
            MaterialsDT = DataProvider.ExecuteQuery("SELECT NL.TenNL, CTL.GiaTienNL FROM NguyenLieu NL JOIN CTNgLieu CTL ON NL.MaNL = CTL.MaNL WHERE CTL.MaNCC = " + ProviderID.ToString(), ref ErrMsg);
            foreach (DataRow Row in MaterialsDT.Rows)
            {
                MaterialsCB.Items.Add(Row[0].ToString() + ";    Đơn giá:" + Row[1].ToString());
            }
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            if(MaterialsCB.Text != "")
            {
                UpdateTotalTextbox();
                // add to dg
                string NameOfMaterials = MaterialsCB.Text.Substring(0, MaterialsCB.Text.IndexOf(";"));
                string Price = MaterialsCB.Text.Substring(MaterialsCB.Text.IndexOf(":") + 1);
                string Quantity = QuantityTextbox.Text;
                string Value = (int.Parse(QuantityTextbox.Text) * int.Parse(MaterialsCB.Text.Substring(MaterialsCB.Text.IndexOf(":") + 1))).ToString();

                DataGridViewRow dataRow = (DataGridViewRow)MaterialsDG.Rows[0].Clone();
                dataRow.Cells[0].Value = NameOfMaterials;
                dataRow.Cells[1].Value = Price;
                dataRow.Cells[2].Value = Quantity;
                dataRow.Cells[3].Value = Value;

                MaterialsDG.Rows.Add(dataRow);
            }
        }

        private void AddBillBtn_Click(object sender, EventArgs e)
        {
            MaterialPurchase_DAO.Insert(new MaterialPurchaseDTO(0, DateTime.Now, 0, 1), ref ErrMsg);
            ShowMessage.CheckAndShowErr(ref ErrMsg);

            string NameOfMaterial;
            int Quantity;
            for (int i = 0; i < MaterialsDG.Rows.Count - 1; i++)
            {
                Quantity = int.Parse(MaterialsDG.Rows[i].Cells[2].Value.ToString());
                NameOfMaterial = MaterialsDG.Rows[i].Cells[0].Value.ToString();
                DataProvider.ExecuteNonQuery("EXEC PROC_ThemCTDonNhap @TenNL , @SoLuong", ref ErrMsg, new object[] { NameOfMaterial, Quantity });
                ShowMessage.CheckAndShowErr(ref ErrMsg);
            }

            MaterialPurchase_DAO.Update(new MaterialPurchaseDTO(DataProvider.NextID("DonNhapTP"), DateTime.Now, 
                int.Parse(TotalTextbox.Text), 1), ref ErrMsg);
            if (ShowMessage.CheckAndShowErr(ref ErrMsg)) { MessageBox.Show("Thêm đơn nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
    }
}
