using System;

namespace HT4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Укажите размер массивов");
            int num = Convert.ToInt32(Console.ReadLine());
            string[] arr_even = new string[num];
            string[] arr_odd = new string[num];
            int c_even = 0;
            int c_odd = 0;
            ODDandEVEN();
            NumberToLetter();
            MostUppercase();

            void ODDandEVEN()
            {
                if (num > 0)
                {
                    Console.WriteLine("четные числа");
                    for (int i = 0; i < arr_even.Length; i++)
                    {
                        int a = new Random().Next(1, 26);
                        if (a % 2 == 0)
                        {
                            arr_even[i] = a.ToString();
                            Console.Write(arr_even[i] + " ");
                        }
                        else
                        {
                            i--;
                        }
                    }

                    Console.WriteLine(" ");
                    Console.WriteLine("нечетные числа");

                    for (int i = 0; i < arr_odd.Length; i++)
                    {
                        int b = new Random().Next(1, 26);
                        if (b % 2 == 1)
                        {
                            arr_odd[i] = b.ToString();
                            Console.Write(arr_odd[i] + " ");
                        }
                        else
                        {
                            i--;
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Массив не может состоять из {num} єлементов");
                }
            }

            void NumberToLetter()
            {
                char[] alphabet = new char[26];
                int count_char = 0;
                char count = ' ';
                int result = 0;

                for (int i = 97; i <= 122; i++)
                {
                    if (count_char < 26)
                    {
                        alphabet[count_char] = (char)i;
                    }

                    count_char++;
                }

                Console.WriteLine(" ");
                Console.WriteLine("Новый массив из букв для четных чисел:");
                for (int i = 0; i < arr_even.Length; i++)
                {
                    result = Convert.ToInt32(arr_even[i]) - 1;
                    count = alphabet[result];
                    arr_even[i] = count.ToString();
                    if (count == 'd')
                    {
                        arr_even[i] = arr_even[i].Replace('d', 'D');
                        c_even++;
                    }
                    else if (count == 'h')
                    {
                        arr_even[i] = arr_even[i].Replace('h', 'H');
                        c_even++;
                    }
                    else if (count == 'j')
                    {
                        arr_even[i] = arr_even[i].Replace('j', 'J');
                        c_even++;
                    }

                    Console.Write(arr_even[i] + " ");
                }

                Console.WriteLine(" ");
                Console.WriteLine("Новый массив из букв для нечетных чисел:");
                for (int i = 0; i < arr_odd.Length; i++)
                {
                    result = Convert.ToInt32(arr_odd[i]) - 1;
                    count = alphabet[result];
                    arr_odd[i] = count.ToString();
                    if (count == 'a')
                    {
                        arr_odd[i] = arr_odd[i].Replace('a', 'A');
                        c_odd++;
                    }
                    else if (count == 'e')
                    {
                        arr_odd[i] = arr_odd[i].Replace('e', 'E');
                        c_odd++;
                    }
                    else if (count == 'i')
                    {
                        arr_odd[i] = arr_odd[i].Replace('i', 'I');
                        c_odd++;
                    }

                    Console.Write(arr_odd[i] + " ");
                }
            }

            void MostUppercase()
            {
                Console.WriteLine(" ");
                Console.WriteLine("Больше всего букв в верхнем регистре в этом массиве:");
                for (int i = 0; i < num; i++)
                {
                    if (c_even > c_odd)
                    {
                        Console.Write(arr_even[i] + " ");
                    }
                    else if (c_even < c_odd)
                    {
                        Console.Write(arr_odd[i] + " ");
                    }
                    else
                    {
                        Console.Write("Одинаково");
                    }
                }
            }
        }
    }
}
