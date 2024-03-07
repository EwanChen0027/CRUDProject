using CRUDProject.BusinessService;
using CRUDProject.BusinessService.Interface;
using CRUDProject.DbAccess;
using CRUDProject.DbAccess.Interface;
using CRUDProject.Utility;
using CRUDProject.Utility.Factory;
using CRUDProject.Utility.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//依環境變數決定使用哪個設定檔
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

//將appSetting的設定綁定為強型別
builder.Services.Configure<ConnectionStrings>(builder.Configuration.GetSection(nameof(ConnectionStrings)));

//DI服務註冊
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
