using RestaurantManager.DAO;
using RestaurantManager.GUI.UserControls;
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
    public partial class ManagerForm1 : Form
    {
        public ManagerForm1()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl UC)
        {
            UC.Dock = DockStyle.Fill;
            ContainerPanel.Controls.Clear();
            ContainerPanel.Controls.Add(UC);
            UC.BringToFront();
        }
        private void ManagerForm1_Load(object sender, EventArgs e)
        {
            UC_Tables UC = new UC_Tables();
            addUserControl(UC);
            BillTabBtn.Checked = true;
            
        }

        private void TableTabBtn_Click(object sender, EventArgs e)
        {
            UC_Tables UC = new UC_Tables();
            addUserControl(UC);
        }

        private void BillTabBtn_Click(object sender, EventArgs e)
        {
            UC_Bills UC = new UC_Bills();
            addUserControl(UC);
        }

        private void CustomerTabBtn_Click(object sender, EventArgs e)
        {
            UC_Customers UC = new UC_Customers();
            addUserControl(UC);
        }

        private void EmployeeTabBtn_Click(object sender, EventArgs e)
        {
            UC_Employees UC = new UC_Employees();
            addUserControl(UC);
        }

        private void MaterialPurchaseTabBtn_Click(object sender, EventArgs e)
        {
            UC_MaterialPurchase UC = new UC_MaterialPurchase();
            addUserControl(UC);
        }

        private void ProductTagBtn_Click(object sender, EventArgs e)
        {
           UC_SalesMetrics UC = new UC_SalesMetrics();
            addUserControl(UC);
        }

        private void MaterialTabBtn_Click(object sender, EventArgs e)
        {
            UC_Materials UC = new UC_Materials();
            addUserControl(UC);
        }
    }
}

