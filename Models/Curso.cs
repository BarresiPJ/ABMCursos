using System;
using System.ComponentModel.DataAnnotations;

namespace ABMCursos.Models
{
    public partial class Curso
    {
        public int Idcurso { get; set; }

        [Required]
        [Display(Name = "Nombre del Curso")]
        public string Nombrecurso { get; set; } = null!;

        [Required]
        [Display(Name = "Profesor")]
        public string Profesor { get; set; } = null!;

        [Range(1, 100)]
        [Display(Name = "Cantidad de Alumnos")]
        public int Cantidadalumnos { get; set; }

        [Required]
        [Display(Name = "Día")]
        public string Dia { get; set; } = null!;

        [Display(Name = "Horario")]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]
        public TimeSpan Horario { get; set; }
    }
}
