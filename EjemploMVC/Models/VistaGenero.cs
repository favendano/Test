using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploMVC.Models
{
    public class VistaGenero
    {
        public List<Videos> L_Videos;
        public SelectList Generos;
        public string generoVideo { get; set; }
    }
}
