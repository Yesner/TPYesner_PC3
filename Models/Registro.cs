using System;
using System.Collections.Generic;

namespace TPYesner_PC3.Models
{
    public partial class Registro
    {
        public int Idregistro { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Pais { get; set; } = null!;
        public string Telefono { get; set; } = null!;
    }
}
