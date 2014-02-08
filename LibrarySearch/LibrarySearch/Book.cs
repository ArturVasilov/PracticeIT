using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySearch
{
    class Book
    {
        private int id;
        private String title;
        private String author;
        private int year;

        private const int START_ID = -1;
        private const String START_TITLE = "";
        private const String START_AUTHOR = "";
        private const int START_YEAR = -1;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Title
        {
            get { return title; }
            set { title = value; }
        }

        public String Author
        {
            get { return author; }
            set { author = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public Book(int id, String title, String author, int year)
        {
            Id = id;
            Title = title;
            Author = author;
            Year = year;
        }

        public Book()
        {
            Id = START_ID;
            Title = START_TITLE;
            Author = START_AUTHOR;
            Year = START_YEAR;
        }

        public String bookToString() 
        {
            return Id + " " + Title + " " + Author + " " + Year;
        }

        public bool isBooksEqual(Book b)
        {
            bool equalId = (Id == b.Id) || (b.id == START_ID);
            bool equalTitle = (Title.Equals(b.Title)) || (b.Title.Equals(START_TITLE));
            bool equalAuthor = (Author.Equals(b.Author)) || (b.Author.Equals(START_AUTHOR));
            bool equalYear = (Year == b.Year) || (b.Year == START_YEAR);

            return (equalId && equalTitle && equalAuthor && equalYear);
        }
    }
}
