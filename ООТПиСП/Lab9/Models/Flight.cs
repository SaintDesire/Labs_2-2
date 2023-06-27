using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public partial class Flight
    {
        public int FlightNumber { get; set; }
        public string DepartureAirport { get; set; }
        public string ArrivalAirport { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int AvailableSeats { get; set; }
        public decimal Price { get; set; }

        public List<Customer> Customers { get; set; }

        public override string ToString()
        {
            return $"Flight {{ FlightNumber = {FlightNumber}, DepartureAirport = {DepartureAirport}, ArrivalAirport = {ArrivalAirport}, DepartureTime = {DepartureTime}, ArrivalTime = {ArrivalTime}, AvailableSeats = {AvailableSeats}, Price = {Price} }}";
        }
    }

}
