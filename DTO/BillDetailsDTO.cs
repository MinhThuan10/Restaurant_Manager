using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.DTO
{
    internal class BillDetailsDTO
    {
        public int ProductID {  get; set; }
        public int BillID { get; set; }
        public int Quantity { get; set; }

        public BillDetailsDTO(int ProductID, int BillID, int Quantity)
        {
            this.ProductID = ProductID;
            this.BillID = BillID;
            this.Quantity = Quantity;
        }
    }
}
