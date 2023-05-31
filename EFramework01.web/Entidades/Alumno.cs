using System;
using System.Collections.Generic;

namespace EFramework01.web.Entidades
{
    public partial class Alumno
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public int? Edad { get; set; }
        public string? Ciudad { get; set; }
    }
}
