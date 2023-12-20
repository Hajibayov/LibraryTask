using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibraryTask.Models
{
    public class Library
    {
        public List<Book> books { get; set; }
        public Library()
        {
            books = new List<Book>();
        }
        public void AddBook(Book book)
        {
            try
            {
                if (book != null)
                {
                    books.Add(book);
                    Console.WriteLine("Book code is {0}", book.Code);
                }
                else
                {
                    throw new Exception();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void GetBook(string code)
        {
            try
            {
                Book value = books.Find(a => a.Code == code);
                if(value != null)
                {
                    Console.WriteLine("-------\n 1.Book name: {0}\n 2.Author name: {1}\n 3.Page count: {2}\n 4.Price: {3}\n -----", value.Name, value.AuthorName, value.PageCount, value.Price);
                }
                else
                {
                    throw new Exception("Book not found");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine (ex.Message);
            }
        }

        public void GetBooks(string code) {
            try
            {
                IEnumerable<Book> allBooks = books.Where(el => el.Code == code);
                if(allBooks.Any())
                {
                    foreach (Book book in allBooks)
                    {
                        Console.WriteLine("------ \n 1.Book name: {0}\n 2.Author name: {1}\n 3.Page count: {2}\n 4.Price: {3}\n ------", book.Name, book.AuthorName, book.PageCount, book.Price);
                    }
                }
                else
                {
                    throw new Exception("Books not found");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        public void RemoveAllBooks(string code)
        {

            IEnumerable<Book> allBooks = books.Where(el => el.Code == code);

            try
            {
                if (allBooks.Any())
                {
                    books.RemoveAll(b => b.Code == code);
                    Console.WriteLine("Books successfully removed");
                }
                else
                {
                    throw new Exception("Books not found");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}
