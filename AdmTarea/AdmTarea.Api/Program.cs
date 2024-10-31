using AdmTarea.BW.CU;
using AdmTarea.BW.Interfaces.BW;
using AdmTarea.BW.Interfaces.DA;
using AdmTarea.DA.Acciones;
using AdmTarea.DA.Contexto;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Inyección de dependencias
builder.Services.AddTransient<IGestionarTareaBW, GestionarTareaBW>();
builder.Services.AddTransient<IGestionarTareaDA, GestionarTareaDA>();
builder.Services.AddTransient<IGestionarFoto, GestionarFoto>();
builder.Services.AddTransient<IGestionarFotoDA, GestionarFotoDA>();

//Conexión a BD
builder.Services.AddDbContext<AdmTareaContext>(options =>
{
    //workstation id=ExamenLenguajes.mssql.somee.com;packet size=4096;user id=NelVargas07_SQLLogin_1;pwd=2s2r3sf12d;data source=ExamenLenguajes.mssql.somee.com;persist security info=False;initial catalog=ExamenLenguajes;TrustServerCertificate=True
    // Usar la cadena de conexión desde la configuración
    var connectionString = "Server=ExamenLenguajes.mssql.somee.com;Database=ExamenLenguajes;user id=NelVargas07_SQLLogin_1;pwd=2s2r3sf12d;Trusted_Connection=False  ;TrustServerCertificate=True;";
    options.UseSqlServer(connectionString);
    // Otros ajusteaaaaaaaaaaaaaaaaaaaaaas del contexto de base de datos pueden ser configurados aquí, si es necesario
});


var app = builder.Build();

// prueba


app.UseCors("AllowOrigin");
app.UseCors(options =>
{
    options.AllowAnyOrigin();
    options.AllowAnyMethod();
    options.AllowAnyHeader();
});

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
app.UseDeveloperExceptionPage();
app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "AdmTarea v1"));
//}



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
