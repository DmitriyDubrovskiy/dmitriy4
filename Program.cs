using System;

class ЖивийОрганізм
{
    public double Енергія { get; set; }
    public int Вік { get; set; }
    public double Розмір { get; set; }
}

class Тварина : ЖивийОрганізм, IPredator, IReproducible
{
    public string Вид { get; set; }

    public void Полювати()
    {
        Console.WriteLine($"Тварина виду {Вид} полює.");
    }

    public void Розмножуватися()
    {
        Console.WriteLine($"Тварина виду {Вид} розмножується.");
    }
}

class Рослина : ЖивийОрганізм, IReproducible
{
    public string Вид { get; set; }

    public void Розмножуватися()
    {
        Console.WriteLine($"Рослина виду {Вид} розмножується.");
    }
}

class Мікроорганізм : ЖивийОрганізм, IReproducible
{
    public string Вид { get; set; }

    public void Розмножуватися()
    {
        Console.WriteLine($"Мікроорганізм виду {Вид} розмножується.");
    }
}

interface IPredator
{
    void Полювати();
}

interface IReproducible
{
    void Розмножуватися();
}

class Екосистема
{
    public void Взаємодія()
    {
        Тварина лев = new Тварина { Вид = "Лев", Енергія = 100, Вік = 5, Розмір = 2.5 };
        Рослина трава = new Рослина { Вид = "Трава", Енергія = 10, Вік = 1, Розмір = 0.2 };

        лев.Полювати();
        трава.Розмножуватися();
    }
}

class Program
{
    static void Main()
    {
        Екосистема екосистема = new Екосистема();
        екосистема.Взаємодія();
    }
}
