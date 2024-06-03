using RestaurantManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.DAO
{
    internal class CustomerDAO
    {
        string query;
        public int Insert(CustomerDTO customerDTO, ref string ErrMsg)
        {
            query = "EXEC PROC_ThemKHMoi @TenKH , @SDT , @DiaChi , @GioiTinh";
            return DataProvider.ExecuteNonQuery(query, ref ErrMsg, new object[] {
                customerDTO.Name, customerDTO.PhoneNumber, customerDTO.Address, customerDTO.Gender
            });
        }
        public int Update(CustomerDTO Customer, ref string ErrMsg)
        {
            query = "EXEC PROC_SuaThongTinKH @MaKH , @TenKH , @SDT , @DiaChi , @GioiTinh , @DiemTL";
            return DataProvider.ExecuteNonQuery(query, ref ErrMsg, new object[] {
                Customer.ID, Customer.Name, Customer.PhoneNumber, Customer.Address, Customer.Gender, Customer.Points
            });
        }
        public int Delete(int CustomerID, ref string ErrMsg)
        {
            this.query = "EXEC PROC_XoaKH @MaKH";
            return DataProvider.ExecuteNonQuery(query, ref ErrMsg, new object[] { CustomerID });
        }

        public DataTable GetAll(ref string ErrMsg)
        {
            query = "SELECT * FROM V_KhachHang";
            return DataProvider.ExecuteQuery(query, ref ErrMsg);
        }
        public CustomerDTO GetOne(int CustomerID, ref string ErrMsg)
        {
            query = "SELECT * FROM KhachHang WHERE MaKH = @MaKH";
            DataTable DT = DataProvider.ExecuteQuery(query, ref ErrMsg, new object[] { CustomerID });
            return new CustomerDTO(CustomerID,
               DT.Rows[0].ItemArray[1].ToString(),
               DT.Rows[0].ItemArray[5].ToString(),
               DT.Rows[0].ItemArray[4].ToString(),
               DT.Rows[0].ItemArray[2].ToString(),
               int.Parse(DT.Rows[0].ItemArray[3].ToString())
               );
        }
        // search Customer by Phone number
        public DataTable SearchByPhoneNumber(string PhoneNumber, ref string ErrMsg)
        {
            query = "SELECT * FROM FUNC_TimKHBangSDT( @SDT )";
            return DataProvider.ExecuteQuery(query, ref ErrMsg, new object[] { PhoneNumber });
        }
    }
}