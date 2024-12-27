using System;
using System.Collections.Generic;
using Library;

namespace LibraryProgram
{
    class Program
    {
        static void Main(string[] args)
        {


            //year, month, day
            var library = new Library.Library(new Date(2024, 12, 13), new Name("Silkeborg", "Bibliotek"));

            bool running = true;

            while (running)
            {
                Console.WriteLine("\nLibrary Management System");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Display All Books");
                Console.WriteLine("3. Borrow Book");
                Console.WriteLine("4. Return Book");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddBook(library);
                        break;
                    case "2":
                        DisplayBooks(library);
                        break;
                    case "3":
                        BorrowBook(library);
                        break;
                    case "4":
                        ReturnBook(library);
                        break;
                    case "5":
                        running = false;
                        Console.WriteLine("Exiting... Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

        static void AddBook(Library.Library library)
        {
            Console.WriteLine("Enter book details:");

            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.Write("Genre: ");
            string genre = Console.ReadLine();           

            Console.Write("Page Count: ");
            int pageCount = int.Parse(Console.ReadLine());

            Console.Write("Author First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Author Last Name: ");
            string lastName = Console.ReadLine();

            //Console.Write("Year of Publishing: ");
            //int year = int.Parse(Console.ReadLine());

            //Console.Write("Month of Publishing: ");
            //int month = int.Parse(Console.ReadLine());

            //Console.Write("Day of Publishing: ");
            //int day = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter publishing date: ");
            Date validDate = Date.CreateWithValidation();

            Console.Write("Availability (true/false): ");
            bool available = bool.Parse(Console.ReadLine());

            //var date = new Date(year, month, day);
            var author = new Name(firstName, lastName);

            library.AddBook(validDate, genre, title, author, pageCount, available);

            Console.WriteLine("Book added successfully!");
        }

        static void DisplayBooks(Library.Library library)
        {
            var books = library.GetBooksByAvailability(true);

            Console.WriteLine("\nAvailable Books:");
            foreach (var book in books)
            {
                Console.WriteLine(book.ToString());
            }
        }

        static void BorrowBook(Library.Library library)
        {
            Console.Write("Enter the title of the book to borrow: ");
            string title = Console.ReadLine();

            var books = library.GetBooksByTitle(title);

            if (books.Count == 0)
            {
                Console.WriteLine("No books found with that title.");
                return;
            }

            foreach (var book in books)
            {
                if (library.BorrowBook(book))
                {
                    Console.WriteLine("Book borrowed successfully!");
                    return;
                }
            }

            Console.WriteLine("Book is not available.");
        }

        static void ReturnBook(Library.Library library)
        {
            Console.Write("Enter the title of the book to return: ");
            string title = Console.ReadLine();

            var books = library.GetBooksByTitle(title);

            if (books.Count == 0)
            {
                Console.WriteLine("No books found with that title.");
                return;
            }

            foreach (var book in books)
            {
                library.ReturnBook(book);
                Console.WriteLine("Book returned successfully!");
                return;
            }
        }
    }
}