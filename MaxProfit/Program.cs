using System;

namespace MaxProfit
{
    public class Program
    {
        static int[] preciosArray = new int[] { 44, 30, 22, 32, 35, 30, 41, 38, 15 };
        // static int[] preciosArray = new int[] { 2, 3, 4, 2 };
        // static int[] preciosArray = new int[] {50, 30, 4, 2};

        static int mejorPrecio = 0;
        static int mejorDiaCompra;
        static int mejorDiaVenta;

        public static void Main(string[] args)
        {
            MaxProfit();

            Console.WriteLine("El precio de compra. {0}", preciosArray[mejorDiaCompra]);
            Console.WriteLine("Mejor precio venta. {0}", preciosArray[mejorDiaVenta]);
            Console.WriteLine("Este es el mejor precio. {0}", mejorPrecio);
                

            Console.ReadLine();
        }

        /// <summary>
        /// Metodo que permite iterar el arreglo, para no comprar el dia 2 y vender en dia 1
        /// </summary>
        public static void MaxProfit()
        {
            int counter = 0;

            // while para recorrer los elmentos de la matriz
            // Ciclo For para comparar el elmento con el indicador por el contador
            while (counter <= preciosArray.Length)
            {
                for (int i = 0; i < preciosArray.Length - (counter + 1); i++)
                {
                    var precio = preciosArray[i + 1] - preciosArray[counter];

                    if (precio > mejorPrecio)
                    {
                        mejorPrecio = preciosArray[i + 1] - preciosArray[counter];
                        mejorDiaCompra = counter;
                        mejorDiaVenta = i + 1;
                    }
                }
                counter++;
            }
        }
    }
}
