using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.DTO
{
    internal class BillDTO
    {
        public BillDTO(int ID, DateTime Time, string State, float Value,int CustomerID, int EmployeeID, int TableID) 
        {
            this.ID = ID;
            this.Time = Time;
            this.State = State;
            this.Value = Value;
            this.CustomerID = CustomerID;
            this.EmployeeID = EmployeeID;
            this.TableID = TableID;
        }

        public int ID { get; set; }
        public DateTime Time { get; set;}
        public string State { get; set;}
        public float Value { get; set;}
        public int CustomerID {  get; set; }
        public int EmployeeID { get; set; }
        public int TableID { get; set; }


    }
}
