using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recetas
{
    public  class Receta
    {
        List<string> Nombre {  get; set; }
        List<string> Ingredientes { get; set; }
        List< string> Descripcion { get; set; }
        List<double> Tiempo{ get; set; }

        public Receta(List<string> nombre, List<string> ingredientes, List<string> descripcion, List<double> tiempo)
        {
            Nombre = nombre;
            Ingredientes = ingredientes;
            Descripcion  = descripcion;
            Tiempo = tiempo;
        }

        public Receta() { }

         public void BuscarProducto(string nombre)

        {
            int posiscion = 0;
            foreach (string poducto in Nombre)
            {
                if (poducto == nombre)
                {
                    for (int i = 0; i < Nombre.Count; i++)
                    {
                        if (Nombre[i] == nombre)
                        {
                            posiscion = i; 
                            
                            break;
                        }

                    }
                    MostrarProducto(posiscion);
                }
               
            }

            
           
        }

        public void MostrarProducto(int posicion)
        {
            Console.WriteLine("Nombre: " + Nombre[posicion]);
            Console.WriteLine("Ingredientes:" +Ingredientes[posicion]);
            Console.WriteLine("Descripcion: " + Descripcion[posicion]);
            Console.WriteLine("Tiempo de preparacion"+ Tiempo[posicion]);

        }

        public void MostrarRecetas()
        {
            Console.WriteLine("Recetas Disponibles");
            foreach(string receta in Nombre)
            { 
                Console.WriteLine(receta);
                
            }
        }


    }
}
