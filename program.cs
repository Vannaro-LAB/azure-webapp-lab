var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Simple test endpoint
app.MapGet("/test", () => new 
{ 
    Message = "Deployment Successful!", 
    Framework = ".NET 8",
    Timestamp = DateTime.UtcNow,
    Environment = builder.Environment.EnvironmentName,
    Server = Environment.MachineName // Helps verify it's not running on your Dell laptop
});

app.MapGet("/", () => "Hello from Azure! Your .NET 8 App is live.");

app.Run();
