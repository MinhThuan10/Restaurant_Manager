using RestaurantManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.DAO
{
    internal class MaterialPurchaseDAO
    {
        string query;

        public DataTable GetAll(ref string ErrMsg)
        {
            query = "SELECT * FROM DonNhapTP";
            return DataProvider.ExecuteQuery(query, ref ErrMsg);
        }
        public DataTable GetAllForDay(DateTime Date, ref string ErrMsg)
        {
            query = "SELECT * FROM FUNC_TimKiemDonNhapTPTheoNgayThangNam('" + Date.Date.ToString("yyyy-MM-dd HH:mm:ss.fff") + "')";
            return DataProvider.ExecuteQuery(query, ref ErrMsg);
        }
        public DataTable GetAllForMonth(DateTime Date, ref string ErrMsg)
        {
            query = "SELECT * FROM FUNC_TimKiemDonNhapTPTheoThangNam('" + Date.Date.ToString("yyyy-MM-dd HH:mm:ss.fff") + "')";
            return DataProvider.ExecuteQuery(query, ref ErrMsg);
        }
        public DataTable GetAllForYear(DateTime Date, ref string ErrMsg)
        {
            query = "SELECT * FROM FUNC_TimKiemDonNhapTPTheoNam('" + Date.Date.ToString("yyyy-MM-dd HH:mm:ss.fff") + "')";
            return DataProvider.ExecuteQuery(query, ref ErrMsg);
        }

        public int Insert(MaterialPurchaseDTO MP, ref string ErrMsg)
        {
            query = "EXEC PROC_ThemDonNhap @MaNV";
            return DataProvider.ExecuteNonQuery(query, ref ErrMsg, new object[] { MP.EmployeeID }) ;
        }
        public int Update(MaterialPurchaseDTO MP, ref string ErrMsg)
        {
            query = "EXEC PROC_SuaDonNhap @MaDon , @GiaTienNhap";
            return DataProvider.ExecuteNonQuery(query, ref ErrMsg, new object[] { MP.ID, MP.Total });
        }
        public int Delete(int MP_ID, ref string ErrMsg)
        {
            query = "EXEC PROC_XoaDonNhap @MaDon";
            return DataProvider.ExecuteNonQuery(query, ref ErrMsg, new object[] { MP_ID });
        }
    }
}
