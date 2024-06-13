
using AM.ApplicationCore;
using AM.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Collections.Generic;

namespace AM.UI.Console
{
    public class Chap3
    {
        static ShowLine showLine = System.Console.WriteLine;
        public static void Test1()
        {

            using (var context = new Context())
            {
                context.Planes.AddRange(InMemorySource.Boeing1, InMemorySource.Boeing2, InMemorySource.Airbus);
                context.Staffes.AddRange(InMemorySource.Staffs);
                context.Passengers.AddRange(InMemorySource.Travellers);
                context.Flights.AddRange(InMemorySource.Flights);

                context.SaveChanges();

            }
        }
        public static void Test2()
        {

            using (var context = new Context())
            {
                

                // 15. Charger la liste des tickets
                var tickets = context.Tickets.ToList();

                    tickets.ShowList("tickets==", showLine);
                }
            
        }

    }
}
