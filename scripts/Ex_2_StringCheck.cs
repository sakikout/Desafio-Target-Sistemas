using System;

namespace StringCheck {

    class Program {

        static bool isLetterInString(char letter, string text){
            char letterLowerCase = letter.ToLower();
            string textLowerCase = text.ToLower();

            foreach (char character in text){
                if (character == letter)
                    return true;
            }

            return false;
        }

        static int timesLetterInString(char letter, string text){
            char letterLowerCase = letter.ToLower();
            string textLowerCase = text.ToLower();
            int count = 0;

            foreach (char character in text){
                if (character == letterLowerCase)
                    count += 1;
            }

            return count;
        }


        static void Main (string[] args){
            Console.WriteLine("Digite uma frase: ");
            int stringInput = int.Parse(Console.ReadLine());
            char letter = 'a';

            if (isLetterInString(letter, stringInput)){
                Console.WriteLine($"A letra {letter} apareceu {timesLetterInString(letter, stringInput)} em '{stringInput}'");
            } else {
                Console.WriteLine($"A letra {letter} não existe em '{stringInput}'");
            }

           
        }
    }

}