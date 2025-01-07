using MiniChallengeTwoToFour___Endpoints.Controllers;
using MiniChallengeTwoToFour___Endpoints.services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Letting the web application the following services are acccessible
builder.Services.AddScoped<Add2NumbersServices>();
builder.Services.AddScoped<GoodMorningServices>();
builder.Services.AddScoped<GreaterThanOrLessThanServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
