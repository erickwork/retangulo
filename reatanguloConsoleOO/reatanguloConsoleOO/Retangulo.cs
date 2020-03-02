using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetanguloConsoleOO
{
    class Retangulo
    {
        //declaração das variaveis de instacia / atributos
        //utilizar o ceonceito OO de ENCAPSULAMENTO
        private double ladoA;
        private double ladoB;
        private double perimetro;
        private double area;

        //metódo construtor
        //inicializar as variaveis de instacia com valores efault (regra de negocio)
        public Retangulo()
        {
            this.ladoA = 0;
            this.ladoB = 0;
            this.perimetro = 0;
            this.area = 0;

        }
        public Retangulo(double ladoA, double ladoB)
        {
            this.ladoA = 0;
            this.ladoB = 0;
            this.perimetro = 0;
            this.area = 0;

        }

        //metodos acessores/modoficadores -> Set´´s/get´s
        public void setLadoA(double ladoA)
        {
            this.ladoA = ladoA;
        }
        public double getLadoA()
        {
            return ladoA;
        }


        public void setLadoB(double ladoB)
        {
            this.ladoB = ladoB;
        }
        public double getLadoB()
        {
            return ladoB;
        }

        //para as variaveis perimetro e area somente metodos acessores get´s
        public double getPerimetro()
        {
            return perimetro;
        }
        public double getArea()
        {
            return area;
        }

        //metodos de processamento
        public void calcularPerimetro()
        {
            perimetro = ladoA * 2 + ladoB * 2;
        }
        public void calcularArea()
        {
            area = ladoA * ladoB;
        }


     
    }
}
