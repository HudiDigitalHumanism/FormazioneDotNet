using EFCore.Database;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSqlServer<MusicContext>(builder.Configuration.GetConnectionString("DefaultConnection"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


var scope = app.Services.CreateScope();
var db = scope.ServiceProvider.GetService<MusicContext>();
db!.Database.EnsureDeleted();
db!.Database.EnsureCreated();
db.Artists.Add(new Artist()
{
    Name = "AAA",
    Surname = "dd",
    FiscalCode = "ssss",
    Gendre = Gendre.Male,
    CurrentAddress = new Address()
    {
        Via = "via",
        City = "ddd"
    },
    IsDeleted = false
});
db.Artists.Add(new Artist()
{
    Name = "AAAss",
    Surname = "dds",
    FiscalCode = "ABC",
    Gendre = Gendre.Male,
    CurrentAddress = new Address()
    {
        Via = "viass",
        City = "dddsss"
    },
    IsDeleted = true
});
db.SaveChanges();



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
