using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Console.WriteLine("digite o primeiro numero: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("qual opreração voce deseja fazer ? (+ - / *)");
            string opreração = Console.ReadLine();
            //declarando uma variavel para a futura condição;

            Console.WriteLine("digite outro numero para a operação: ");
            double num2 = double.Parse(Console.ReadLine());

            double resultado = 0;
            bool validador = true;


           switch (opreração){
                case "+":
                    resultado = num1 + num2;
                break;
                case "-":
                    resultado = num1 - num2;
                break;
                case "*":
                    resultado = num1 * num2;
                break;
                case "/":
                    resultado = num1 / num2;
                break;
                default:
                    Console.WriteLine("operação invalida");
                    validador = false;
                break;
           }

            if(validador == true){
           Console.WriteLine("o resultado é = "+resultado);
            }

        }//fim da Main
    }
}
