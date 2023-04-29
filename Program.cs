using System;

interface ICasaEditrice
{
    string Titolo { get; set; }
    string Author { get; set; }

    void DisplayInfo();
}

interface IBook<D> : ICasaEditrice
{
    D PublicationDate { get; set; }
    int Pages { get; set; }

    void DisplayInfo();
}

class Book<D> : IBook<D>
{
    public string Titolo { get; set; }
    public string Author { get; set; }
    public D PublicationDate { get; set; }
    public int Pages { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine("Информация о книге:");
        Console.WriteLine($"Название: {Titolo}");
        Console.WriteLine($"Автор: {Author}");
        Console.WriteLine($"Дата публикации: {PublicationDate}");
        Console.WriteLine($"Количество страниц: {Pages}");
    }
}

interface IUser<L>
{
    L Login { get; set; }
    string Password { get; set; }

    void DisplayInfo();
}

class User<L> : IUser<L>
{
    public L Login { get; set; }
    public string Password { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine("Информация о пользователе:");
        Console.WriteLine($"Логин: {Login}");
        Console.WriteLine($"Пароль: {Password}");
    }
}

class Utente<D, L> : IBook<D>, IUser<L>
{
    public string Titolo { get; set; }
    public string Author { get; set; }
    public D PublicationDate { get; set; }
    public int Pages { get; set; }
    public L Login { get; set; }
    public string Password { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine("Информация о товаре и пользователе:");
        Console.WriteLine($"Название товара: {Titolo}");
        Console.WriteLine($"Автор товара: {Author}");
        Console.WriteLine($"Дата публикации товара: {PublicationDate}");
        Console.WriteLine($"Количество страниц товара: {Pages}");
        Console.WriteLine($"Логин пользователя: {Login}");
        Console.WriteLine($"Пароль пользователя: {Password}");
    }

    public void CompratoUnLibro()
    {
        Console.WriteLine($"Пользователь с логином {Login} купил книгу {Titolo}.");
    }
}

class Program
{
    static void Main(string[] args)
    {

        Book<string> uvva = new Book<string>
        {
            Titolo = "Убийство в восточном экспрессе",
            Author = "Агата Кристи",
            PublicationDate = "01.01.2001",
            Pages = 845
        };

        Book<int> mp = new Book<int>
        {
            Titolo = "Меч предназначения",
            Author = "Анджей Сапковский",
            PublicationDate = 02022002,
            Pages = 38495
        };

        User<string> user1 = new User<string>
        {
            Login = "лкпле",
            Password = "лцьпкд3453ИОУт92"
        };


        User<int> user2 = new User<int>
        {
            Login = 2222,
            Password = "ьпцжШТ8от383р3тш3г4"
        };


        Utente<string, string> utente = new Utente<string, string>
        {
            Titolo = "Крещение Огнём",
            Author = "Анджей Сапковский",
            PublicationDate = "03.03.2003",
            Pages = 3145345,
            Login = "AmericA",
            Password = "Freeedoooom"
        };

        uvva.DisplayInfo();


        mp.DisplayInfo();


        user1.DisplayInfo();

        user2.DisplayInfo();

        utente.DisplayInfo();

        utente.CompratoUnLibro();

        Console.ReadLine();
    }


}
