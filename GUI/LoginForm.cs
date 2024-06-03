using RestaurantManager.DAO;
using RestaurantManager.GUI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManager.GUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=QLNH;Integrated Security=True"; // Thay thế bằng chuỗi kết nối của bạn
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Kiểm tra username và password trong bảng DangNhap
                string query = "SELECT COUNT(*) FROM DangNhap WHERE TenDangNhap = @Username AND MatKhau = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        // Đăng nhập thành công, kiểm tra MaCV
                        string queryMaCV = "SELECT NV.MaCV FROM NhanVien NV INNER JOIN DangNhap DN ON NV.MaNV = DN.MaNV  WHERE DN.TenDangNhap = @Username";
                        using (SqlCommand cmdMaCV = new SqlCommand(queryMaCV, connection))
                        {
                            cmdMaCV.Parameters.AddWithValue("@Username", username);

                            int maCV = (int)cmdMaCV.ExecuteScalar();

                            if (maCV == 1)
                            {
                                // Đăng nhập thành công và có quyền quản trị
                                MessageBox.Show("Đăng nhập thành công với tư cách là quản lý!");
                                // Chuyển đến form managerForm1
                                ManagerForm1 managerForm = new ManagerForm1();
                                managerForm.Show();
                                this.Hide(); // Ẩn form hiện tại
                            }
                            else
                            {
                                // Đăng nhập thành công, nhưng không có quyền quản trị
                                MessageBox.Show("Đăng nhập thành công với tư cách là nhân viên!");

                                ManagerForm1 employeeForm = new ManagerForm1();
                                employeeForm.Show();
                                this.Hide(); // Ẩn form hiện tại
                            }
                            DataProvider.SetLoggedInUsername(username, password);
                        }
                    }
                    else
                    {
                        // Đăng nhập thất bại
                        MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại username và password!");
                    }
                }
            }
        }
    }
}
