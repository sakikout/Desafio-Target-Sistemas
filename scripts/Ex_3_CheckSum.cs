using System;

namespace CheckSum {

    class Program {

        static int sum(int index){
            int soma = 0, k = 1;

            while ( k < index ){
                k = k + 1;
                soma = soma + k;
            }

            return soma;
        }


        static void Main (string[] args){
            Console.WriteLine($"Valor da variável soma: {sum(12)}");
            // a variável soma é para ter o valor de 77.

        }
    }

}