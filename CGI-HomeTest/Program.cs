using CGI_HomeTest.SupportClass;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddControllers(o => o.InputFormatters.Insert(o.InputFormatters.Count, new TextInputFormatter()));
var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
