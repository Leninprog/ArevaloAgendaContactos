using ArevaloAgendaContactos.Data;
using ArevaloAgendaContactos.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ArevaloAgendaContactos.ViewModels
{
    public partial class ContactsListViewModel(ContactDatabase db)
    {
        [ObservableProperty] List<Contact> contactos = [];
        public async Task RefrescarAsync() =>
            Contactos = await db.GetContactsAsync();
    }
}
