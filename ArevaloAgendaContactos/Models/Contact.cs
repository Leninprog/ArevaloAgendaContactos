using ServiceStack.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace ArevaloAgendaContactos.Models
{
    public class Contact
    {
        [PrimaryKey, AutoIncrement] public int Id { get; set; }
        [MaxLength(100)] public string Nombre { get; set; } = string.Empty;
        [MaxLength(100)] public string Correo { get; set; } = string.Empty;
        [MaxLength(20)] public string Telefono { get; set; } = string.Empty;
        public bool Favorito { get; set; }
    }
}

