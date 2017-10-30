using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploMVC.Models
{
    public class Videos
    {
        public int ID { get; set; }
        public string Titulo { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaEstreno { get; set; }
        public string Genero { get; set; }
        public decimal Precio { get; set; }

    }
}
