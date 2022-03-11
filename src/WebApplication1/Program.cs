using Hellang.Middleware.ProblemDetails;
using Serilog;
using WebApplication1;

var builder = WebApplication.CreateBuilder(args);
builder.Host.UseSerilog();
Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateLogger();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddService();
builder.Services
    .AddProblemDetails(op =>
    {
        op.MapToStatusCode<NotImplementedException>(StatusCodes.Status510NotExtended);
        op.Rethrow<NotSupportedException>();
    });

var app = builder.Build();


//Log.Logger = new LoggerConfiguration()
//.ReadFrom.Configuration(builder.Configuration)
//.WriteTo.ApplicationInsights(app.Services.GetRequiredService<TelemetryConfiguration>(), TelemetryConverter.Traces)
//.CreateLogger();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseProblemDetails();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.Run();

Log.CloseAndFlush();
