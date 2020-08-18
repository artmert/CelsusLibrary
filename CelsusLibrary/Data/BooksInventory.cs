using CelsusLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace CelsusLibrary.Data
{
    public class BooksInventory
    {
        static Books[] allBooks;
        static BooksInventory()
        {
               //singleton (bir objenin bellekte bir defa üretilip kullanılmasını sağlayan veri modelleme) 
            if (allBooks == null) // eğer daha ince allBooks adında bir dizi üretilmemişse üret dedik
            allBooks = new Books[0]; // SIFIR ELEMANLI BİR BOOKS sınıfından allbooks adına bir dizi oluşturdum 
        }
        public static Books[] allBooksList() //(GET ACCESSORY YERNE BUNU YAZDIK) allBooks dizisindeki tüm verileri return ile getirerek tüm listeyi yazdırmak için tanımladık
        {
            return allBooks;
        } 
        public static void add(Books book) //(SET ACCESSORY YERNE BUNU YAZDIK) yeni kitap eklemek için bu metodu yazdık 
        {
            ExpandArray(); // aşağıda diziyi genişletmek için tanımladığımız bu metodu buraya çağırarak devam ettik
            allBooks[allBooks.Length - 1] = book;
        }
        private static void ExpandArray()
        {
            Array.Resize(ref allBooks, allBooks.Length + 1);
        }
    }
}
