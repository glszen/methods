//Geriye Değer Döndürmeyen Bir void metot:
using System.Reflection.Metadata;

class Song
{
    static void song()
    {
        Main();
    }

    static void Main()
    {
        Console.WriteLine("I, I live among the creatures of the night");
    }
}

// Geriye Tamsayı Döndüren Bir metot

class Mod
{
    static int number(int x)
    {

        return x;

    }

    static void Main()
    {
        Random rnd = new Random();
        int y = rnd.Next(1, 10); //1 ile 10 arasında rastgele sayı üretiyoruz.
        int result = number(y % 2);
        Console.WriteLine(y);
    }
}

//Parametre Alan ve Geriye Değer Döndüren Bir Metot

class Times
{
    static int Values(int s1, int s2)
    {
        return s1 * s2;
    }

    static void Main()
    {
        int result = Values(3, 5);
        Console.WriteLine(result);
    }
}

//Parametre Alan ve Geriye Değer Döndürmeyen bir Metot

class Words
{
    static void Letter(string color)
    {
        Console.WriteLine("Pink");
    }

    static void Main()
    {
        Letter("Color");
    }
}