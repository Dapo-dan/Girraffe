using Giraffe;

internal class Program
{
    static void Main(string[] args)
    {
        Book book1 = new("JK Rowling", "Harry Porter", 400);

        Book book2 = new(
            aTitle: "Lord Of The Rings",
            aAuthor: "Tolkein",
            aPages: 700
        );

        Console.WriteLine(book1.pages);

        Console.ReadLine();
    }
}