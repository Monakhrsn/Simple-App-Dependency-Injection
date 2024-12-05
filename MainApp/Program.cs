
using System.Text.Json.Serialization.Metadata;
using MainApp.Dialogs;
using MainApp.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

 IHost host = Host.CreateDefaultBuilder()
    .ConfigureServices(services =>
    {
        services.AddSingleton<UserService>();
        services.AddSingleton<StandardMenuDialogs>();
        services.AddSingleton<AdminMenuDialogs>();
    })
    .Build();
 
var standardMenuDialogs = host.Services.GetRequiredService<StandardMenuDialogs>();
var adminMenuDialogs = host.Services.GetRequiredService<AdminMenuDialogs>();
 
    
standardMenuDialogs.CreateUserOption();
adminMenuDialogs.CreateUserOption();


standardMenuDialogs.ShowAllUsersOption();
adminMenuDialogs.ShowAllUsersOption();