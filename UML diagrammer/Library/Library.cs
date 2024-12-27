using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Library
    {
        private Name libraryName;
        private Date libraryRegistrationDate;
        private List<Book> books;

        public Library(Date registration, Name name)
        {
            libraryRegistrationDate = registration;
            libraryName = name;
            books = new List<Book>();

        }

        public Name GetLibraryName() => libraryName;
        public Date GetLibraryRegistrationDate() => libraryRegistrationDate;

        public bool AddBook(Date publishingDate, string genre, string title, Name author, int pages, bool availability)
        {
            var book = new Book(publishingDate, genre, title, new List<Name> { author }, pages, availability);
            books.Add(book);
            return true;
        }

        public bool BorrowBook(Book book)
        {
            if (book.GetAvailability())
            {
                book.SetAvailability(false);
                return true;

            }
            return false;
        }

        public bool RemoveBook(Book book) => books.Remove(book);

        public void ReturnBook(Book book) => book.SetAvailability(true);

        public int GetBookCount() => books.Count;

        public List<Book> GetBooksByAuthor(Name author) => 
            books.FindAll(b => b.GetAuthors().Exists(a => a.Equals(author)));

        public List<Book> GetBooksByTitle(string title) =>
            books.FindAll(b => b.GetTitle() == title);
        public List<Book> GetBooksByGenre(string genre) =>
            books.FindAll(b => b.GetGenre() == genre);
        public List<Book> GetBooksByPages(int pages) => 
            books.FindAll(b => b.GetPageCount() == pages);
        public List<Book> GetBooksByPublishingDate(Date date) =>
            books.FindAll(b => b.GetPublishingDate().Equals(date));
        public List<Book> GetBooksByAvailability(bool available) =>
            books.FindAll(b => b.GetAvailability() == available);

    }
}
