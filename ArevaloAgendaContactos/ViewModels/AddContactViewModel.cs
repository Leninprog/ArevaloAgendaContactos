using ArevaloAgendaContactos.Data;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using com.sun.org.apache.xalan.@internal.xsltc.compiler.util;

namespace ArevaloAgendaContactos.ViewModels
{
    public partial class AddContactViewModel : ObservableObject
    {
        private readonly ContactDatabase _db;

        public AddContactViewModel(ContactDatabase db)
        {
            _db = db;
        }

        [ObservableProperty] private string nombre = string.Empty;
        [ObservableProperty] private string correo = string.Empty;
        [ObservableProperty] private string telefono = string.Empty;
        [ObservableProperty] private bool favorito;
        [ObservableProperty] private string errorMsg = string.Empty;

        [RelayCommand]
        public async Task GuardarAsync()
        {
            ErrorMsg = string.Empty;

            if (!Telefono.StartsWith("+593"))
            {
                ErrorMsg = "El teléfono debe iniciar con +593";
                return;
            }

            var contacto = new Models.Contact
            {
                Nombre = Nombre,
                Correo = Correo,
                Telefono = Telefono,
                Favorito = Favorito
            };

            await _db.AddContactAsync(contacto);
            await LogService.AppendAsync(Nombre);

            Nombre = Correo = Telefono = string.Empty;
            Favorito = false;

            await Shell.Current.DisplayAlert("Éxito", "Contacto guardado correctamente", "OK");
        }
    }
}
