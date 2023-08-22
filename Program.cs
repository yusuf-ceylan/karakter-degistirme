using System;

namespace karakter_degistirme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İfadeyi giriniz: ");
            string input = Console.ReadLine();
            string output = "";

            string[] inputArray = input.Split(' ');

            foreach (var item in inputArray)
            {
                char[] charArray = new char[item.Length];

                for (int i = 0; i < item.Length; i++)
                {
                    charArray[i] = item[i];
                }
                char temp = charArray[0];
                charArray[0] = charArray[charArray.Length - 1];
                charArray[charArray.Length - 1] = temp;

                for (int i = 0; i < charArray.Length; i++)
                {
                    output += charArray[i];
                }

                output += " ";
            }

            Console.WriteLine(output);

        }
    }
}
