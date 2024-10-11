using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_INVENTARIO 

{
    internal class menu
    {
        public static void Principal()
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("**CONTROL DE INVENTARIOS**\n");
                Console.WriteLine("1- Inicializar arreglos");
                Console.WriteLine("2- Ingresar Articulos");
                Console.WriteLine("3- Modificar Articulos");
                Console.WriteLine("4- Borrar Articulos");
                Console.WriteLine("5-Consultar Articulos");
                Console.WriteLine("6-Buscar codigo/nombre producto");
                Console.WriteLine("7- Salir\n");
                Console.WriteLine("Digite una opcion:");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion) 
                {
                    case 1 : articulos.inicializar_Arreglos(); break;
                    case 2 : articulos.ingresar_Productos(); break;
                    case 3 : articulos.modificar_Productos(); break;
                    case 4 : articulos.excluir_Productos(); break;
                    case 5 :articulos.consultar_Inventario(); break;
                    case 6 : articulos.Buscar_Articulo(); break;
                    case 7 : Console.WriteLine("Saliendo del Sistema"); break;
                    default :Console.WriteLine("***Opcion Incorrecta***"); break;

                   
                }



            } while (opcion != 7 ); //hasta la opcion sea diferente de 6 ==> true

        }
    }





}

