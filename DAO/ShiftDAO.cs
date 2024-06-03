using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.DAO
{
    internal class ShiftDAO
    {
        string query;
        // Insert, update, delete

        // Hiển thị danh mục ca làm việc
        public DataTable GetAll(ref string ErrMsg)
        {
            query = "SELECT * FROM CaLamViec";
            return DataProvider.ExecuteQuery(query, ref ErrMsg);
        }
    }
}
