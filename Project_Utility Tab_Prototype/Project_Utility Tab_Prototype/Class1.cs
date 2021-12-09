using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Utility_Tab_Prototype
{
    public class List_Of_Utility
    {
        private string Utility_Name;
        private string Utility_Status;
        private bool Utility_In_Use;
        private bool Utility_Reserved;
        private string Date;

        public void Add_Utility(string name)
        {
            this.Utility_Name = name;
        }
        public void Add_Status(string status)
        {
            this.Utility_Status = status;
        }
        public string Show_All()
        {
            return this.Utility_Name+" - "+this.Utility_Status;
           // return this.Utility_Name+" - "+this.Utility_Status+""+Utility_In_Use+""+Utility_Reserved+""+Date;
        }
        public void Check_Utility_InUse(bool In_Use)
        {
            this.Utility_In_Use = In_Use;
        }
        public void Check_Reservation(bool Reserved)
        {
            this.Utility_Reserved=Reserved;
        }
        public void Check_Date(string new_date)
        {
            this.Date = new_date;
        }
    }
}
