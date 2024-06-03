using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.DTO
{
    internal class MaterialDTO
    {
        public MaterialDTO(int ID, string Name, string Unit, int Quantity, int ManagerID, int QuantityLimit) 
        {
            this.ID = ID;
            this.Name = Name;
            this.Unit = Unit;
            this.Quantity = Quantity;
            this.ManagerID = ManagerID;
            this.QuantityLimit = QuantityLimit;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Unit {  get; set; }
        public int Quantity {  get; set; }
        public int ManagerID { get; set; }
        public int QuantityLimit {  get; set; } 
    }
}
