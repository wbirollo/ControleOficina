using ControleOficina.Cadastros.Context.SeedingService;
using ControleOficina.Servicos.Context;
using ControleOficina.Servicos.Context.Seeding;
using ControleOficina.Servicos.Context.Seeding.Interfaces;
using ControleOficina.Servicos.Mappers;
using ControleOficina.Servicos.Mappers.Interfaces;
using ControleOficina.Servicos.Repositories;
using ControleOficina.Servicos.Repositories.Interfaces;
using ControleOficina.Servicos.Services;
using ControleOficina.Servicos.Services.Interfaces;
using ControleOficina.Servicos.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<ApplicationSettings>(builder.Configuration.GetSection(ApplicationSettings.Settings));

var connection = builder.Configuration["Connection"];
builder.Services.AddDbContext<ApplicationContext>(options => options.UseNpgsql(connection));

builder.Services.AddMediatR(config => config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

builder.Services.AddScoped<IServicoMapper, ServicoMapper>();
builder.Services.AddScoped<IServicoServices, ServicoServices>();
builder.Services.AddScoped<IServicoRepository, ServicoRepository>();
builder.Services.AddScoped<IVeiculoRepository, VeiculoRepository>();

builder.Services.AddScoped<IServicoMapper, ServicoMapper>();

//builder.Services.AddScoped<ISeedingCliente, SeedingCliente>();
//builder.Services.AddScoped<ISeedingFuncionario, SeedingFuncionario>();
//builder.Services.AddScoped<ISeedingPeca, SeedingPeca>();
//builder.Services.AddScoped<ISeedingServico, SeedingServico>();

var dbcontext = builder.Services.BuildServiceProvider().GetRequiredService<ApplicationContext>();
Seeding.Seed(dbcontext);

builder.Services.AddControllers().AddNewtonsoftJson(options =>
{
    options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "oficina-servico", Version = "v1" });
});

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{    
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "oficina-servico"));    
}

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

