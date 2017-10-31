using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace EjemploMVC.Models
{
    public class InicioBD
    {
        public static void Inicializar(IServiceProvider serviceProvider)
        {
            using (var context = new EjemploMVCContext(serviceProvider.GetRequiredService<DbContextOptions<EjemploMVCContext>>()))
            {
                if (context.Videos.Any())
                {
                    return;
                }
                context.Videos.AddRange(
                    new Videos
                    { Titulo = "Arma Letal",
                      FechaEstreno = DateTime.Parse("01/01/92"),
                      Genero = "Acción",
                       Precio = 10},
                    new Videos
                    { Titulo = "Lo que el viento se llevó",
                      FechaEstreno = DateTime.Parse("01/01/40"),
                      Genero = "Aventuras",
                       Precio = 10},
                    new Videos
                    { Titulo = "la guerra de las galaxias",
                      FechaEstreno = DateTime.Parse("01/01/78"),
                      Genero = "Aventuras",
                      Precio = 11},
                    new Videos
                    {
                     Titulo = "Cazafantasmas",
                     FechaEstreno = DateTime.Parse("01/01/85"),
                     Genero = "Aventuras",
                     Precio = 11
                      }
                    );
                context.SaveChanges();

            }   
        }
        

    }
}
