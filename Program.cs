using System;

interface IPublisher
{
    string Title { get; set; }
    string Author { get; set; }

    void DisplayInfo();
}

interface IBook<D> : IPublisher
{
    D PublicationDate { get; set; }
    int Pages { get; set; }

    void DisplayInfo();
}

class Book<D> : IBook<D>
{
    public string Title { get; set; }
    public string Author { get; set; }
    public D PublicationDate { get; set; }
    public int Pages { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine("Информация о книге:");
        Console.WriteLine($"Название: {Title}");
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

class ProductUser<D, L> : IBook<D>, IUser<L>
{
    public string Title { get; set; }
    public string Author { get; set; }
    public D PublicationDate { get; set; }
    public int Pages { get; set; }
    public L Login { get; set; }
    public string Password { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine("Информация о товаре и пользователе:");
        Console.WriteLine($"Название товара: {Title}");
        Console.WriteLine($"Автор товара: {Author}");
        Console.WriteLine($"Дата публикации товара: {PublicationDate}");
        Console.WriteLine($"Количество страниц товара: {Pages}");
        Console.WriteLine($"Логин пользователя: {Login}");
        Console.WriteLine($"Пароль пользователя: {Password}");
    }

    public void BuyBook()
    {
        Console.WriteLine($"Пользователь с логином {Login} купил книгу {Title}.");
    }
}

class Program
{
    static void Main(string[] args)
    {

        IBook<string> book1 = new Book<string>
        {
            Title = "Книга 1",
            Author = "Автор 1",
            PublicationDate = "01.01.2001",
            Pages = 200
        };

        IBook<int> book2 = new Book<int>
        {
            Title = "Книга 2",
            Author = "Автор 2",
            PublicationDate = 02022002,
            Pages = 150
        };

        IUser<string> user1 = new User<string>
        {
            Login = "user1",
            Password = "password1"
        };


        IUser<int> user2 = new User<int>
        {
            Login = 2222,
            Password = "password2"
        };


        ProductUser<string, string> productUser = new ProductUser<string, string>
        {
            Title = "Книга 3",
            Author = "Автор 3",
            PublicationDate = "03.03.2003",
            Pages = 300,
            Login = "user3",
            Password = "password3"
        };

        book1.DisplayInfo();


        book2.DisplayInfo();


        user1.DisplayInfo();

        user2.DisplayInfo();

        productUser.DisplayInfo();


        productUser.BuyBook();

        Console.ReadLine();
    }


}