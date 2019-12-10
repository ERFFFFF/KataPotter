using System;
using System.Collections.Generic;
using System.Linq;
using katapotter;

namespace Testpotter
{
    public class Cart
    {
        private List<Book> listBook;
        
        public Cart() {
            listBook = new List<Book>();
        }
        
        public int getItemCount()
        {
            int bookNumber = listBook.Count();
            return bookNumber;
        }

        public void add(Book book)
        {
            listBook.Add(book);
        }

        public double getTotalPrice()
        {
            return this.discount()* (getItemCount()*8);
        }

        public double discount()
        {
            int bookNumber = listBook.Count();
            switch (bookNumber)
            {
                case 1:
                    return 1;
                    break;
                default:
                    return 0.95;
                    break;
            }
        }

        public void ReadList()
        {
            foreach(var elements in listBook)
            {
                Console.WriteLine(elements.name);
            }
        }
    }
}