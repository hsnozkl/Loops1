namespace Loops1;

class Program
{
    static void Main(string[] args)
    {
        //Ekranda girilen sayiya kadar olan tek sayilari ekrana yazdir.
        Console.WriteLine("Lutfen bir sayi giriniz!");
        int sayac = int.Parse(Console.ReadLine());
        for (int i = 1; i <= sayac; i++)
        {
            if(i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
        //1 ile 1000 arasındaki tek ve çift sayilarin toplamini ekrana bastir.
        int tekToplam = 0;
        int ciftToplam = 0;
        for (int i = 1; i <= 1000; i++)
        {
            if(i % 2 != 0)
                tekToplam += i; //tekToplam = tekToplam + i;
            else
                ciftToplam += i; //ciftToplam = ciftToplam + i;
        }
        Console.WriteLine("Tek sayilarin toplami: " + tekToplam);
        Console.WriteLine("Cift sayilarin toplami: " + ciftToplam);
        Console.WriteLine("Tek ve Cift sayilarin toplami: " + (tekToplam+ciftToplam));

        // break, continue
        for (int i = 1; i < 10; i++)
        {
            if(i == 4)
                break;
            Console.WriteLine(i);
        }

        for (int i = 1; i < 10; i++)
        {
            if(i == 4)
                continue;
            Console.WriteLine(i);
        }
    }
}
