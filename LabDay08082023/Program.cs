using System;

namespace LabDay08082023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zehmet olmasa 5 eded daxil edin.");
            Console.WriteLine("Ilk ededi daxil edin.");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("3ci ededi daxil edin.");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("3cu ededi daxil edin.");
            double n3 = double.Parse(Console.ReadLine());
            Console.WriteLine("4cu ededi daxil edin.");
            double n4 = double.Parse(Console.ReadLine());
            Console.WriteLine("5ci ededi daxil edin.");
            double n5 = double.Parse(Console.ReadLine());

            Console.WriteLine(Avarage(n1, n2, n3, n4, n5));


            Console.WriteLine("Zehmet olmasa telebelerin sayini qeyd edin.");
            int count = int.Parse(Console.ReadLine());
            Student[] studentArray = new Student[count];
            double maxPoint = 0;
            int column = 1;
            string columnn = "";
            for (int i = 0; i < studentArray.Length; i++)
            {
                if (column == 1 || column == 2 || column == 5 || column == 7 || column == 8)
                {
                    columnn = $"{column}ci";
                }
                else if (column == 3 || column == 4)
                {
                    columnn = "3cu";
                }
                studentArray[i] = new Student();
                Console.WriteLine($"Zehmet olmasa {columnn} telebenin adini yazin.");
                studentArray[i].Name = Console.ReadLine();
                Console.WriteLine($"Zehmet olmasa {columnn} telebenin soyadini yazin.");
                studentArray[i].Surname = Console.ReadLine();
                Console.WriteLine($"Zehmet olmasa {columnn} telebenin yasini yazin.");
                studentArray[i].Age = int.Parse(Console.ReadLine());
                Console.WriteLine($"Zehmet olmasa {columnn} telebenin balini yazin.");
                studentArray[i].Point = double.Parse(Console.ReadLine());
                column++;
                if (maxPoint <= studentArray[i].Point)
                {
                    maxPoint = studentArray[i].Point;
                }
            }

            Console.WriteLine(maxPoint);

            Console.WriteLine("---------------");


            Console.WriteLine("Zehmet olmasa 1 deyer qeyd edin");
            int result = int.Parse(Console.ReadLine());
            string lastResult = "";
            for (int i = 1; i <= result; i++)
            {
                lastResult += i;
                Console.WriteLine(lastResult);
            }



            string word = "Salam";
        w1: Console.WriteLine("Zehmet olmasa dogru sozu tapmaga calisin");

            string newWord = Console.ReadLine();

            if (word == newWord)
            {

                Console.WriteLine("Tebrik Edirik");
            }
            else
            {
                Console.WriteLine("Teessuf Edirik.");
                goto w1;
            }



            int a = 10;
            int b = 5;
            Console.WriteLine($" 95ci setir a: {a}, b: {b}");
            Console.WriteLine($"{2 * a}, {3 * b}");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"{3 * a}, {2 * b}");
            Console.WriteLine($" 101ci setir a: {a}, b: {b}");


            Console.WriteLine("Zehmet olmasa bir soz daxil edin.");
        c2: string newPalWord = Console.ReadLine().ToLower();
            string palWord = "";
            for (int i = newPalWord.Length - 1; i >= 0; i--)
            {
                palWord += newPalWord[i];
            }
            if (palWord.ToLower() == newPalWord)
            {
                Console.WriteLine("Palindrom");
                Console.WriteLine("Zehmet olmasa yeni soz daxil edin.");
                goto c2;
            }
            else
            {
                Console.WriteLine("Palindrom soz deyil , Zehmet olmasa yeni soz daxil edin.");
                goto c2;
            }
        }
        public static double Avarage(params double[] num)
        {
            double sum = 0;
            int count = 0;
            double avarage = 0;
            foreach (var item in num)
            {
                if (item % 2 != 0)
                {
                    sum += item;
                    count++;
                }
            }
            avarage = sum / count;
            return avarage;
        }

        public struct Student
        {
            public string Name;
            public string Surname;
            public int Age;
            public double Point;
        }


    }
}
