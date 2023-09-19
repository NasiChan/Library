using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Book
    {
        public Book()
        {
        }
        public Book(string bookId, string bookName, string bookAurthor, string bookStatus)
        {
            this.bookId = bookId;
            this.bookName = bookName;
            this.bookAurthor = bookAurthor;
            this.bookStatus = bookStatus;
        }
        public string bookId { get; set; }
        public string bookName { get; set; }
        public string bookAurthor { get; set; }
        public string bookSummery { get; set; }
        public string bookStatus { get; set; }

        



    }
}

