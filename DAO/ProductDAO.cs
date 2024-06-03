using RestaurantManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.DAO
{
    internal class ProductDAO
    {
        string query;
        public int Insert(ProductDTO Product, ref string ErrMsg)
        {
            query = "EXEC PROC_ThemSanPham @TenSP , @DonGia ";
            return DataProvider.ExecuteNonQuery(query, ref ErrMsg, new object[]
            {
                Product.Name, Product.Price
            });
        }
        public int Update(ProductDTO Product, ref string ErrMsg)
        {
            query = "EXEC PROC_SuaThongTinSanPham @MaSP , @TenSP , @DonGia";
            return DataProvider.ExecuteNonQuery(query, ref ErrMsg, new object[]
            {
                Product.ID, Product.Name, Product.Price
            });
        }
        public int Delete(int ProductID, ref string ErrMsg)
        {
            query = "EXEC PROC_XoaSanPham";
            return DataProvider.ExecuteNonQuery(query, ref ErrMsg, new object[] { ProductID });
        }

        public DataTable GetAll(ref string ErrMsg)
        {
            query = "SELECT * FROM SanPham";
            return DataProvider.ExecuteQuery(query, ref ErrMsg);
        }
    }
}
