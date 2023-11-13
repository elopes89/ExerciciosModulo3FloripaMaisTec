using FluentValidation.AspNetCore;
using LabSchool.Context;
using LabSchool.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddFluentValidation(config => {
    config.RegisterValidatorsFromAssembly(typeof(Program).Assembly);
});


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Respositories
builder.Services.AddScoped<ProfessorRepository>();
builder.Services.AddScoped<AlunoRepository>();
builder.Services.AddScoped<PedagogoRepository>();

//AutoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddDbContext<LabSchoolContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("LabSchoolContext")));


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
