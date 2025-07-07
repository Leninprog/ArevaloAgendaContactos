﻿using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

