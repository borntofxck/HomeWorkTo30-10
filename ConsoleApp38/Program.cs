using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string str = Console.ReadLine();
            string s1 = ("один");
            StringBuilder s2 = new StringBuilder(s1.ToString());
            StringBuilder s3 = new StringBuilder();
            string t = ("строка");
            int y = 0;
            int x = 0;
            double g = 0;


            //Stolbik(str);
            //FiveSymb(str);
            //ChisloSlov(str);
            //Glasnie(str, y);
            //KolvoZvezdAndPlusov(str, ref y, ref x);
            //ProcentA(str, ref y);
            //IzvlechenyeSymb(str);
            //Spaces(str, y);
            //PositionOfFirsrEnter(str);
            //Symbol3(str);
            //SymbolI(str);
            //ZamenaMenshegoSlova(s1, t);
            //ChisloSimRovnoZvezd(s2);
            //PlusikandMinus(s2);
            //Limiti4();
            //NewWordNaoborot(s2, t);
            //NewWordNechet(s1, s2);
            //GetSymbols(str);
            //FromLastToFirst( str)



            Console.ReadKey();
        }

        private static void Stolbik(string str)
        {
            foreach (char item in str)
            {
                Console.WriteLine(item);
            }
        }

        private static void FiveSymb(string str)
        {
            bool falseresult = false;


            for (int i = 0; i < str.Length - 4; i++)
            {
                string substr = str.Substring(i, 5);
                if (substr.Distinct().Count() == 1)
                {
                    falseresult = true;
                    break;
                }
            }
        }

        /// <summary>
        /// число слов в предложении
        /// </summary>
        /// <param name="str"></param>
        private static void ChisloSlov(string str)
        {
            string[] words = str.Split(' ');


            if (words.Length > 3)
            {
                Console.WriteLine("Число слов в предложении превышает три.");
            }
            else
            {
                Console.WriteLine("В предложении менее трех слов.");
            }
        }

        /// <summary>
        /// находит колво гласных в строке
        /// </summary>
        /// <param name="str"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private static int Glasnie(string str, int y)
        {
            foreach (char c in str)
                if (c == 'а' || c == 'е' || c == 'ё' || c == 'и' || c == 'о' || c == 'э' || c == 'ю' || c == 'я' || c == 'ы' || c == 'у')
                {
                    y++;
                }

            Console.WriteLine($"колличество гласных букв={y}");
            return y;
        }

        private static void KolvoZvezdAndPlusov(string str, ref int y, ref int x)
        {
            foreach (char c in str)
                if (c == '+')
                {
                    y++;
                }
            foreach (char v in str)
                if (v == '*')
                {
                    x++;
                }
            Console.WriteLine($"колличество * в предложении= {x}");
            Console.WriteLine($"колличество + в предложении= {y}");
        }

        /// <summary>
        /// процент буквы а в строке
        /// </summary>
        /// <param name="str"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private static double ProcentA(string str, ref int y)
        {
            double g;
            foreach (char c in str)
                if (c == 'а')
                {
                    y++;
                }

            g = (100 / str.Length) * y;
            Console.WriteLine($"{g}%");
            return g;
        }

        /// <summary>
        /// вывести первый второй пятый шестой символ
        /// </summary>
        /// <param name="str"></param>
        private static void IzvlechenyeSymb(string str)
        {
            int z = 2;
            for (int i = 0; i < str.Length; i += z)
            {
                if (i % z == 0)
                {
                    Console.Write(str[i]);
                }
            }
        }

        /// <summary>
        /// количество пробелов в слове
        /// </summary>
        /// <param name="str"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private static int Spaces(string str, int y)
        {
            foreach (char c in str)
                if (c == ' ')
                {
                    y++;

                }

            Console.WriteLine(y);
            return y;
        }

        /// <summary>
        /// найти первую позицию заданого символа
        /// </summary>
        /// <param name="str"></param>
        private static void PositionOfFirsrEnter(string str)
        {
            int indexA = str.IndexOf('а');
            int indexO = str.IndexOf('о');

            Console.WriteLine($"Позиция символа 'a': {indexA}");
            Console.WriteLine($"Позиция символа 'o': {indexO}");
        }

        /// <summary>
        /// программа выводит каждый 3 символ предложения
        /// </summary>
        /// <param name="str"></param>
        private static void Symbol3(string str)
        {
            for (int i = 2; i < str.Length; i += 3)
            {
                Console.Write(str[i]);
            }
        }

        /// <summary>
        /// найти и вывести букву и которая встречается в предложении
        /// </summary>
        /// <param name="str"></param>
        private static void SymbolI(string str)
        {
            foreach (char c in str)
                if (c == 'и')
                {
                    Console.WriteLine(c);
                }
        }
        /// <summary>
        /// Даны два слова (первое длиннее второго). Заменить во втором слове соответствующее количество символов на первое слово.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        private static string ZamenaMenshegoSlova(string s1, string t)
        {
            if (s1.Length > t.Length)
            {
                t = t.Insert(t.Length, s1);
            }
            else if (s1.Length < t.Length)
            {
                t = s1 + t.Substring(s1.Length);
            }

            Console.WriteLine(t);
            return t;
        }
        /// <summary>
        /// добавить в начаале и конце * равные колву символов в слове
        /// </summary>
        /// <param name="s2"></param>
        private static void ChisloSimRovnoZvezd(StringBuilder s2)
        {
            s2.Insert(0, "*", s2.Length);
            s2.Insert(s2.Length, "*", s2.Length - s2.Length / 2);

            Console.WriteLine(s2);
        }

        /// <summary>
        /// добавление плюсов в начале и минусов в конце
        /// </summary>
        /// <param name="s2"></param>
        private static void PlusikandMinus(StringBuilder s2)
        {
            string plus = ("-----");

            s2.Insert(0, "+", 4);
            s2.Append(plus);
            Console.WriteLine(s2.ToString());
        }

        /// <summary>
        /// создание строки из символа
        /// </summary>
        private static void Limiti4()
        {
            string symbol = Console.ReadLine();
            string strlim = Console.ReadLine();
            int lim = int.Parse(strlim);
            for (int i = 0; i <= lim; i++)
            {
                Console.Write(symbol);

            }
        }

        /// <summary>
        /// создание слова из слова наоборот  
        /// </summary>
        /// <param name="s2"></param>
        /// <param name="t"></param>
        private static void NewWordNaoborot(StringBuilder s2, string t)
        {
            for (int i = t.Length - 1; i >= 0; i--)
            {
                s2.Append(t[i]);


            }
            Console.WriteLine(s2);
        }

        /// <summary>
        /// создание новой строки из нечетных символов
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        private static string NewWordNechet(string s1, string s2)
        {
            for (int i = 0; i < s1.Length; i++)
            {
                if (i % 2 == 0)
                {
                    s2 += s1[i];
                }
            }
            Console.WriteLine(s2);
            return s2;
        }

        /// <summary>
        /// печать символов столбиком
        /// </summary>
        /// <param name="str"></param>
        private static void GetSymbols(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }

        }
        /// <summary>
        /// печать слова наоборот 
        /// </summary>
        /// <param name="str"></param>
        private static void FromLastToFirst(string str)
        {
            StringBuilder s2 = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                s2.Append(str[i]);


            }
            Console.WriteLine(s2);

        }

    }
}