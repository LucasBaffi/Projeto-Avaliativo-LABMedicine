// using LABMedicine.Data;
using LABMedicine.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string connectionString = "Server=DESKTOP-CB1HVBB\\SQLEXPRESS;Database=labmedicinebd;Trusted_Connection=True;TrustServerCertificate=True;";
//Inje��o de Depencencia do Context
builder.Services.AddDbContext<LabmedicinebdContext>(options => options.UseSqlServer(connectionString));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// using (var context = new LabmedicinebdContext(new DbContextOptionsBuilder<LabmedicinebdContext>().UseSqlServer(connectionString).Options))
// {
//     DataSeed.SeedData(context);
// }
app.Run();
