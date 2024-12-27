using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        private string title;
        private string genre;
        private int pageCount;
        private bool available;
        private Date publishingDate;
        private List<Name> authors;


        public Book(Date publishingDate, string genre, string title, List<Name>authors, int pageCount, bool available)
        {
            this.genre = genre;
            this.title = title;
            this.pageCount = pageCount;
            this.publishingDate = publishingDate;
            this.available = available;
            this.authors = new List<Name>(authors);
        }

        public bool GetAvailability() => available;
        public string GetTitle() => title;
        public List<Name> GetAuthors() => new List<Name>(authors);
        public string GetGenre() => genre;
        public Date GetPublishingDate() => publishingDate;
        public int GetPageCount() => pageCount;

        public void SetAvailability(bool available) => this.available = available;

        public Book Copy() => new Book(publishingDate.Copy(), genre, title, new List<Name>(authors), pageCount, available);

        public override bool Equals(object obj)
        {
            if (obj is Book book)
            {
                return title == book.title && genre == book.genre && pageCount == book.pageCount;
            }
            return false;
        }
        public override string ToString() => $"{title} by {string.Join(", ", authors)}";



    }
}
