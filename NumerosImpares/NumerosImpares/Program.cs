using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            //long? a = 0, b = 10; //Caso 1 Números Positivos
            //long? a = -10, b = 0; //Caso 2 Números Negativos
            //long? a = 'a', b = 'Z'; //Caso 3 Carácteres, Toma la posición del caracter en ASCII
            //long? a = 0, b = null; //Caso 4 Si un valor es nulo, no se puede hacer la busqueda
            //long? a = -100, b = 100; //Caso 5 Conbinación de números positivos y negativos
            //long? a = 0, b = '\\'; //Caso 6 Combinación de números y carácteres
            //long? a = 5000, b = 1000; //Caso 7
            //long? a = -999, b = -999; //Caso 8
            //long? a = 100, b = 100; //Caso 9
            long? a = 0, b = 0; // Caso 10 Insertados desde consola 

            if (a == 0 && b == 0)
            {
                do
                {
                    Console.WriteLine("Ingresa el Primer Numero: ");
                    a = ConvertirAEntero(Console.ReadLine());
                } while (a == null);

                do
                {
                    Console.WriteLine("Ingresa el Segundo Numero: ");
                    b = ConvertirAEntero(Console.ReadLine());
                } while (b == null);
            }

            if (a != null && b != null)
                BuscarNumerosImpares(a, b);
            else
                Console.WriteLine("No se pueden buscar los números impares, uno o ambos números son nulos ");
            Console.Read();
        }

        public static void BuscarNumerosImpares(long? a, long? b)
        {
            long? i;

            if (b < a)
            {
                long? Aux = a;
                a = b;
                b = Aux;
            }

            for (i = a; i <= b; i++)
                if ((i % 2) != 0)
                    Console.Write(i.ToString() + "\t");
        }

        public static long? ConvertirAEntero(string numero)
        {
            long? n;
            try
            {
                n = Convert.ToInt64(numero);
            }
            catch
            {
                n = null;
                Console.WriteLine("El valor ingresado no es un número Entero \n");
            }
            return n;
        }
    }
}
