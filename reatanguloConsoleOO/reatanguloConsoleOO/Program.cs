using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RetanguloConsoleOO
{
    class program
    {
        static void Main(string[] args)
        {
            //declarar objeto retangulo
            Retangulo retangulo1 = new Retangulo();

            //apresentação da solução
            Console.WriteLine("RETANGULO: calcular perimetro e area");
            Console.WriteLine();

            //entrada de dados
            Console.WriteLine("Entre lado A");
            retangulo1.setLadoA(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Entre lado B");
            retangulo1.setLadoB(Convert.ToDouble(Console.ReadLine()));

            //processamento
            retangulo1.calcularPerimetro();
            retangulo1.calcularArea();

            //saida de dados
            Console.WriteLine();
            Console.WriteLine(" === RETANGULO ===");
            Console.WriteLine("Lado A    =" + retangulo1.getLadoA());
            Console.WriteLine("Lado B    =" + retangulo1.getLadoB());
            Console.WriteLine("Perimetro =" + retangulo1.getPerimetro());
            Console.WriteLine("Area      =" + retangulo1.getArea());

            //para tela, para nao fechar console
            Console.WriteLine("Tecle<EnTER> para continuar");
            Console.ReadKey();

        }
    }
}
