using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Models
{
    public class AviaBookingRepository
    {
        public IEnumerable<Customer> GetAllCustomers()
        {
            using (var context = new AviaBookingContext())
            {
                return context.Customers.ToList();
            }
        }

        public void AddCustomer(Customer customer)
        {
            using (var context = new AviaBookingContext())
            {
                context.Customers.Add(customer);
                context.SaveChanges();
            }
        }

        public void UpdateCustomer(Customer customer)
        {
            using (var context = new AviaBookingContext())
            {
                context.Entry(customer).State = (Microsoft.EntityFrameworkCore.EntityState)EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteCustomer(int customerId)
        {
            using (var context = new AviaBookingContext())
            {
                var customer = context.Customers.Find(customerId);
                if (customer != null)
                {
                    context.Customers.Remove(customer);
                    context.SaveChanges();
                }
            }
        }

        public IEnumerable<Flight> GetAllFlights()
        {
            using (var context = new AviaBookingContext())
            {
                return context.Flights.ToList();
            }
        }

        public void AddFlight(Flight flight)
        {
            using (var context = new AviaBookingContext())
            {
                context.Flights.Add(flight);
                context.SaveChanges();
            }
        }

        public void UpdateFlight(Flight flight)
        {
            using (var context = new AviaBookingContext())
            {
                context.Entry(flight).State = (Microsoft.EntityFrameworkCore.EntityState)EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteFlight(int flightNumber)
        {
            using (var context = new AviaBookingContext())
            {
                var flight = context.Flights.Find(flightNumber);
                if (flight != null)
                {
                    context.Flights.Remove(flight);
                    context.SaveChanges();
                }
            }
        }
    }

}
