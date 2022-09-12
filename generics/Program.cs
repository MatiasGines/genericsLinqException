using generics.Errors;
using generics.Models;
using generics.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace generics
{
    class Program
    {
        static async Task Main(string[] args)
        {

            Action<string,string> mostrar = Show;
            HacerAlgo(mostrar);

        }
        
        public static void HacerAlgo(Action<string,string> funcionFinal)
        {
            Console.WriteLine("linea de texto");
            funcionFinal("Esto se envia desde otra funcion "+"otra cadena")    
            Console.WriteLine("linea de texto");
        }   
        public static void Show(string cad, string cad2)
        {
            Console.WriteLine(cad + cad2);
        }
        public static int Show(string cad)
        {
            return cad.Count();
        }
    }
}

            /*
            try {
                var searcherBeer = new ShearcherBeer();
                var cantidad = searcherBeer.GetCantidad("NombreDeCerveza");
                Console.WriteLine("todo bien");

            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine("Operación invalida");
            }
            
            catch (BeerNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Excepción no controlada");
            }
            finally
            {
                Console.WriteLine("Esto siempre se ejecuta");
            }
            */
            /*Utilizado para realziar consultas con linq*/
            /*
            List<Bar> bares = new List<Bar>()
            {
                new Bar("El bar SOA")
                {
                    cervezas = new List<Cerveza>()
                    {
                        new Cerveza(500){Alcohol = 3, Cantidad=500, Nombre= "Ipa", Marca="Roes"},
                        new Cerveza(500){Alcohol = 6, Cantidad=500, Nombre= "Scotish", Marca="Patagonia"},
                        new Cerveza(500){Alcohol = 4, Cantidad=500, Nombre= "Apa", Marca="Temple"},

                    }
                },
                new Bar("El bar de Moe")
                {
                    cervezas = new List<Cerveza>()
                    {
                        new Cerveza(500){Alcohol = 5, Cantidad=500, Nombre= "Ipa", Marca="Roes"},
                        new Cerveza(500){Alcohol = 3, Cantidad=500, Nombre= "Porter", Marca="Patagonia"},
                        new Cerveza(500){Alcohol = 8, Cantidad=500, Nombre= "Honey", Marca="Temple"},

                    }
                },
                new Bar("El bar vacio")
            };

            //obtener datos con subconsultas Linq
            var bar = (from d in bares
                      where d.cervezas.Where(c => c.Nombre == "Honey").Count() > 0
                      select new BarData(d.Nombre)
                      {
                          bebidas = (from c in d.cervezas
                                     select new Bebida(c.Nombre, c.Cantidad)).ToList()
                       
                      }
                      ).ToList();
            


            //utilizando generics para hacer una peticion a servicio web mediante la clase SendRequest y su metodo Send
            /*
            var cerveza = new Cerveza(500, "Ipa")
            {
                Alcohol = 5,
                Marca = "Roes"
            };

            Service.SendRequest<Cerveza> service = new Service.SendRequest<Cerveza>();
            var CervezaRespuesta = await service.Send(cerveza);
            */
