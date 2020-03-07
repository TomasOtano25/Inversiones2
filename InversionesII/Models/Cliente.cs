using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InversionesII.Models
{
    public class Cliente
    {

        public int Id { get; set; }

        [Display(Name = "Primer Nombre")]
        public string PrimerNombre { get; set; }

        [Display(Name = "Segundo Nombre")]
        public string SegundoNombre { get; set; }

        [Display(Name = "Primer Apellido")]
        public string PrimerApellido { get; set; }

        [Display(Name = "Segundo Apellido")]
        public string SegundoApellido { get; set; }

        [Display(Name = "cedula")]
        public string DocumentoIdentidad { get; set; }

        [Display(Name = "Fecha Nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        public string Sexo { get; set; }

        public string Email { get; set; }

        [Display(Name = "# Telefono")]
        public string NoTelefono { get; set; }

        [MaxLength(100, ErrorMessage = "")]
        public string Direccion { get; set; }

        public ICollection<Inversion> Inversions { get; set; }

        [Display(Name = "# Inversiones")]
        public int NumeroInversiones { get { return this.Inversions == null ? 0 : this.Inversions.Count; } }
    }
}
