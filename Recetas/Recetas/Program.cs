using Recetas;

class Program
{


    static void Main(string[] args)
    {


        bool continuar = true;
        int opcion =0;
        List<double> tiempo = new List<double>();
        List<string> nombreReceta = new List<string>();
        List<string> ingrediente = new List<string>();
        List<string> descripcion = new List<string>();
        Receta receta = new Receta();




        do
        {
            try
            {
                Console.WriteLine(" Recetas: ");
                Console.WriteLine("1. Ingresar una receta");
                Console.WriteLine("2. buscar receta ");
                Console.WriteLine("3. mostrar recetas");
            


                opcion = Convert.ToInt32(Console.ReadLine());
                while (opcion < 1 || opcion > 4)
                {
                    Console.WriteLine("Valor no esta en el rango...")
                        ; Console.WriteLine("Ingrese un valor: ");
                    opcion = Convert.ToInt32(Console.ReadLine());
                }
                switch (opcion)
                {
                    case 1:
                        Console.Clear();

                        Console.Write("ingrese el nombre de la receta: ");
                        string nombre = Console.ReadLine().ToLower();
                        Console.Write("ingrese los ingredientes: ");
                        string ingredientesReceta = Console.ReadLine().ToLower();
                        Console.Write("ingrese la descripcion: ");
                        string descripcionReceta = Console.ReadLine().ToLower();
                        Console.Write("ingrese el tiempo de coccion: ");
                        double coccion = Convert.ToDouble(Console.ReadLine());

                        tiempo.Add(coccion);
                        nombreReceta.Add(nombre);
                        descripcion.Add(descripcionReceta);
                        ingrediente.Add(ingredientesReceta);
                        receta = new Receta(nombreReceta,ingrediente,descripcion,tiempo);
                     

                        break;
                    case 2:

                        Console.Write("ingrese el nombre de la receta que busca : ");
                        string busquedaReceta = Console.ReadLine().ToLower();
                        receta.BuscarProducto(busquedaReceta);
                      
                        
                        break;
                    case 3:
                        Console.Clear();
                        receta.MostrarRecetas();
                        break;
                    case 4:

                        continuar = false;

                        break;

                    


                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error... " + ex.Message);

            }


        } while (continuar == true);


    }
}