class Book
{
    string Title;
    string Author;
    string ISBN;
    int NoOfPages;

    void DisplayInfo()
    {
        // output the book information to the console
        Console.WriteLine("book information");
        Console.WriteLine("----------------");
        Console.WriteLine($"book Title: {Title}");
        Console.WriteLine($"book Author: {Author}");
        Console.WriteLine($"book ISBN: {ISBN}");
        Console.WriteLine($"book NoOfPages: {NoOfPages}");
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        // create a new instance of the book class
        Book book = new Book();
        book.Title = "C# for beginners";
        book.Author = "Bill Gates";
        book.ISBN = "1234567";
        book.NoOfPages = 200;

        Book book2 = new Book();
        book2.Title = "C# methods and classes";
        book2.Author = "microsoft";
        book2.ISBN = "1234567";
        book2.NoOfPages = 50;

        // output book info to the console
        book.DisplayInfo();
        book2.DisplayInfo();
    }
}