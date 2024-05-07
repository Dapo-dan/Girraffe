using Giraffe;

internal class Program
{
    static void Main(string[] args)
    {
        Book book1 = new()
        {
            title = "Harry Porter",
            author = "JK Rowling",
            pages = 400,
        };

        Book book2 = new()
        {
            title = "Lord Of The Rings",
            author = "Tolkein",
            pages = 700,
        };

        Console.WriteLine(book1.pages);

        Console.ReadLine();
    }
}