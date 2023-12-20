using LibraryTask.Models;

namespace LibraryTask
{
    static class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            bool repeat = true;

            while(repeat)
            {
                Console.WriteLine(" 1.Add Book \n 2.Get book by code \n 3.Get books by code \n 4.Remove all books by code \n 5.Exit");
                string choice = Console.ReadLine();
                string bookCode = "";
                switch(choice)
                {
                    case "1":
                        Console.Write("Enter book name:");
                        string name = Console.ReadLine();
                        Console.Write("Enter Author's name:");
                        string authorName = Console.ReadLine();
                        Console.Write("Enter page count:");
                        int pageCount = int.Parse(Console.ReadLine());
                        Console.Write("Enter price:");
                        int price = int.Parse(Console.ReadLine());
                        Book book = new Book {
                            Name = name,
                            AuthorName = authorName,
                            PageCount = pageCount,
                            Price = price,
                            Code = $"{name[0]}{authorName[0]}{library.books.Count}"
                        };
                        library.AddBook(book);
                        break;

                        case "2":
                        Console.Write("Enter code to search for a book:");
                        bookCode = Console.ReadLine();
                        library.GetBook(bookCode);
                        break;

                        case "3":
                        Console.Write("Enter code to search for a book:");
                        bookCode = Console.ReadLine();
                        library.GetBooks(bookCode);
                        break;

                        case "4":
                        Console.Write("Enter code to remove the books:");
                        bookCode = Console.ReadLine();
                        library.RemoveAllBooks(bookCode);
                        break;

                        default:
                        repeat = false;
                        break;

                }
            }

        }
    }
}
