using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantManager.DTO;

namespace RestaurantManager.DAO
{
    internal class EmployeeDAO
    {
        private string query;
        
        public int Insert(EmployeeDTO Employee, ref string ErrMsg)
        {
            query = "EXEC PROC_ThemNhanVien @HoNV , @TenNV , @NgaySinh , @GioiTinh , @DiaChi , @SDT , @NgayTD , @MaNQL , @TenCV , @TenDangNhap , @MatKhau";
            // vì DTO của nhân viên chứa mã cv nên là sẽ từ mã cv đó get cái tên công việc, bằng cách truy vấn
            DataTable DT = DataProvider.ExecuteQuery("SELECT * FROM CongViec Where MaCV = " + Employee.JobID.ToString(), ref ErrMsg);
            string JobName = DT.Rows[0].ItemArray[1].ToString();
            return DataProvider.ExecuteNonQuery(query, ref ErrMsg, new object[]
            {
                Employee.LastName, Employee.FirstName, Employee.BirthDate, Employee.Gender, 
                Employee.Address, Employee.PhoneNumber, Employee.StartingDate, 1 , JobName , Employee.Username, Employee.Password
            });
        }
        public int Update(EmployeeDTO Employee, ref string ErrMsg)
        {
            query = "EXEC PROC_SuaNhanVien @MaNV , @HoNV , @TenNV , @NgaySinh , @GioiTinh , @DiaChi , @SDT , @NgayTD , @MaNQL , @TenCV ";
            // vì DTO của nhân viên chứa mã cv nên là sẽ từ mã cv đó get cái tên công việc, bằng cách truy vấn
            DataTable DT = DataProvider.ExecuteQuery("SELECT * FROM CongViec Where MaCV = " + Employee.JobID.ToString(), ref ErrMsg);
            string JobName = DT.Rows[0].ItemArray[1].ToString();
            return DataProvider.ExecuteNonQuery(query, ref ErrMsg, new object[]
            {
                Employee.ID, Employee.LastName, Employee.FirstName, Employee.BirthDate, Employee.Gender, 
                Employee.Address, Employee.PhoneNumber, Employee.StartingDate, 1, JobName
            });
        }
        public int Delete(int EmployeeID, ref string ErrMsg)
        {
            query = "EXEC PROC_XoaNhanVien @MaNV";
            return DataProvider.ExecuteNonQuery(query, ref ErrMsg, new object[]{ EmployeeID });
        }

        public EmployeeDTO GetOne(int EmployeeID, ref string ErrMsg)
        {
            query = "SELECT * FROM NhanVien WHERE MaNV = @MaNV";
            DataTable DT = DataProvider.ExecuteQuery(query, ref ErrMsg, new object[] { EmployeeID });
            return new EmployeeDTO(EmployeeID,
               DT.Rows[0].ItemArray[1].ToString(),
               DT.Rows[0].ItemArray[2].ToString(),
               DT.Rows[0].ItemArray[5].ToString(),
               Convert.ToDateTime(DT.Rows[0].ItemArray[3].ToString()),
               DT.Rows[0].ItemArray[4].ToString(),
               DT.Rows[0].ItemArray[6].ToString(),
               Convert.ToDateTime(DT.Rows[0].ItemArray[7].ToString()),
               int.Parse(DT.Rows[0].ItemArray[9].ToString()), "", ""
               );
        }
        public DataTable GetAll(ref string ErrMsg)
        {
            query = "SELECT * FROM V_ThongTinNhanVien";
            return DataProvider.ExecuteQuery(query, ref ErrMsg);
        }

        public DataTable SearchByName(string Name, ref string ErrMsg) 
        {
            query = "SELECT * FROM FUNC_TimKiemNhanVien( @TenNV )";
            return DataProvider.ExecuteQuery(query, ref ErrMsg, new object[] { Name });
        }
    }
}
