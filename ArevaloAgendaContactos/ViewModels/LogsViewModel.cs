using CommunityToolkit.Mvvm.ComponentModel;
using ArevaloAgendaContactos.Data;

namespace ArevaloAgendaContactos.ViewModels
{
    public partial class LogsViewModel : ObservableObject
    {
        [ObservableProperty]
        private string[] lineas = Array.Empty<string>();

        public async Task CargarAsync()
        {
            Lineas = await LogService.ReadAllAsync();
        }
    }
}