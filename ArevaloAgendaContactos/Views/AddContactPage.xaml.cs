using ArevaloAgendaContactos.ViewModels;

namespace ArevaloAgendaContactos.Views;

public partial class AddContactPage : ContentPage
{
    public AddContactPage(AddContactViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}