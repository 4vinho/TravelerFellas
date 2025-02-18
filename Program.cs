using Microsoft.EntityFrameworkCore;
using TravelerFellas;

var builder = WebApplication.CreateBuilder(args);

//Banco de Dados
builder.Services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("InMemoryDb"));

/*
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        "WIN-T0TUUU3CIMK/SQLEXPRESS;Database=master;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;"
    )
);
*/

//Controller
builder.Services.AddControllers();

//AutoMapper
builder.Services.AddAutoMapper(typeof(MappingProfileDTO));

//Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.MapControllers();

app.Run();
