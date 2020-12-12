using System;
using System.Collections.Generic;
using System.Text;

namespace openlab_11._00
{
    class Library : Book
    {
        public int numberOfBooks { get { return this.numberOfBooks; } set { numberOfBooks = value; } }
        public int numberOfStudents { get { return this.numberOfStudents; } set { numberOfStudents = value; } }
        public List<string> studentsList = new List<string>();
        public List<Book> bookList = new List<Book>();
        
        public Library(int NumberOfBooks, int NumberOfStudents, List<string> StudentsList, List<Book> BookList)
        {
            numberOfBooks = NumberOfBooks;
            numberOfStudents = NumberOfStudents;
            studentsList = StudentsList;
            bookList = BookList;
        }
        public void Listing()
        {
            Console.WriteLine($"{numberOfStudents} {numberOfBooks}");
            foreach(string students in studentsList)
            {
                Console.WriteLine(students);
            }
            
            foreach (Book book in bookList)
            {
                Console.WriteLine(book.ToString());
            }

        }
        public Library()
        {
            numberOfBooks = -1;
            numberOfStudents = -1;
            studentsList = null;
            bookList = null;
        }
       

    }
}
