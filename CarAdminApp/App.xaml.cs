using CarAdminApp.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;




using CarAdminApp;

public partial class App : Application
{
    private readonly IServiceProvider _serviceProvider;

    public App()
    {
        var services = new ServiceCollection();
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlite("Data Source=caradmin.db")); // SQLite Database configuratie

        _serviceProvider = services.BuildServiceProvider();
    }

    protected override void OnStartup(StartupEventArgs e)
    {
        using (var context = _serviceProvider.GetRequiredService<ApplicationDbContext>())
        {
            context.Database.Migrate(); // Zorg ervoor dat de database migraties toepast
        }

        base.OnStartup(e);
    }
}
