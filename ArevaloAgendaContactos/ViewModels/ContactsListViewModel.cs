using ArevaloAgendaContactos.Data;
using ArevaloAgendaContactos.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ArevaloAgendaContactos.ViewModels
{
    public partial class ContactsListViewModel(ContactDatabase db)
    {
        [ObservableProperty] List<Models.Contact> contactos = [];
        public async Task RefrescarAsync() =>
            Contactos = await db.GetContactsAsync();
    }
}
