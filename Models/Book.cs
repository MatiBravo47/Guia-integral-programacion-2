using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public Boolean Available { get; set; }

        public Book() { }
        public Book(string title, string author, string iSBN, bool available)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
            Available = available;
        }
    }
}
