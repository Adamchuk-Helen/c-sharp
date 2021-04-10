using System;
namespace HW2_1
{
    namespace HW2._1
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.OutputEncoding = System.Text.Encoding.Unicode;

                Console.WriteLine("Введіть літеру латинського алфавіту");
                char ch = (char)Console.Read();
                char ch2 = ' ';
                if (ch > 'a' && ch < 'z')
                {
                    ch2 = char.ToUpper(ch);
                    Console.WriteLine($"{ch} нижнього регістру = {ch2} верхнього регістру");
                }
                else if (ch > 'A' && ch < 'Z')
                {
                    ch2 = char.ToLower(ch);
                    Console.WriteLine($"{ch} верхнього регістру = {ch2} нижнього регістру");
                }
                else
                {
                    Console.WriteLine("Не вірно введені дані");
                }
            }
        }
    }
}
