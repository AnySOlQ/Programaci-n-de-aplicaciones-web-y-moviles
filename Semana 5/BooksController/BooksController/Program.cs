var builder = WebApplication.CreateBuilder(args);

// Registrar servicios para controladores
builder.Services.AddControllers();

var app = builder.Build();

// Configurar el servidor para usar el puerto 5090
app.Urls.Add("http://localhost:5090");

app.MapControllers();

app.Run();
