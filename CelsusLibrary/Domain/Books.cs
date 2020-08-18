using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsusLibrary.Domain
{
    public class Books
    {
        public string BookName { get; set; }
        public string WriterName { get; set; }
        public string WriterSurname { get; set; }
        public string BookType { get; set; }
        public string PrintDate { get; set; }
        public string BookLang { get; set; }
        public DateTime EntrDate { get; set; }
        public string BookBringer { get; set; }
    }
} 


