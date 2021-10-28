using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Activo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal ValorInicial { get; set; }
        public decimal ValorFinal { get; set; } 
        public int TiempoDepreciacion { get; set; }
        public MetodoDepreciacion MetodoDepreciacion { get; set; }
    }
}
