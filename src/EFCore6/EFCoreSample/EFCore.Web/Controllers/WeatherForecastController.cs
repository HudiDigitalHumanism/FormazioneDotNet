using EFCore.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly MusicContext context;

        public WeatherForecastController(MusicContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetArtist()
        {
            //var a = await context.Artists.ToListAsync();
            //foreach (var e in context.ChangeTracker.Entries())
            //{
            //    Console.WriteLine(e);
            //}

            //var via = a[0].CurrentAddress.Via;

            //var r = await context.Artists.AsNoTracking().Select(x => x.CurrentAddress).ToListAsync();
            // var artists = await context.Artists.AsNoTracking().ToListAsync();
            //foreach (var e in context.ChangeTracker.Entries())
            //{
            //    Console.WriteLine(e);
            //}

            //var a = artists[0];
            //a.Surname = a.Surname + "a";
            //context.Attach(a);
            //context.Entry(a).State = EntityState.Modified;
            //context.SaveChanges();

            var artists = await context.Artists.AsNoTracking().Where(t => t.IsDeleted).ToListAsync();
            context.Artists.Where(t => t.FiscalCode == "a").Where(t => t.FiscalCode == "a");
            context.Artists.Where(t => t.FiscalCode == "a" && t.FiscalCode == "a");


            return Ok(artists);
        }

        // LEGGERE
        // AS NO TRACKING

        // SCRIVERE E AGGIORNATE
        // AS NO TRACKING su entità che mi estraggono oggetti non relazionati a oggetti di scrittura.
    }
}