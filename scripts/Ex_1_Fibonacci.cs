using System;

namespace FibonacciScript {

    class Program {

        static bool isFromFibonacciSequence(int num){
            int a = 0, b = 0;
            if (num == 0)
                return true;
            else if (num == 1)
                return true;
            else
                int c = a + b;
                while ( num_check <= num){
                    if (c == num)
                        return true;
                    a = b;
                    b = c;
                    c = a + b;
                }
            return false;
        }


        static void Main (string[] args){
            Console.WriteLine("----- SEQUENCIA DE FIBONACCI ------");
            Console.WriteLine("Digite um numero para verificar ele pertence a sequência: ");
            int num = int.Parse(Console.ReadLine());

            if (isFromFibonacciSequence(num)){
                Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
            } else {
                Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
            }
        }
    }

}