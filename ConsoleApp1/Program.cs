using System;
using System.Globalization;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite a nota do primeiro semestre");
            double P = double.Parse(Console.ReadLine()!,CultureInfo.InvariantCulture!);
            Console.WriteLine("Digite a nota do segundo semestre");
            double M = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture!);
            double notaFinal = P + M;

            Console.WriteLine("O Seu resultado final foi: " + notaFinal.ToString("F1",CultureInfo.InvariantCulture) + " pontos");   
            
            if (notaFinal >= 60) {
                Console.WriteLine("Você foi aprovado!");
            } else {
                Console.WriteLine("voce foi reprovado!"); 
            }


            

            Console.ReadLine();
        }
    }
}