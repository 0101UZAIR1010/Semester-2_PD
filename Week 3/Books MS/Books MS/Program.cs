using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_MS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> bookList = new List<Book>();
            int option = 0;

            while (option != 7)
            {
                Console.WriteLine("\n");
                Console.WriteLine("===========Welcome to My Book Store=========");
                Console.WriteLine("| 1. Add Book                               |");
                Console.WriteLine("| 2. View All Books Info                    |");
                Console.WriteLine("| 3. Get Author Details of a Specific Book  |");
                Console.WriteLine("| 4. Sell Copies of a Specific Book         |");
                Console.WriteLine("| 5. Restock a Specific Book                |");
                Console.WriteLine("| 6. See the Count of Books in the List     |");
                Console.WriteLine("| 7. Exit                                   |");
                Console.WriteLine("============================================");

                option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    Console.Write("Title Here====> ");
                    string title = Console.ReadLine();
                    Console.Write("Author idhr====> ");
                    string author = Console.ReadLine();
                    Console.Write("Here Publication year===> ");
                    int publicationYear = int.Parse(Console.ReadLine());
                    Console.Write("Price=====> ");
                    float price = float.Parse(Console.ReadLine());
                    Console.Write("Stock of Quantity====> ");
                    int quantityInStock = int.Parse(Console.ReadLine());

                    Book newBook = new Book(title, author, publicationYear, price, quantityInStock);
                    bookList.Add(newBook);

                    Console.WriteLine($"Book '{title}' added kamyabily.....");
                }
                else if (option == 2)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("All Books listed bellow....");
                    foreach (Book book in bookList)
                    {
                        Console.WriteLine(book.BookDetails());
                    }
                }
                else if (option == 3)
                {
                    Console.Write("Book title here===> ");
                    string searchTitle = Console.ReadLine();
                    Book foundBook = bookList.Find(book => book.GetTitle().Contains(searchTitle));
                    if (foundBook != null)
                    {
                        Console.WriteLine(foundBook.GetAuthor());
                    }
                    else
                    {
                        Console.WriteLine($"Book with title '{searchTitle}' nhi mil payi....Try again!!!!");
                    }
                }
                else if (option == 4)
                {
                    Console.Write("Book title here===> ");
                    string searchTitle = Console.ReadLine();
                    Book foundBook = bookList.Find(book => book.GetTitle().Contains(searchTitle));
                    if (foundBook != null)
                    {
                        Console.Write("Kitni copies ko sale krna? ");
                        int numberOfCopies = int.Parse(Console.ReadLine());
                        foundBook.SellCopies(numberOfCopies);
                    }
                    else
                    {
                        Console.WriteLine($"Book with title '{searchTitle}' nhi mil payi....Try again!!!!");
                    }
                }
                else if (option == 5)
                {
                    Console.Write("Book title here===> ");
                    string searchTitle = Console.ReadLine();
                    Book foundBook = bookList.Find(book => book.GetTitle().Contains(searchTitle));
                    if (foundBook != null)
                    {
                        Console.Write("Kitni copies ko restock krna ?? ");
                        int additionalCopies = int.Parse(Console.ReadLine());
                        foundBook.Restock(additionalCopies);
                    }
                    else
                    {
                        Console.WriteLine($"Book with title '{searchTitle}' nhi mil payi....Try again!!!!");
                    }
                }
                else if (option == 6)
                {
                    Console.WriteLine($"Books ki tadad==> {bookList.Count}");
                }
                else if (option == 7)
                {
                    Console.WriteLine("Program bnd ho rhaa haiiii..........");
                }
                else
                {
                    Console.WriteLine("Ghlt option....1-7 kai b/w try kro!");
                }
            }
        }
    }
}
