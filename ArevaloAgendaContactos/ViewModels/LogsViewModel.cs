using CommunityToolkit.Mvvm.ComponentModel;
using ArevaloAgendaContactos.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArevaloAgendaContactos.ViewModels
{
    public partial class LogsViewModel
    {
        [ObservableProperty] string[] lineas = [];

        public async Task CargarAsync() =>
            Lineas = await LogService.ReadAllAsync();
    }
}
