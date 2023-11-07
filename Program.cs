using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
        class Program
        {
            static void Main(string[] args)
            {
                Console.Clear();
                Console.WriteLine("Digite qual operação deseja realizar: ");
                Console.WriteLine("");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Divisão");
                Console.WriteLine("4 - Multiplicação");
                Console.WriteLine("");
                Console.WriteLine("Selecione uma opção: ");
                short res = short.Parse(Console.ReadLine());
                       
                Menu();
            }
            static void Menu()
            {

            }
            static void Sum()
            {
                Console.Clear();

                Console.WriteLine("Digite o primeiro numero: ");
                double value1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o segundo numero: ");
                double value2 = Convert.ToDouble(Console.ReadLine());

                double resultado = value1 + value2;
                Console.WriteLine("*********************************************");
                Console.WriteLine($"Seu resultado é {resultado}");
                Menu();
            }
            static void Subtract()
            {
                Console.Clear();

                Console.WriteLine("Digite o primeiro numero: ");
                double value1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o segundo numero: ");
                double value2 = Convert.ToDouble(Console.ReadLine());

                double resultado = value1 - value2;
                Console.WriteLine("*********************************************");
                Console.WriteLine($"Seu resultado é {resultado}");
            }
            static void Division()
            {
                Console.Clear();

                Console.WriteLine("Digite o primeiro numero: ");
                double value1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o segundo numero: ");
                double value2 = Convert.ToDouble(Console.ReadLine());

                double resultado = value1 / value2;
                Console.WriteLine("*********************************************");
                Console.WriteLine($"Seu resultado é {resultado}");
                Menu();
            }
            static void Multiply()
            {
                Console.Clear();

                Console.WriteLine("Digite o primeiro numero: ");
                double value1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o segundo numero: ");
                double value2 = Convert.ToDouble(Console.ReadLine());

                double resultado = value1 * value2;
                Console.WriteLine("*********************************************");
                Console.WriteLine($"Seu resultado é {resultado}");
                Menu();
            }
        }
    }
