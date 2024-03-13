
using AM.ApplicationCore;
using AM.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace AM.UI.Console
{
    public class Chap3
    {
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
    }
}
