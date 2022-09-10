using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics.Models
{
    public class Cerveza : Bebida, IBebidaAlcoholica
    {

        public int Alcohol { get; set; }
        public string Marca { get; set; }

        public int id { get; set; }
        public void MaxRecomendado()
        {
            Console.WriteLine("El maximo permitido de una cerveza es 10");
        }

        public Cerveza(int Cantidad, string Nombre = "Cerveza")
            : base(Nombre, Cantidad)
        {

        }

    }
}