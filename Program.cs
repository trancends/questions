namespace BankIndonesia;
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
}
