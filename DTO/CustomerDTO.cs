using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.DTO
{
    internal class CustomerDTO
    {
        public CustomerDTO(int ID, string Name, string PhoneNumber, string Address, string Gender, int Points)
        {
            this.ID = ID;
            this.Name = Name;
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
            this.Gender = Gender;
            this.Points = Points;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public int Points { get; set; }
    }
}
