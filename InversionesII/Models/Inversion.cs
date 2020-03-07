using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InversionesII.Models
{
    public class Inversion
    {
        public int Id { get; set; }

        public decimal Monto { get; set; }

        public int Plazo { get; set; }

        [Display(Name = "Tasa Interes")]
        public decimal TasaInteres { get; set; }

        [Display(Name = "Fecha de ingreso")]
        public DateTime FechaIngreso { get; set; }

        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }
    }
}
