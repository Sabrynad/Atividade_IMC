using System;

namespace Projeto_IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual o seu nome? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual sua idade? ");
            string idade = Console.ReadLine();

            Console.WriteLine("Insira seu peso: ");
            float peso = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira a sua altura; ");
            float altura = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(nome);
            Console.WriteLine($"Sua idade é:  {idade}");
            Console.WriteLine("Seu peso é: " + peso);
            Console.WriteLine($"Sua altura é: {altura}");

            float result = peso / (altura * altura);

            if (result < 18)
            {
                Console.WriteLine("Está abaixo do peso");
            }
            else if (result > 18 && result < 24)
            {
                Console.WriteLine("Está na média de peso");
            }
            else if (result > 25 && result < 29)
            {
                Console.WriteLine("Está no sobrepeso");
            }
            else if (result > 30 && result < 39)
            {
                Console.WriteLine("Está em estado de obesidade");
            }
            else if (result > 40)
            {
                Console.WriteLine("Estado de obesidade grave");
            }
        }
    }
}
