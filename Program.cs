var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// --- INICIA LA SECCIÓN MÁGICA ---
// 1. Busca una variable de entorno llamada "PORT" (que Render nos da).
// 2. Si no la encuentra (porque estamos en nuestra máquina), usa "8080" como respaldo.
var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";

// 3. Le decimos a nuestra app que escuche en CUALQUIER dirección IP, pero en ESE puerto.
app.Urls.Add($"http://0.0.0.0:{port}");
// --- TERMINA LA SECCIÓN MÁGICA ---

app.MapGet("/", () => "Hola Mundo Definitivo! Desplegado con exito.");

app.Run();