using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics.Models
{
    public class Bebida
    {
        //toda clase tiene atributos
        public string Nombre { get; set; }
        public int Cantidad { get; set; }

        //atributos que un obj necesita para existir: constructor
        public Bebida(string Nombre, int Cantidad)
        {//estos atributos son locales del metodo y requeridos para crear el obj
            this.Nombre = Nombre;
            this.Cantidad = Cantidad;
        }

        //metodo: acción a realizarse, con la cual podemos modificar atributos
        public void Beberse(int CuantoBebio)
        { //con .this hacemos referencia a los atributos de la clase.
            this.Cantidad = this.Cantidad - CuantoBebio;
        }
    }
}
