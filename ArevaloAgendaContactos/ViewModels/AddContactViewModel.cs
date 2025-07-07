using ArevaloAgendaContactos.Data;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ArevaloAgendaContactos.Models;

namespace ArevaloAgendaContactos.ViewModels
{
    public partial class AddContactViewModel(ContactDatabase db)
    {
        [ObservableProperty] string nombre = string.Empty;
        [ObservableProperty] string correo = string.Empty;
        [ObservableProperty] string telefono = string.Empty;
        [ObservableProperty] bool favorito;

        [ObservableProperty] string errorMsg = string.Empty;

        [RelayCommand]
        async Task GuardarAsync()
        {
            ErrorMsg = string.Empty;

            if (!Telefono.StartsWith("+593"))
            {
                ErrorMsg = "El teléfono debe iniciar con +593";
                return;
            }

            var contacto = new Contact
            {
                Nombre = Nombre,
                Correo = Correo,
                Telefono = Telefono,
                Favorito = Favorito
            };

            await db.AddContactAsync(contacto);
            await LogService.AppendAsync(Nombre);

            // Limpieza del formulario
            Nombre = Correo = Telefono = string.Empty;
            Favorito = false;

            await Shell.Current.DisplayAlert("Éxito", "Contacto guardado.", "OK");
        }
    }
}
