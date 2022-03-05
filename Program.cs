using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicacao");
            Console.WriteLine("5 - Sair");

            Console.WriteLine();
            Console.Write("Escolha a opção deseja: ");

            short opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Console.WriteLine("Obrigado por utilizar nossos serviços!"); System.Environment.Exit(0); break;
                default: Menu(); break;
            }

        }
        static void Soma()
        {

            Console.Clear();
            Console.Write("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine();

            double resultado = v1 + v2;

            Console.WriteLine($"O resultado da soma = {resultado}");

            Console.ReadKey();
            Menu();

        }
        static void Subtracao()
        {
            Console.Clear();
            Console.Write("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine();

            double resultado = v1 - v2;

            Console.WriteLine($"O resultado da subtração =  {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {

            Console.Clear();
            Console.Write("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine();

            double resultado = v1 / v2;

            Console.WriteLine($"Resultado da divisão = {resultado}");

            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {

            Console.Clear();
            Console.Write("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine();

            double resultado = v1 * v2;

            Console.WriteLine($"Resultado da multiplicacao = {resultado}");

            Console.ReadKey();
            Menu();
        }
    }
}
