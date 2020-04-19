using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaPerimetroPoligonoRegular
{
    class Program
    {
        // Funcion que calcula perimetro de poligono regular
        static float PerimetroPoligono(float lad, float cant)
        {
            float per = 0.0f;

            per = lad * cant;

            return per;
        }

        // Funcion principal
        static void Main(string[] args)
        {
            float lado = 0.0f, cantidad = 0.0f, perimetro = 0.0f;

            Console.Write("Escriba el tamaño del lado: ");
            lado = Convert.ToSingle(Console.ReadLine());

            Console.Write("Escriba la cantidad de lados:");
            cantidad = Convert.ToSingle(Console.ReadLine());

            perimetro = PerimetroPoligono(lado, cantidad);

            Console.WriteLine("El perimetro del poligono es: {0}", perimetro);

            Console.ReadKey();

        }
    }
}
