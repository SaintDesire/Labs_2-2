using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public partial class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int FlightNumber { get; set; }
        public Flight Flight { get; set; }


        public override string ToString()
        {
            return $"Customer {{ CustomerId = {CustomerId}, Name = {Name}, Email = {Email}, PhoneNumber = {PhoneNumber} }}";
        }
    }


}
