var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
// Add this line to enable serving static files
app.UseStaticFiles();

app.MapGet("/", () => "Hello World!");
//This maps the GET request for "/hello" to a lambda 
//function that returns the string "Hello, World!". 
app.Run();
