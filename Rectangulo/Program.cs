using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRectangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            Console.WriteLine("Ingrese su nombre:");
            persona.Nombres = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido:");
            persona.Apellidos = Console.ReadLine();

            string nombresCompletos;
            nombresCompletos = persona.DevolverNombresCompletos();
            Console.WriteLine("__________________________");
            Console.WriteLine("     Nombres completos    ");
            Console.WriteLine("__________________________");
            Console.WriteLine(nombresCompletos);
            Console.WriteLine("__________________________");



            Rectangulo rectangulo = new Rectangulo();
            // Coordenada 1 (1;3)

            Console.WriteLine("Ingrese coordenada X1:");
            rectangulo.x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese coordenada Y1:");
            rectangulo.y1 = Convert.ToDouble(Console.ReadLine());

            // Coordenada 2 (4;0)
            Console.WriteLine("Ingrese coordenada X2:");
            rectangulo.x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese coordenada Y2:");
            rectangulo.y2 = Convert.ToDouble(Console.ReadLine());

            // Coordenada 3 (10;5)
            Console.WriteLine("Ingrese coordenada X3:");
            rectangulo.x3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese coordenada Y3:");
            rectangulo.y3 = Convert.ToDouble(Console.ReadLine());

            // Coordenada 4 (6.8)
            Console.WriteLine("Ingrese coordenada X4:");
            rectangulo.x4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese coordenada Y4:");
            rectangulo.y4 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Area redondeada del rectangulo:");
            Console.WriteLine(rectangulo.Area(rectangulo.x1, rectangulo.y1, rectangulo.x2, rectangulo.y2, rectangulo.x3, rectangulo.y3, rectangulo.x4, rectangulo.y4));
            Console.WriteLine("Perimetro redondeada del rectangulo:");
            Console.WriteLine(rectangulo.Perimetro(rectangulo.x1, rectangulo.y1, rectangulo.x2, rectangulo.y2, rectangulo.x3, rectangulo.y3, rectangulo.x4, rectangulo.y4));
            Console.Read();


        }
    }
}
