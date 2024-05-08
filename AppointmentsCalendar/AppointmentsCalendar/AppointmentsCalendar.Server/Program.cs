using Server.Business;
using Server.DataAccess;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Business
builder.Services.AddTransient<IAppointmentBusiness, AppointmentBusiness>();
builder.Services.AddTransient<IAppointmentDetailsBusiness, AppointmentDetailsBusiness>();

// DataAccess
builder.Services.AddTransient<IAppointmentDataAccess, AppointmentDataAccess>();
builder.Services.AddTransient<IAppointmentDetailsDataAccess, AppointmentDetailsDataAccess>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors(builder => builder
               .AllowAnyHeader()
               .AllowAnyMethod()
               .SetIsOriginAllowed((host) => true)
               .AllowCredentials()
           );

app.Run();
