using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class customer
    {
        // Member Variables    
        public int CustID;
        public string Name;
        public string Address;

        // Constuctor for initializing fields    
        customer()
        {
            CustID = 1001;
            Name = "Emma";
            Address = "Newquay";
        }

        // Method for displaying customer records (functionality)    
        public void displayData()
        {
            Console.WriteLine("Customer=" + CustID);
            Console.WriteLine("Name=" + Name);
            Console.WriteLine("Address=" + Address);
        }

        // Code for entry point - Main Method 
        // class members code    

        //Entry point    
        static void Main(string[] args)
        {
            // object instantiation    
            customer obj = new customer();

            //Method calling    
            obj.displayData();

            //fields calling    
            Console.WriteLine(obj.CustID);
            Console.WriteLine(obj.Name);
            Console.WriteLine(obj.Address);
        }
    }
}
