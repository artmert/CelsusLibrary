using CelsusLibrary.Data;
using CelsusLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsusLibrary.Utility
{
    public class AddBook
    {
        public void Add(string bookName, string writerName, string writerSurname, 
            string bookType, string printDate, string bookLang, DateTime entrDate, string bookBringer ) //DateTime tipini düzelttik
        {
            Books b = new Books
            {
                BookName = bookName,
                WriterName = writerName,
                WriterSurname = writerSurname,
                BookType = bookType,
                PrintDate = printDate,
                BookLang = bookLang,
                EntrDate = entrDate, 
                BookBringer = bookBringer
            };

            BooksInventory.add(b);

        }
    
        public Books[] Filter(string filter, bool bName )
        {
            if (bName)
            {
                //bookName'  göre ara

            }

            else
            {
                //
            }
            return BooksInventory.allBooksList();
        }
        
    }

}
