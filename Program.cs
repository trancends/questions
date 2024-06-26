﻿namespace BankIndonesia;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        Soal1(15);
        Console.WriteLine();
        Soal2a(5);
        Console.WriteLine();
        Soal2b(5);
        Console.WriteLine();
        Soal2c(5);
        Console.WriteLine();
        Soal2d(5);
        Console.WriteLine();
        var sortedN = Soal3([12, 9, 13, 6, 10, 4, 7, 2]);
        Console.WriteLine(string.Join(" ", sortedN));
        Console.WriteLine();
    }

    static void Soal1(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0)
            {
                Console.Write("OK ");
            }
            else if (i % 4 == 0)
            {
                Console.Write("YES ");
            }
            else if (i % 3 == 0 && i % 4 == 0)
            {
                Console.Write("OKYES ");
            }
            else
            {
                Console.Write(i + " ");
            }
        }
    }

    static void Soal2a(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }

    static void Soal2b(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j >= 1; j--)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }

    static void Soal2c(int n)
    {
        var lists = new List<List<int>>();

        for (int i = 1; i <= n; i++)
        {
            var list = new List<int>();

            for (int j = 1; j <= i; j++)
            {
                if (i == 1)
                {
                    list.Add(j);
                    Console.Write(list[j - 1]);
                }
                else
                {
                    if (j == 1)
                    {
                        list.Add(lists[^1][^1] + 1);
                    }
                    else
                    {
                        if (list.Contains(5))
                        {
                            list.Add(list[^1] - 1);
                        }
                        else
                        {
                            list.Add(list[^1] + 1);
                        }
                    }
                    Console.Write(list[j - 1]);
                }
            }

            lists.Add(list);
            Console.WriteLine();
        }
    }

    static void Soal2d(int n)
    {
        var lists = new List<List<int>>();
        for (int i = 1; i <= n; i++)
        {
            var list = new List<int>();
            // Console.WriteLine("i: " + i);
            // Console.WriteLine("Count: " + lists.Count);

            for (int j = 1; j <= n; j++)
            {
                if (i == 1)
                {
                    if (j == 1)
                    {
                        list.Add(j);
                    }
                    else
                    {
                        if (list[^1] % 2 == 0)
                        {
                            list.Add(list[^1] + 1);
                        }
                        else
                        {
                            list.Add(list[^1] + 9);
                        }
                    }
                }
                else
                {
                    if (lists[0][j - 1] % 2 == 0)
                    {
                        list.Add(lists[^1][j - 1] - 1);
                    }
                    else
                    {
                        list.Add(lists[^1][j - 1] + 1);
                    }
                }
                Console.Write(list[j - 1] + " ");
            }
            lists.Add(list);
            Console.WriteLine();
        }
    }

    static List<int> Soal3(List<int> n)
    {
        var filteredN = new List<int>();

        foreach (var num in n)
        {
            if (num % 3 != 0)
            {
                filteredN.Add(num);
            }
        }

        // sort filteredN ascending
        for (int i = 0; i < filteredN.Count - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < filteredN.Count; j++)
            {
                if (filteredN[j] < filteredN[minIndex])
                {
                    minIndex = j;
                }
            }
            (filteredN[minIndex], filteredN[i]) = (filteredN[i], filteredN[minIndex]);
        }

        return filteredN;
    }
}
