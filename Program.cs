using WebApiMiHotel.Data;
using WebApiMiHotel.Services.HabitacionService;
using WebApiMiHotel.Services.ReservacionService;
using WebApiMiHotel.Services.UsuarioService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddCors(options => {
    options.AddPolicy("OriginMiHotel", builder => {
        builder.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:4200");
    });
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => {
    c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
    c.IgnoreObsoleteActions();
    c.IgnoreObsoleteProperties();
    c.CustomSchemaIds(type => type.FullName);
    });

builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<IHabitacionService, HabitacionService>();
builder.Services.AddScoped<IReservacionService, ReservacionService>();
builder.Services.AddDbContext<DataContext>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("OriginMiHotel");

app.UseAuthorization();

app.MapControllers();

app.Run();
