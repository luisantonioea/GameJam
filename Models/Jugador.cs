using System;
using System.ComponentModel.DataAnnotations;

namespace GameJam.Models
{
    public class Jugador
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Debe ingresar una fecha")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "Ingrese al menos un hobby")]
        public string? Hobbies { get; set; }

        public bool PagoMatricula { get; set; }
    }
}