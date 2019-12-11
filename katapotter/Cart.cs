using System;
using System.Collections.Generic;
using System.Linq;
using katapotter;

namespace Testpotter
{
    public class Cart
    {
        public List<Book> listBook;
        
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
                case 2:
                    return CompareElementsInList();
                    break;
                case 3:
                    return 0.90;
                    break;
                case 4:
                    return 0.80;
                    break;
                case 5:
                    return 0.75;
                    break;
                default:
                    return 1;
                    break;
            }
        }

        public double CompareElementsInList()
        {
            if(listBook[0].name != listBook[1].name)
            {
                return 0.95; 
            }
            return 1;
        }
        public void ReadList()
        {
            foreach (var elements in listBook)
            {
                Console.WriteLine(elements.name);
            }
        }
    }
}