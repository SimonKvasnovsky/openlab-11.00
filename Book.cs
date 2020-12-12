using System;
using System.Collections.Generic;
using System.Text;

namespace openlab_11._00
{
    class Book
    {
        private int pages;
        private string title;
        private string author;
        private string category;
        private int releaseDate;
        public int Pages
        {
            get { return pages; }
            set
            {
                if (value < 0)
                {
                    pages = 1;
                }
                else
                {
                    pages = value;
                }
            }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string Category
        {
            private get { return category; }
            set { category = value; }
        }
        public int ReleaseDate
        {
            get { return releaseDate; }
            set
            {
                if (value < 1450 || value > 2021)
                {
                    releaseDate = -1;
                }
                else
                {
                    releaseDate = value;
                }
            }
        }
        public static List<string> categoryList = new List<string>() { "detské", "romantické", "náučné", "sci-fi", "dobrodružné" };
        

        public Book()
        {
            this.pages = -1;
            this.title = "-1";
            this.author = "-1";
            this.category = "-1";
            this.releaseDate = -1;
        }
        public Book(int pagess, string titlee)
        {
            this.pages = pagess;
            this.title = titlee;
            this.author = "-1";
            this.category = "-1";
            this.releaseDate = -1;
        }
        public Book(int Pages, string Title, string Author, string Category, int ReleaseDate)
        {
            pages = Pages;
            title = Title;
            author = Author;
            category = Category;
            releaseDate = ReleaseDate;
        }

        public override string ToString()
        {
            return String.Format($"{pages}\n{title}\n{author}\n{category}\n{releaseDate}");
        }
    }
}
