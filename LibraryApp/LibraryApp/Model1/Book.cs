using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Model1
{
    public class Book
    {

        public int BookID { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public string BookLanguage { get; set; }
        public string BookPublishHouse { get; set; }
        public string BookCategory { get; set; }
        public int BookTotal { get; set; }
        public int BookPageNum { get; set; }
        public int BookPublishDate { get; set; }


        public Book()
        {

        }

        public Book(int BookID, string BookName, string BookAuthor, string BookLanguage, string BookPublishHouse, string BookCategory, int BookTotal, int BookPageNum, int BookPublishDate)
        {
            this.BookID = BookID;
            this.BookName = BookName;
            this.BookAuthor = BookAuthor;
            this.BookLanguage = BookLanguage;
            this.BookPublishHouse = BookPublishHouse;
            this.BookCategory = BookCategory;
            this.BookTotal = BookTotal;
            this.BookPageNum = BookPageNum;
            this.BookPublishDate = BookPublishDate;
        }


        public int getBookID()
        {
            return this.BookID;
        }
        public string getBookName()
        {
            return this.BookName;
        }
        public string getBookAuthor()
        {
            return this.BookAuthor;
        }
        public string getBookLanguge()
        {
            return this.BookLanguage;
        }
        public string getBookPublishHouse()
        {
            return this.BookPublishHouse;
        }
        public string getBookCategory()
        {
            return this.BookCategory;
        }
        public int getBookTotal()
        {
            return this.BookTotal;
        }
        public int getBookPageNum()
        {
            return this.BookPageNum;
        }
        public int getBookPublishDate()
        {
            return this.BookPublishDate;
        }
    }
}
