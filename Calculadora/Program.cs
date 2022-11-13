using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menu;

            Console.WriteLine("-------------CALCULADORA-----------");

            Console.WriteLine("Digite 1 para soma");
            Console.WriteLine("Digite 2 para subtração");
            Console.WriteLine("Digite 3 para multiplicação");
            Console.WriteLine("Digite 4 para divisão ");
            Console.WriteLine("Digite 5 para sair ");

            while (!(int.TryParse(Console.ReadLine(), out menu)))
            {
                Console.Write("Opção incorreta!!! ");
            }

            switch (menu)
            {
                case 1: soma(); break;
                case 2: subtração(); break;
                case 3: multiplicação(); break;
                case 4: divisão(); break;
                case 5: Console.WriteLine("Aplicação encerrada!!!"); break;
                default: Console.WriteLine("Opção inválida!!!"); break;

            }
            Console.ReadKey();
        }
        static void soma()
        {
            Console.Clear();
            Console.WriteLine("---------SOMA-------------- ");
            Console.Write("Digite primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite segundo número: ");
            int n2 = int.Parse(Console.ReadLine());

            int resultado = n1 + n2;
            Console.WriteLine($"A soma de {n1} + {n2} = {resultado}");
        }

        static void subtração()
        {
            Console.Clear();
            Console.WriteLine("---------SUBTRAÇÃO----------- ");
            Console.Write("Digite primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite segundo número: ");
            int n2 = int.Parse(Console.ReadLine());

            int resultado = n1 - n2;
            Console.WriteLine($"A subtração de {n1} - {n2} = {resultado}");
        }

        static void multiplicação()
        {
            Console.Clear();
            Console.WriteLine("---------MULTIPLICAÇÃO----------- ");
            Console.Write("Digite primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite segundo número: ");
            int n2 = int.Parse(Console.ReadLine());

            int resultado = n1 * n2;
            Console.WriteLine($"A multiplicação de {n1} * {n2} = {resultado}");
        }

        static void divisão()
        {
            Console.Clear();
            Console.WriteLine("---------DIVISÃO----------- ");
            Console.Write("Digite primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite segundo número: ");
            int n2 = int.Parse(Console.ReadLine());

            int resultado = n1 / n2;
            Console.WriteLine($"A divisão de {n1} / {n2} = {resultado}");
        }
    }
    
}
