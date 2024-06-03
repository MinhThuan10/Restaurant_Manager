using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.DAO
{
    internal class ShiftTableDAO
    {
        string query;
        
        // hiển thị danh mục bảng phân ca   
        public DataTable GetAll(ref string ErrMsg)
        {
            query = "SELECT * FROM PhanCa";
            return DataProvider.ExecuteQuery(query, ref ErrMsg);
        }

    }
}
