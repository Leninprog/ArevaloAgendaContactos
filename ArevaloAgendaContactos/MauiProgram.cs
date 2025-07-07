using ArevaloAgendaContactos.Views;
using ArevaloAgendaContactos.Data;
using ArevaloAgendaContactos.ViewModels;
using Microsoft.Extensions.Logging;

namespace ArevaloAgendaContactos;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts => fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular"));

        string dbPath = Path.Combine(FileSystem.AppDataDirectory, "contacts.db3");
        var db = new ContactDatabase(dbPath);
        db.Init().Wait();

        builder.Services.AddSingleton(db);
        builder.Services.AddTransient<AddContactViewModel>();
        builder.Services.AddTransient<ContactsListViewModel>();
        builder.Services.AddTransient<LogsViewModel>();

        builder.Services.AddTransient<AddContactPage>();
        builder.Services.AddTransient<ContactsListPage>();
        builder.Services.AddTransient<LogsPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif
        return builder.Build();
    }
}
