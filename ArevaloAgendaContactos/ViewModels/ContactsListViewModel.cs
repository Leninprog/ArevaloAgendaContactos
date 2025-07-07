using ArevaloAgendaContactos.Data;
using ArevaloAgendaContactos.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ArevaloAgendaContactos.ViewModels
{
    public partial class ContactsListViewModel : ObservableObject
    {
        private readonly ContactDatabase _db;

        public ContactsListViewModel(ContactDatabase db)
        {
            _db = db;
            _ = RefrescarAsync();
        }

        [ObservableProperty]
        private List<Models.Contact> contactos = new();

        public async Task RefrescarAsync()
        {
            Contactos = await _db.GetContactsAsync();
        }
    }
}
