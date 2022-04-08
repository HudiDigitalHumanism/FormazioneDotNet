using Microsoft.AspNetCore.Mvc;
using WebApplication1.DI;

namespace WebApplication1.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TestController : ControllerBase
{
    private readonly ISingletonInterface singletonInterface;
    private readonly ITransitentInterface transitent;
    private readonly IScopedInterface scoped;
    private readonly IServiceProvider sp;
    private readonly ILogger<TestController> logger;

    public TestController(ISingletonInterface singletonInterface,
        IServiceProvider sp,
        ILogger<TestController> logger)
    {
        this.singletonInterface = singletonInterface;
        this.sp = sp;
        this.logger = logger;
    }

    //[HttpGet]
    //public IActionResult Get()
    //{
    //    var scoped1 = sp.GetRequiredService<IScopedInterface>().ToString();
    //    var scoped2 = sp.GetRequiredService<IScopedInterface>().ToString();

    //    var transient1 = sp.GetRequiredService<ITransitentInterface>().ToString();
    //    var transient2 = sp.GetRequiredService<ITransitentInterface>().ToString();

    //    return Ok(new
    //    {
    //        Sigleton = singletonInterface.ToString(),
    //        transient1 = transient1,
    //        transient2 = transient2,
    //        scoped1 = scoped1,
    //        scoped2 = scoped2
    //    });
    //}

    [HttpGet]
    public IActionResult Get()
    {
        //throw new NotSupportedException();
        //var problem = new OutOfCreditProblemDetails
        //{
        //    Type = "https://example.com/probs/out-of-credit",
        //    Title = "You do not have enough credit.",
        //    Detail = "Your current balance is 30, but that costs 50.",
        //    Instance = "/account/12345/msgs/abc",
        //    Balance = 30.0m,
        //    Accounts = { "/account/12345", "/account/67890" }
        //};

        //return BadRequest(problem);
        var position = new { Latitude = 25, Longitude = 134 };
        var elapsedMs = 34;

        logger.LogInformation("Processed {@Position} in {Elapsed:000} ms.", position, elapsedMs);
        //Log.Information("Processed {@Position} in {Elapsed:000} ms.", position, elapsedMs);

        return Ok();
    }

    public class OutOfCreditProblemDetails : Microsoft.AspNetCore.Mvc.ProblemDetails
    {
        public OutOfCreditProblemDetails()
        {
            Accounts = new List<string>();
        }

        public decimal Balance { get; set; }

        public ICollection<string> Accounts { get; }
    }
}
