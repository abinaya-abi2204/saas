using Microsoft.EntityFrameworkCore;
using SupportAnalyticsAPI.Data;

var builder=WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(opt=>
    opt.UseSqlite("Data Source=support.db"));

builder.Services.AddCors(options=>{
    options.AddPolicy("AllowAll",
        p=>p.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod());
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app=builder.Build();

app.UseCors("AllowAll");

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();