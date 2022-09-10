using generics.Errors;
using generics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics.Service
{
    public class ShearcherBeer
    {
        List<Cerveza> cervezas = new List<Cerveza>()
        {
            new Cerveza(500){Alcohol = 3, Cantidad=500, Nombre= "Ipa", Marca="Roes"},
            new Cerveza(500){Alcohol = 6, Cantidad=500, Nombre= "Scotish", Marca="Patagonia"},
            new Cerveza(500){Alcohol = 4, Cantidad=500, Nombre= "Apa", Marca="Temple"},
        }; 

        public int GetCantidad(string Nombre)
        {
            var cerveza = (from d in cervezas
                          where  d.Nombre == Nombre
                          select d).FirstOrDefault();

            if(cerveza == null)
            {
                throw new BeerNotFoundException("Cantidad nula");
            };

            return cerveza.Cantidad;
        }

        
    }
}
