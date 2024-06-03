using RestaurantManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.DAO
{
    internal class BillDetailsDAO
    {
        string query;
        public int Insert(int BillID, string ProductName, int Quantity, ref string ErrMsg)
        {
            query = "EXEC PROC_ThemChiTietHD @MaHD , @TenSP , @SoLuong";
            return DataProvider.ExecuteNonQuery(query, ref ErrMsg, new object[] {
                BillID, ProductName, Quantity
            });
        }
        public DataTable GetAllByBillID(int BillID, ref string  ErrMsg)
        {
            query = "SELECT * FROM FUNC_TimKiemCTHoaDonTheoMaHD( @MaHD )";
            return DataProvider.ExecuteQuery(query, ref ErrMsg, new object[] { BillID });
        }
    }
}
