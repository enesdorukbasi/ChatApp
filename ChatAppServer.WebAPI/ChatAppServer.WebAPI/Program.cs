using ChatAppServer.WebAPI.Context;
using ChatAppServer.WebAPI.Hubs;
using DefaultCorsPolicyNugetPackage;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDefaultCors();
builder.Services.AddDbContext<SqlDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("local"));
});
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSignalR();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseCors();
app.UseAuthorization();
app.MapControllers();
app.MapHub<ChatHub>("/chat-hub");

app.Run();
