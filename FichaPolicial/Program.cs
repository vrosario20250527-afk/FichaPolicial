using ApiFichasPublicas;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddSingleton(new List<FichaPolicial>
{
    new FichaPolicial
    {
        Id = 1,
        NumeroExpediente = "EXP-2026-001",
        NombreCompleto = "Carlos Mendoza",
        DocumentoIdentidad = "402-1234567-8",
        Edad = 34,
        DelitoImputado = "Robo agravado",
        Peligrosidad = NivelPeligrosidad.Alta,
        Estado = "Detenido",
        FechaRegistro = DateTime.Now.AddDays(-5)
    },
    new FichaPolicial
    {
        Id = 2,
        NumeroExpediente = "EXP-2026-002",
        NombreCompleto = "Elena Rojas",
        DocumentoIdentidad = "001-9876543-2",
        Edad = 28,
        DelitoImputado = "Fraude informático",
        Peligrosidad = NivelPeligrosidad.Baja,
        Estado = "Libre bajo fianza",
        FechaRegistro = DateTime.Now.AddDays(-2)
    },
    new FichaPolicial
    {
        Id = 3,
        NumeroExpediente = "EXP-2026-000012",
        NombreCompleto = "Julio Cabral Lugo",
        DocumentoIdentidad = "402-3816278-4",
        Edad = 28,
        DelitoImputado = "Venta de drogas y asesinato en masa",
        Peligrosidad = NivelPeligrosidad.Alta,
        Estado = "Profugo de la justicia",
        FechaRegistro = DateTime.Now.AddDays(-2)
    }
});

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// Redireccionar raíz al endpoint de la API
app.MapGet("/", () => Results.Redirect("/api/FichasPoliciales"));

app.Run();