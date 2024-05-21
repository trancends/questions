namespace BankIndonesia;

class Program
{
    static void Main(string[] args)
    {
        Soal1(15);
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
}
