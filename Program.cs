using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParesImparesAte20ComDecisao
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("digite 1 para numeros impares ou 2 para numeros pares.");
            int numero = int.Parse(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    while (numero <= 20)
                    {
                        Console.WriteLine(numero);
                        numero += 2;
                        
                    }
                    break;
                case 2:
                    while (numero <= 20)
                    {
                        Console.WriteLine(numero);
                        numero += 2;
                        
                    }
                    break;
                default:
                    Console.WriteLine("Resposta Incorreta.");
                    break;
            }

          

           

            Console.ReadKey();
        }
    }
}
