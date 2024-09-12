using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src
{
    public class Pesos
    {
        public Pesos(double w1, double w2)
        {
            W1 = w1;
            W2 = w2;
        }

        public Pesos()
        {
            GerarAleatorio(0, 10);
        }

        public double W1 { get; private set; }
        public double W2 { get; private set; }

        private Random random = new Random();

        public void AtualizarPesos(double novoPeso1, double novoPeso2)
        {
            W1 = novoPeso1;
            W2 = novoPeso2;
        }


        private double GerarAleatorio(int minimo, int maximo)
        {
            return random.Next(minimo, maximo);
        }

    }
}
