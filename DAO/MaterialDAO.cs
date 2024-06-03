using RestaurantManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.DAO
{
    internal class MaterialDAO
    {
        string query;
        public int Insert(MaterialDTO materialDTO, ref string ErrMsg)
        {
            query = "EXEC PROC_ThemNguyenLieuMoi @TenNL , @DonViTinh , @SoLuong , @MaNVQL , @SLTonKho";
            return DataProvider.ExecuteNonQuery(query, ref ErrMsg, new object[] {
                materialDTO.Name, materialDTO.Unit, materialDTO.Quantity, materialDTO.ManagerID, materialDTO.QuantityLimit
            });
        }
        public int Update(MaterialDTO materialDTO, ref string ErrMsg)
        {
            query = "EXEC PROC_SuaThongTinNL @MaNL , @TenNL , @DonViTinh , @SoLuong , @MaNVQL , @SLTonKho";
            return DataProvider.ExecuteNonQuery(query, ref ErrMsg, new object[] {
                materialDTO.ID , materialDTO.Name, materialDTO.Unit, materialDTO.Quantity, materialDTO.ManagerID, materialDTO.QuantityLimit
            });
        }
        public int Delete(int MaterialID, ref string ErrMsg)
        {
            this.query = "EXEC PROC_XoaNL @MaNL";
            return DataProvider.ExecuteNonQuery(query, ref ErrMsg, new object[] { MaterialID });
        }
        public DataTable GetAll(ref string ErrMsg)
        {
            query = "SELECT * FROM NguyenLieu";
            return DataProvider.ExecuteQuery(query, ref ErrMsg);
        }
        public MaterialDTO GetOne(int MaterialID, ref string ErrMsg)
        {
            query = "SELECT * FROM NguyenLieu where MaNL = @MaNL";
            DataTable DT = DataProvider.ExecuteQuery(query, ref ErrMsg, new object[] { MaterialID });
            return new MaterialDTO(
                MaterialID,
                DT.Rows[0].ItemArray[1].ToString(),
                DT.Rows[0].ItemArray[2].ToString(),
                int.Parse(DT.Rows[0].ItemArray[3].ToString()),
                int.Parse(DT.Rows[0].ItemArray[4].ToString()),
                int.Parse(DT.Rows[0].ItemArray[5].ToString())
                );
        }
    }
}
