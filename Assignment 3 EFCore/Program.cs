using Assignment_1_EFCore.AirlinesModels;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Assignment_3_EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //    using AirLineDBContext context = new AirLineDBContext();
        //  var airline = new Airline()
        //  {
        //      Name= "EgyptAir",
        //      Cont_Person= "Ahmed Ali",
        //      airline_Phones = new HashSet<Airline_Phones>
        //{
        //    new Airline_Phones { Phones =0123456789},
        //    new Airline_Phones { Phones = 0113654789}
        //},
        //      Address="Cairo"
        //  };
        //    context.Add(airline);
        //    context.SaveChanges();
        //    Aircraft model = new Aircraft()
        //    {
        //        Model = "Model01",
        //        Capacity = 180,
        //        airline = airline
        //    };
        //    context.Add(model);
        //    context.SaveChanges();
        //    Transaction transaction = new Transaction()
        //    {
        //        Amount=5000,
        //        Description="Tickets",
        //        airlines=airline
        //    };
            //context.Add(transaction);
            //context.SaveChanges();
            //var result01 = context.employees.Where(e => e.airline.Name == "EgyptAir");
            //var result02 = context.transactions
            //                 .Where(t => t.airlines.Name == "EgyptAir")
            //                 .Select(t => new
            //                 {
            //                     t.Id,
            //                     t.Description,
            //                     t.Amount
            //                 });
            //var result03 = context.employees
            //           .GroupBy(e => e.airline.Name)
            //           .Select(g => new
            //           {
            //               AirlineName = g.Key,
            //               EmployeeCount = g.Count()
            //           });
            //model.Capacity = 200;
            //context.SaveChanges();
            //var result04 = context.transactions
            //                     .Where(t => t.Date.Year < 2020);
            //context.RemoveRange(result04);
            //var aircraft = context.Aircraft
            //                         .FirstOrDefault(a => a.Model == "Model01");

            //if (aircraft != null)
            //{
            //    var route = new Route
            //    {
            //        Origin = "Cairo", 
            //        Destination = "Dubai",
            //        Distance = "???",
            //        Classification = "International"
            //    };
            //    var departure = DateTime.Now;
            //    var arrival = departure.AddHours(4);
            //    var aircraftRoute = new Aircraft_Routes
            //    {
            //        AC_Id = aircraft.Id,
            //        Route_Id = route.Id,
            //        Departure = departure,
            //        Arrival = arrival,
            //        Num_Of_Pass = 180, 
            //        Price = 3000,
            //        aircraft = aircraft,
            //        routes = route
            //    };
            //    context.aircraft_Routes.Add(aircraftRoute);
            //    context.SaveChanges();
            }
        }
    }
