using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Robson1
{
    internal class Basico : Calculo
    {
        public double X { protected get; set; }
        public double Y { protected get; set; }

        public void Somar()
        {
            R = X + Y;
            Console.WriteLine("Soma :" + R);
        }
        public void Subtrair()
        {
            R = Y - X;
            Console.WriteLine("Subtração :" + R);
        }
        public void Multiplicar()
        {
            R = X * Y;
            Console.WriteLine("Multiplicação :" + R);
        }
        public void Dividir()
        {
            R = X / Y;
            Console.WriteLine("Divisão :" + R);
        }

    }
}
