using BL;
using BL.BlApi;
using BL.BlImplementation;
using BL.Bo;
using DAL;
using DAL.Do;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// builder.Services.AddScoped<IDoctor, DoctorRepo>();
builder.Services.AddSingleton<BLManager>();


DBActions db= new DBActions(builder.Configuration);
string connStr = db.GetConnectionString("ClinicContext");
builder.Services.AddDbContext<ClinicContext>(opt=> opt.UseSqlServer(connStr));
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
//var app = builder.Build();


//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}
//app.UseHttpsRedirection();

//app.UseAuthorization();
var app = builder.Build();
app.MapGet("/", () => "Hello World!");
app.MapControllers();
app.Run();