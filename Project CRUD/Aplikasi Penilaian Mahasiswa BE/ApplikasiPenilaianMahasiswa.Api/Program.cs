using ApplikasiPenilaianMahasiswa.Api.DataModel;
using ApplikasiPenilaianMahasiswa.Api.Validations;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using ViewModel;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<MahasiswaDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Db_Conn"));
});

builder.Services.AddScoped<IValidator<JurusanViewModel>, JurusanValidator>();
builder.Services.AddScoped<IValidator<AgamaViewModel>, AgamaValidator>();
builder.Services.AddScoped<IValidator<DosenViewModel>, DosenValidator>();
builder.Services.AddScoped<IValidator<TypeDosenViewModel>, TypeDosenValidator>();
builder.Services.AddScoped<IValidator<UjianViewModel>, UjianValidator>();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(option =>
{
    option.SwaggerDoc("v1", new OpenApiInfo { Title = "PenilaianMhs.Api", Version = "v1" });
});

builder.Services.AddCors(policyBuilder =>
    policyBuilder.AddDefaultPolicy(policy =>
        policy.WithOrigins("*").AllowAnyMethod().AllowAnyHeader()
    )
);

var app = builder.Build();

// Configure the HTTP request pipeline.

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseStatusCodePages();

app.MapControllers();

app.UseCors();

app.Run();
