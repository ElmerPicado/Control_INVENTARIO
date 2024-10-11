using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_INVENTARIO
{
    internal class arreglos
    {

        public static void ejercicio()
        {
            int[] codigo = new int[10];
            string[] producto = new string[10];
            float[] costo = new float[10];
            int[] cantidad = new int[10];

            costo[2] = 200;
            costo[9] = 500;
            costo[3] = 600;
            costo[4] = 800;
            costo[5] = 300;

            codigo[2] = 50;
            codigo[9] = 100;

            producto[0] = "teclado";
            producto[2] = "mouse ";
            producto[9] = "pantalla";



            for (int i = 0; i < 10; i++)
            {
                if (codigo[i] == 0 && (costo[i] >=200 && costo[i] <= 300))
                {
                    Console.WriteLine($"Codigo: {codigo [i]} producto: {producto[i]} precio: {costo[i]} "); //interpolacion


                }
            }
        }
    }
}
