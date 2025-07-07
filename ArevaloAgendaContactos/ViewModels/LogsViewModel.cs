using CommunityToolkit.Mvvm.ComponentModel;
using ArevaloAgendaContactos.Data;

namespace ArevaloAgendaContactos.ViewModels
{
    public partial class LogsViewModel
    {
        [ObservableProperty] string[] lineas = [];

        public async Task CargarAsync() =>
            Lineas = await LogService.ReadAllAsync();
    }
}
