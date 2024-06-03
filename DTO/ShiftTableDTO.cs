using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.DTO
{
    internal class ShiftTableDTO
    {
        public ShiftTableDTO() { }
        public string EmployeeID { get; set; }
        public int ShiftID { get; set; }
        public DateTime Time {  get; set; }
    }
}
