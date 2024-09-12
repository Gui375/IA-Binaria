using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src
{
    public class NeuronioArtificial
    {
        public Pesos pesos { get; private set; }

        public Entradas Entradas { get; private set; }

        public double o { get; private set; }

        public double taxaAprendizado { get; private set; }

        public NeuronioArtificial(double pTaxaAprendizado)
        {
            o = 0.0;
            taxaAprendizado = pTaxaAprendizado;
            pesos = new Pesos();
            taxaAprendizado = taxaAprendizado;

        }
        
        public void Treinar(List<Entradas> listaEntradas)
        {

            foreach (var item in listaEntradas)
            {
                o = item.Entrada1 * pesos.W1
                    + item.Entrada2 * pesos.W2;
                if (FuncaoClassificacao(o) != item.ResultadoEsperado)
                {
                    //recalcular os pesos
                    pesos.AtualizarPesos(
                        RecalcularNovoPeso(pesos.W1, CalcularErro(FuncaoClassificacao(o), item.ResultadoEsperado), item.Entrada1),
                        RecalcularNovoPeso(pesos.W2, CalcularErro(FuncaoClassificacao(o), item.ResultadoEsperado), item.Entrada2)
                     );
                }
                Printar(item.Entrada1,
                        item.Entrada2,
                        o,
                        CalcularErro(FuncaoClassificacao(o),
                        item.ResultadoEsperado),
                        pesos.W1,
                        pesos.W2,
                        FuncaoClassificacao(o),
                        item.ResultadoEsperado
                        );
            }
        }

        private int FuncaoClassificacao(double o)
        {
            if (o >= 0) return 1; return 0;
        }


        private int CalcularErro(int calculado,int esperado)
        {
            return calculado - esperado;
        }
        private double RecalcularNovoPeso(double pesoAntigo, int erro, double entrada)
        {
            return pesoAntigo + taxaAprendizado * erro * entrada;            
        }

        public void Printar(double entrada1, double entrada2, double resultado, int erro, double peso1, double peso2, int classificacao, int resEsperado)
        {
            Console.WriteLine($"\n\nEntrada 1 {entrada1}" +
                $"\nEntrada 2 {entrada2}" +
                $"\nResultado {resultado}" +
                $"\nErro {erro}" +
                $"\nPeso 1 {peso1}" +
                $"\nPeso 2 {peso2}" +
                $"\nClassificacao {classificacao}" +
                $"\nResultado esperado {resEsperado}");
        }
    }
}
