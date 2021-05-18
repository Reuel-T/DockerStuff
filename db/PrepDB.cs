using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace HotelApi
{
    public static class PrepDB
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<HotelContext>());
            }
        }

        public static void SeedData(HotelContext ctx)
        {
            System.Console.WriteLine("Applying Migrations");
            ctx.Database.Migrate();
            if(!ctx.Hotels.Any())
            {
                System.Console.WriteLine("Populating Database . . .");
                ctx.Hotels.AddRange(
                    new Hotel( "Tipton Hotel", "https://suitelife.fandom.com/wiki/The_Tipton_Hotel", "Boston", 6, "https://www.google.com/search?q=tipton+hotel&sxsrf=ALeKk01lA82fprm4lpQAWHWehFypS8MbYA:1618906018286&source=lnms&tbm=isch&sa=X&ved=2ahUKEwjZ45PxrozwAhWjShUIHYAaB0oQ_AUoAXoECAEQAw&cshid=1618906080116785&biw=1396&bih=657#imgrc=lk7ODAT2N2Zq0M"),
                    new Hotel( "Hotel California", "https://www.youtube.com/watch?v=EqPtz5qN7HM", "California", 3, "https://www.google.com/search?q=hotel+california&hl=en&tbm=isch&sxsrf=ALeKk02m77N4m8Qy2ODCiAENkCNyuOF5Rw:1618906183290&source=lnms&sa=X&ved=0ahUKEwjc6uq_r4zwAhUSHcAKHXp2BQwQ_AUIECgC&biw=1920&bih=903&dpr=1#imgrc=54AQyNXEo8iARM"),
                    new Hotel( "Hotel Transylvania", "https://en.wikipedia.org/wiki/Hotel_Transylvania", "Unknown", 5, "https://www.google.com/search?q=hotel+tran&sxsrf=ALeKk00wS-_PWTfZY8K-qRsoOK-A4gDtfA:1618906244179&source=lnms&tbm=isch&sa=X&ved=2ahUKEwiT-e7cr4zwAhWa8rsIHRuaDYUQ_AUoAXoECAEQAw&biw=1920&bih=903#imgrc=HEO72PElj77YAM")
                );
                ctx.SaveChanges();
                System.Console.WriteLine("Database Populated");
            }
            else
            {
                System.Console.WriteLine("Database Populated");
            }
        }
    }
}