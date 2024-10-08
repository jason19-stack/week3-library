class Book
{

    //properties
    string Title;
    string Author;
    string ISBN;
    int NoOfPages;

    //constructor for book object
    // adda new instance of a book class
    public Book(string bookTitle, string bookAuthor, string bookISBN, int bookNoOfPages )
    {
        Title = bookTitle;
        Author = bookAuthor;
        ISBN = bookISBN;
        NoOfPages = bookNoOfPages;
    }

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
        Book book = new Book("C# for beginner", "Bill Gates", "1234567", 200);

        // another instance?
        // title = visual studio 2022
        // author = microsoft
        // isbn = "123"
        // No of pages = 70

        Book book2 = new Book("visual studio 2022", "Microsoft", "123", 70);

        // output book info to the console
        book.DisplayInfo();
        book2.DisplayInfo();
    }
}