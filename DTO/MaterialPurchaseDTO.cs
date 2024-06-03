using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.DTO
{
    internal class MaterialPurchaseDTO
    {
        public MaterialPurchaseDTO(int ID, DateTime Time, float Total, int EmployeeID)
        {
            this.ID = ID;
            this.Time = Time;
            this.Total = Total;
            this.EmployeeID = EmployeeID;
        }
        public int ID { get; set; }
        public DateTime Time {  get; set; }
        public float Total { get; set; }
        public int EmployeeID { get; set; }
    }
}
