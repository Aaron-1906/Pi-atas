var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "¡Bienvenidos a The Piñata Palace! Próximamente las mejores piñatas en Azure.");

app.Run();