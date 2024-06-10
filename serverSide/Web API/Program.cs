using BL;
using BL.BlApi;
using BL.BlImplementation;
using BL.Bo;
using DAL;
using DAL.Do;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
DBActions db = new DBActions(builder.Configuration);
string connStr = db.GetConnectionString("ClinicContext");
// builder.Services.AddScoped<IDoctor, DoctorRepo>();
builder.Services.AddSingleton<BLManager>(x=>new BLManager(connStr));



builder.Services.AddDbContext<ClinicContext>(opt=> opt.UseSqlServer(connStr));
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});
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
app.UseCors("AllowAllOrigins");
app.Run();