using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.DTO
{
    internal class ShiftDTO
    {
        public ShiftDTO() { }
        public int ID { get; set; }
        public DateTime Start {  get; set; }
        public DateTime End { get; set; }
    }
}
