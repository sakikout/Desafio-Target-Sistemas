using System;

namespace FindLogic {

    class Program {

        static int a(int index){
            // retorna o número ímpar no índice fornecido.
            int total = 0, num = 0;
            while (total != index){
                if (total % 2 != 0){
                    num = total;
                }
                total += 1;
            }

            return num;
        }

         static int b(int index){
            // retorna número elevado à base 2 no índice fornecido.
            return Math.Pow(2, index);
        }

        static int c(int index){
            // retorna a soma dos números ímpares até o índice fornecido.
            int base_num = 0, i = 0;
            
            while (i < index){
                base_num += a(i);
            }

            return base_num;
        }

        static int d(int index){
            // multiplica o índice elevado ao quadrado por 4.
            // 4 / 4 = 1²
            // 16 / 4 = 4 = 2²
            // 36 / 4 = 9 = 3²
            // 64 / 4 = 16 = 4²
            // 100 / 4 = 25 = 5²

            int base_num = 4, i = 1, pow_result = 0;
            
            while (i <= index){
                pow_result = Math.Pow(index, 2);
                base_num = pow_result * 4;
                i += 1;
            }

            return base_num;
        }

        static int e(int index){
            // retorna o próximo número da sequência de Fibonacci no índice fornecido.
            if (num == 0)
                return 1;
            else if (num == 1)
                return 1;
            else 
                return e(index - 1) + e(index - 2);
        }

        static int f(int index){
            // todos os números começam com a letra d.
            int num_base = 200;
            if (index == 8){
                return num_base;
            }

            if (index < 108 && index > 8){
                for (int i = 8; i < 108; i++ ){
                    num_base += 1;

                    if (i == index){
                        break;
                    }
                }
            } else {
                num_base = -1;
            }

            return num_base;
        }

        static void Main (string[] args){
            Console.WriteLine("Próximo elemento para as sequências: ");
            Console.WriteLine("A: 1, 3, 5, 7, __");
            Console.WriteLine($"R: {a(5)}");
            Console.WriteLine("B: 2, 4, 8, 16, 32, 64, __");
            Console.WriteLine($"R: {b(7)}");
            Console.WriteLine("C: 0, 1, 4, 9, 16, 25, 36, __");
            Console.WriteLine($"R: {b(8)}");         
            Console.WriteLine("D: 4, 16, 36, 64, __");
            Console.WriteLine($"R: {d(5)}");
            Console.WriteLine("E: 1, 1, 2, 3, 5, 8, __");
            Console.WriteLine($"R: {e(5)}");
            Console.WriteLine("F: 2, 10, 12, 16, 17, 18, 19, __");
            Console.WriteLine($"R: {f(8)}");

        }
    }

}