using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;



namespace Control_INVENTARIO
{
   

    internal class articulos
    {// arreglos 
        public static int[] id = new int[3]; //codigo del articulo
        public static string[] name = new string[3];    // nombre del articulo
        public static int[] cant = new int[3];
        public static int[] costo = new int[3];    
        public static string[] bodega = new string[3];


        //metodo para impresion de Datos de artuculos
        public static void Impresion_datos(int i) 
        {
            Console.WriteLine($"== Bodega: {bodega[i]}/\n");
            Console.WriteLine($"Codigo: {id[i]} / Nombre : {name[i]} / Cantidad: {cant[i]} / Precio: {costo[i]} ");
            Console.WriteLine("-------------------------------------------------------------------\n");

        }

        //metodo para inicializar arreglos
        public static  void inicializar_Arreglos() 
        {
            for (int i = 0; i < id.Length; i++)
            { 
                id[i] = 0;
                name[i] = " "; 
                //esto me sirve para borrar todos los datos y empezar de cero
            }
           
            Console.Clear(); //limpiar pantalla 
            Console.WriteLine("***Los arreglos han sido inicializados**\n");

        }

        //metodo para ingresar productos
        public static void ingresar_Productos() 
        {
            int indice = 0;
            int num = 1;
            // WHILE  este sirve para que  me permita ingresar x cantidad de articulos mientras sea menor que lo estipulado==> id
            while (indice < id.Length) // me pregunta 3 veces por un articulo
            {
                
                Console.Clear();
                Console.WriteLine($"***REGISTRO DEL ARTICULO {num}***");
                Console.Write(" A cual bodega quiere registrar el Articulo?: ");
                bodega[indice] = (Console.ReadLine());
                Console.Write($"Digite el codigo para el  Articulo: ");
                id[indice] = int.Parse(Console.ReadLine());
                Console.Write($"Digite el nombre del Articulo: ");
                name[indice] = Console.ReadLine();
                Console.Write($"Digite el Precio del Articulo: ");
                costo[indice] = int.Parse(Console.ReadLine());
                Console.Write($"Digite la cantidad : ");
                cant[indice] = int.Parse(Console.ReadLine());
                
                num++;
                indice++;
                Console.Clear() ;
            }
            Console.WriteLine("Los Articulos han sido Ingresados\n");
         
        }


        //metodo para modificar productos
        public  static void modificar_Productos() 
        {
            Console.Clear ();
            Console.Write("Digite el codigo del articulo:");
            
            int NewName = int.Parse(Console.ReadLine());

            for (int i = 0; i < id.Length; i++)
            {
                if (id[i] == NewName) 
                {
                    Console.Clear () ; 
                    Console.Write("*****Datos del  articulo:****\n");
                    Console.WriteLine($"Codigo: {id[i]} Nombre Art.: {name[i]} ");
                    Console.WriteLine($"Digite  un nuevo nombre ");
                    name[i] = Console.ReadLine();
                    break;
                }
                


                
            }

        }


        //metodo para consultar en el inventario 
        public  static void consultar_Inventario()

        {
            Console.Clear();
            Console.WriteLine("**Reporte De Articulos**\n");
            Console.WriteLine($"{id.Length} Articulos Registrados\n");

            for (int i = 0; i < id.Length; i++)
            {
               Impresion_datos(i); 
            }
            Console.WriteLine("*******FIN DEL REPORTE**********");
            Console.ReadLine();
            Console.Clear();

        }

       

        //metodo para eliminar productos
        public  static  void excluir_Productos() 
        
        {
            char sino = ' ';
            Console.Clear();
            Console.Write("Digite el codigo del articulo:");
            int Code = int.Parse(Console.ReadLine());

            for (int i = 0; i < id.Length; i++)
            {
                if (id[i] == Code)
                {
                    Console.Clear();
                    Console.Write("*****Datos del  articulo:****\n");
                    Impresion_datos(i);
                    Console.WriteLine($"esta seguro que lo quiere borrar ? \nDigite 'S' para si o 'N'para no");
                    sino = char.Parse(Console.ReadLine());
                    if (sino == 'S')
                    {
                        name[i] = " ";
                        id[i] = 0;
                        Console.WriteLine("***El articulo a sido Borrado***\n");

                    }
                    else { break; }
                    
                }

            }   
        }

        public static void Buscar_Articulo()
        {
            string entrada = "";
            Console.Clear();
            Console.WriteLine("***Buscador de Articulos***\n");
            Console.Write("ingrese el Nombre o codigo del articulo: ");
            entrada = Console.ReadLine();
            if (int.TryParse(entrada, out int result))
            {
                for (int i = 0; i < id.Length; i++)
                {


                    if (result == id[i])
                    {
                        Impresion_datos(i);

                    }

                    else if (entrada == name[i])
                    {
                        Impresion_datos(i);
                        
                    }
                   

                }

            }
            else { Console.WriteLine("articulo no resgistrado"); }
            Console.ReadLine();
            Console.Clear ();
           
        }

    }

}
