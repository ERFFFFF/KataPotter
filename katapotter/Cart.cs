using System;
using System.Collections.Generic;
using System.Linq;
using katapotter;

namespace Testpotter
{
    public class Cart
    {

        public List<Book> ListBook { get; set; }
        public List<Book> ListBook1 { get; set; }
        public List<Book> ListBook2 { get; set; }
        public List<Book> ListBook3 { get; set; }
        public List<Book> ListBook4 { get; set; }
        public List<Book> ListBook5 { get; set; }

        public Cart() {
            ListBook = new List<Book>();
            ListBook1 = new List<Book>();
            ListBook2 = new List<Book>();
            ListBook3 = new List<Book>();
            ListBook4 = new List<Book>();
            ListBook5 = new List<Book>();
        }
        
        public int getItemCount()
        {
            int bookNumber = ListBook.Count();
            return bookNumber;
        }

        public void add(Book book)
        {
            ListBook.Add(book);
            switch (book.name)
            {
                case "book1":
                    ListBook1.Add(book);
                    break;

                case "book2":
                    ListBook2.Add(book);
                    break;
                case "book3":
                    ListBook3.Add(book);
                    break;
                case "book4":
                    ListBook4.Add(book);
                    break;
                case "book5":
                    ListBook5.Add(book);
                    break;
                default:
                    break;
            }
        }

        public double getTotalPrice()
        {
            return this.discount()* (getItemCount()*8);
        }

        public double discount()
        {
            int bookNumber = ListBook.Count();
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
            if(ListBook[0].name != ListBook[1].name)
            {
                return 0.95; 
            }
            return 1;
        }
        public void ReadList()
        {
            foreach (var elements in ListBook)
            {
                Console.WriteLine(elements.name);
            }
        }
    }
}