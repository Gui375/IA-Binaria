// See https://aka.ms/new-console-template for more information
using ConsoleApp1.src;

//Console.WriteLine("Hello, World!");
NeuronioArtificial neuronioArtificial = new NeuronioArtificial(0.5);
List<Entradas> list = new List<Entradas>();

for (int i = 0; i <= 1; i++)
{
    Console.WriteLine($"Entrada {i+ 1} ");
    double entrada1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Entrada {i + 2} ");
    double entrada2 = Convert.ToDouble( Console.ReadLine());
    Console.WriteLine($"Resultado esperado");
    int resultado = Convert.ToInt32(Console.ReadLine());

    Entradas entradas = new ( entrada1, entrada2 , resultado);
    list.Add(entradas);
}

neuronioArtificial.Treinar(list);

//criam a lista de entrada e treinar ele com metodo abaixo
//neuronioArtificial.Treinar();

//De perguntar pra ele


//O que precisa ser feito

//Gerar os pesos aleatorios
//Funcao de calcular o erro
//Funcao de calcular os novos pesos
//Funcao de obter resposta no metodo Perguntar
//Ajustar program.cs o treinamento e testar