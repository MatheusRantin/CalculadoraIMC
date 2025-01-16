using System;

namespace CalculadoraPeso
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Preencha as informações abaixo");
            Console.WriteLine("Nome: ");
            string inputNome = Console.ReadLine();
            Console.WriteLine("Gênero: ");
            string inputGen = Console.ReadLine();
            Console.WriteLine("Idade: ");
            int inputIdade= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Peso: ");
            double inputPeso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Altura: ");
            double inputAltura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(inputPeso);
            Console.WriteLine(inputAltura);
            Pessoa pessoa = new Pessoa(inputNome, inputGen, inputIdade, inputPeso, inputAltura);
        }
    }
}