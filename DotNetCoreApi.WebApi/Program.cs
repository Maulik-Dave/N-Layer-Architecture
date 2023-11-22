using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using DotNetCoreApi.Data.Context;
using DotNetCoreApi.Helper.CommonHelper;
using DotNetCoreApi.WebApi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson(options =>
{
    options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddMemoryCache();
builder.Services.AddHttpContextAccessor();

builder.Services.AddSwaggerGen();

var config = new AppConfiguration();

builder.Configuration.Bind("DefaultConnectionString", builder.Configuration.GetConnectionString("DefaultConnectionString"));
builder.Configuration.Bind("App", config);
builder.Services.AddSingleton(config);

builder.Services.AddDbContext<DBCon>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString"),
    b => b.MigrationsAssembly("DotNetCoreApi.Data")), ServiceLifetime.Transient);

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory(containerBuilder =>
{
    containerBuilder.RegisterModule(new AutofacWebApi());
}));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

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
