using RestaurantManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManager.DAO
{
    internal class BillDAO
    {
        string query;
        public int Insert(BillDTO Bill, ref string ErrMsg)
        {
            query = "EXEC PROC_ThemHoaDon @MaKH , @MaNV , @MaBan"; 
            return DataProvider.ExecuteNonQuery(query, ref ErrMsg, new object[] {
                Bill.CustomerID, Bill.EmployeeID, Bill.TableID
            });
        }

        public int Update(BillDTO Bill, ref string ErrMsg)
        {
            query = "EXEC PROC_SuaHoaDon @MaHD , @TrangThai , @TriGiaHD";
            return DataProvider.ExecuteNonQuery(query, ref ErrMsg, new object[] {
                Bill.ID, Bill.State, Bill.Value
            });
        }

        public int Delete(int BillID, ref string ErrMsg)
        {
            query = "EXEC PROC_XoaHoaDon @MaHD";
            return DataProvider.ExecuteNonQuery(query, ref ErrMsg, new object[] {BillID});
        }

        public BillDTO GetOne(int BillID, ref string ErrMsg)
        {
            query = "SELECT * FROM HoaDon Where MaHD = @MaHD";
            DataTable DT = DataProvider.ExecuteQuery(query, ref ErrMsg, new object[] { BillID });
            return new BillDTO(
                BillID,
                Convert.ToDateTime(DT.Rows[0].ItemArray[1].ToString()),
                DT.Rows[0].ItemArray[2].ToString(),
                float.Parse(DT.Rows[0].ItemArray[3].ToString()),
                int.Parse(DT.Rows[0].ItemArray[4].ToString()),
                int.Parse(DT.Rows[0].ItemArray[5].ToString()),
                int.Parse(DT.Rows[0].ItemArray[6].ToString())
                );
        }

        public DataTable GetAll(ref string ErrMsg) 
        {
            query = "SELECT * FROM HoaDon";
            return DataProvider.ExecuteQuery(query, ref ErrMsg);
        }

        public DataTable GetAllOfCurrentMonth(ref string ErrMsg)
        {
            string Month = DateTime.Now.Month.ToString();
            string Year = DateTime.Now.Year.ToString();

            query = "SELECT * FROM FUNC_HoaDonTheoThangCuaNam(" + Year + ", " + Month + ")";
            return DataProvider.ExecuteQuery(query, ref ErrMsg);
        }
        public DataTable GetAllUnPaidBills(ref string ErrMsg)
        {
            query = "SELECT * FROM V_HoaDonChuaThanhToan";
            return DataProvider.ExecuteQuery(query, ref ErrMsg);
        }
        
        public DataTable GetAllForYear(DateTime Date, ref string ErrMsg)
        {
            query = "SELECT * FROM FUNC_HoaDonTheoNam('" + Date.Date.ToString("yyyy-MM-dd HH:mm:ss.fff") + "')";
            return DataProvider.ExecuteQuery(query, ref ErrMsg);
        }

        public DataTable GetAllForMonth(DateTime Date, ref string ErrMsg)
        {
            query = "SELECT * FROM FUNC_HoaDonTheoThangCuaNam('" + Date.Date.ToString("yyyy-MM-dd HH:mm:ss.fff") + "')";
            return DataProvider.ExecuteQuery(query, ref ErrMsg);
        }
        public DataTable GetAllForDay(DateTime Date, ref string ErrMsg)
        {
            query = "SELECT * FROM FUNC_HoaDonTheoNgayThangNam('" + Date.Date.ToString("yyyy-MM-dd HH:mm:ss.fff") + "')";
            return DataProvider.ExecuteQuery(query, ref ErrMsg);
        }

        public DataTable GetRevenueForYear(DateTime Date, ref string ErrMsg)
        {
            query = "SELECT dbo.[FUNC_TinhDoanhThuTheoNam]('" + Date.Date.ToString("yyyy-MM-dd HH:mm:ss.fff") + "')";
            return DataProvider.ExecuteQuery(query, ref ErrMsg);
        }
        public DataTable GetRevenueForMonth(DateTime Date, ref string ErrMsg)
        {
            query = "SELECT dbo.[FUNC_TinhDoanhThuTheoThang]('" + Date.Date.ToString("yyyy-MM-dd HH:mm:ss.fff") + "')";
            return DataProvider.ExecuteQuery(query, ref ErrMsg);
        }
        public DataTable GetRevenueForDay(DateTime Date, ref string ErrMsg)
        {
            query = "SELECT dbo.[FUNC_TinhDoanhThuTheoNgay]('" + Date.Date.ToString("yyyy-MM-dd HH:mm:ss.fff") + "')";
            return DataProvider.ExecuteQuery(query, ref ErrMsg);
        }
        public DataTable GetExpenseForYear(DateTime Date, ref string ErrMsg)
        {
            query = "SELECT dbo.[FUNC_TinhChiPhiTheoNam]('" + Date.Date.ToString("yyyy-MM-dd HH:mm:ss.fff") + "')";
            return DataProvider.ExecuteQuery(query, ref ErrMsg);
        }
        public DataTable GetExpenseForMonth(DateTime Date, ref string ErrMsg)
        {
            query = "SELECT dbo.[FUNC_TinhChiPhiTheoThang]('" + Date.Date.ToString("yyyy-MM-dd HH:mm:ss.fff") + "')";
            return DataProvider.ExecuteQuery(query, ref ErrMsg);
        }
        public DataTable GetExpenseForDay(DateTime Date, ref string ErrMsg)
        {
            query = "SELECT dbo.[FUNC_TinhChiPhiTheoNgay]('" + Date.Date.ToString("yyyy-MM-dd HH:mm:ss.fff") + "')";
            return DataProvider.ExecuteQuery(query, ref ErrMsg);
        }
    }
}
