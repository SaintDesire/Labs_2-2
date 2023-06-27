using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Media.Media3D;

namespace Lab8
{
    public partial class AviaBookingDataAccess
    {
        private readonly string connectionString;

        public AviaBookingDataAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Flight> GetAllFlights()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Flights", connection);
                var dataTable = new DataTable();
                var dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
                var flights = new List<Flight>();
                foreach (DataRow row in dataTable.Rows)
                {
                    flights.Add(new Flight
                    {
                        Id = (int)row["Id"],
                        Departure = (string)row["Departure"],
                        Destination = (string)row["Destination"],
                        DepartureTime = row["DepartureTime"].ToString(),
                        ArrivalTime = row["ArrivalTime"].ToString(),
                        Price = (decimal)row["Price"]
                    });
                }
                return flights;
            }
        }

        public void AddFlight(Flight flight)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = new SqlCommand("INSERT INTO Flights (Departure, Destination, DepartureTime, ArrivalTime, Price) VALUES (@Departure, @Destination, @DepartureTime, @ArrivalTime, @Price)", connection);
                command.Parameters.AddWithValue("@Departure", flight.Departure);
                command.Parameters.AddWithValue("@Destination", flight.Destination);
                command.Parameters.AddWithValue("@DepartureTime", flight.DepartureTime);
                command.Parameters.AddWithValue("@ArrivalTime", flight.ArrivalTime);
                command.Parameters.AddWithValue("@Price", flight.Price);
                command.ExecuteNonQuery();
            }
        }

        public void UpdateFlight(Flight flight)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = new SqlCommand("UPDATE Flights SET Departure = @Departure, Destination = @Destination, DepartureTime = @DepartureTime, ArrivalTime = @ArrivalTime, Price = @Price WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Departure", flight.Departure);
                command.Parameters.AddWithValue("@Destination", flight.Destination);
                command.Parameters.AddWithValue("@DepartureTime", flight.DepartureTime);
                command.Parameters.AddWithValue("@ArrivalTime", flight.ArrivalTime);
                command.Parameters.AddWithValue("@Price", flight.Price);
                command.Parameters.AddWithValue("@Id", flight.Id);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteFlight(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = new SqlCommand("DELETE FROM Flights WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }
    }
}