using System;
using System.ComponentModel.DataAnnotations;

namespace EjemploMVC.Models
{
    public class Videos
    {
        public int ID { get; set; }
        [Display(Name = "Título")]
        public string Titulo { get; set; }
        [Display(Name = "Fecha de estreno")]
        [DisplayFormat(DataFormatString = "{0:yyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaEstreno { get; set; }
        [Display(Name = "Género")]
        public string Genero { get; set; }
        public decimal Precio { get; set; }

    }
}
