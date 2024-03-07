using CRUDProject.BusinessService;
using CRUDProject.BusinessService.Interface;
using CRUDProject.DbAccess;
using CRUDProject.DbAccess.Interface;
using CRUDProject.Utility;
using CRUDProject.Utility.Factory;
using CRUDProject.Utility.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//�������ܼƨM�w�ϥέ��ӳ]�w��
var env = EnvironmentHelper.SetEnvorimentVariableAndGetValue(builder.Environment.EnvironmentName);
builder.Configuration
    .CustomAddJsonFile($"appsettings.{env}.json", true, true)
    .CustomAddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddEnvironmentVariables();

var config = builder.Configuration;
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//�NappSetting���]�w�j�w���j���O
builder.Services.Configure<ConnectionStrings>(builder.Configuration.GetSection(nameof(ConnectionStrings)));

//DI�A�ȵ��U
builder.Services.AddSingleton<IUnitOfWorkFactory, UnitOfWorkFactory>();
builder.Services.AddScoped<IPersonService, PersonService>();
builder.Services.AddScoped<IPersonService, PersonService>();
builder.Services.AddScoped<IPersonDbAccess, PersonDbAccess>();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseAuthorization();

app.MapControllers();

app.Run();
