using RestaurantManager.DAO;
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
    public partial class UC_SalesMetrics : UserControl
    {
        public UC_SalesMetrics()
        {
            InitializeComponent();
        }
        string ErrMsg = null;
        BillDAO Bill_DAO = new BillDAO();

        private void AddEmployeeBtn_Click(object sender, EventArgs e)
        {
            DataTable DT;
            if(ComboBox1.Text != "" && ComboBox2.Text != "") 
            {
                if(ComboBox1.Text == "Doanh Thu")
                {
                    if(ComboBox2.Text == "Ngày")
                    {
                        DT = Bill_DAO.GetRevenueForDay(DateTimePicker.Value, ref ErrMsg);
                        if(!ShowMessage.CheckAndShowErr(ref ErrMsg))
                        {
                            return;
                        }
                        TotalTextbox.Text = DT.Rows[0].ItemArray[0].ToString();
                    } 
                    else if(ComboBox1.Text == "Tháng")
                    {
                        DT = Bill_DAO.GetRevenueForMonth(DateTimePicker.Value, ref ErrMsg);
                        if (!ShowMessage.CheckAndShowErr(ref ErrMsg))
                        {
                            return;
                        }
                        TotalTextbox.Text = DT.Rows[0].ItemArray[0].ToString();
                    }
                    else if(ComboBox2.Text == "Năm")
                    {
                        DT = Bill_DAO.GetRevenueForYear(DateTimePicker.Value, ref ErrMsg);
                        if (!ShowMessage.CheckAndShowErr(ref ErrMsg))
                        {
                            return;
                        }
                        TotalTextbox.Text = DT.Rows[0].ItemArray[0].ToString();
                    }
                }
                else if(ComboBox1.Text == "Chi Phí")
                {
                    if (ComboBox2.Text == "Ngày")
                    {
                        DT = Bill_DAO.GetExpenseForDay(DateTimePicker.Value, ref ErrMsg);
                        if (!ShowMessage.CheckAndShowErr(ref ErrMsg))
                        {
                            return;
                        }
                        TotalTextbox.Text = DT.Rows[0].ItemArray[0].ToString();
                    }
                    else if (ComboBox1.Text == "Tháng")
                    {
                        DT = Bill_DAO.GetExpenseForMonth(DateTimePicker.Value, ref ErrMsg);
                        if (!ShowMessage.CheckAndShowErr(ref ErrMsg))
                        {
                            return;
                        }
                        TotalTextbox.Text = DT.Rows[0].ItemArray[0].ToString();
                    }
                    else if (ComboBox2.Text == "Năm")
                    {
                        DT = Bill_DAO.GetExpenseForYear(DateTimePicker.Value, ref ErrMsg);
                        if (!ShowMessage.CheckAndShowErr(ref ErrMsg))
                        {
                            return;
                        }
                        TotalTextbox.Text = DT.Rows[0].ItemArray[0].ToString();
                    }
                }
            } 
            else
            {
                MessageBox.Show("Sai đk");
            }
        }
    }
}
