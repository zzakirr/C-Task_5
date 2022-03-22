using System;
using System.Collections.Generic;
using System.Text;

namespace Practise_5._2
{
    internal class Library
    {
        
        public Book[] books;



        int j = 0;
        public Book[] AddBook( Book book)
        {
            books[j++] = book;  
            return books;
        }
        public Book[] GetFilteredBooks(string genre)
        {
            int k = 0;
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].Genre == genre)
                {
                    k++;
                }
            }
            Book[] books2 = new Book[k];
            int j = 0;
            for (int i = 0; i < books.Length; i++)
            {
                if(books[i].Genre==genre)
                {
                    books2[j]=books[i];
                    j++;
                }
            }
            return books2;
        }

        public Book[] GetFilteredPrice(double MinPrice,double MaxPrice)
        {
            int k = 0;
            for (int i = 0; i < books.Length; i++)
            {
                if(books[i].Price>MinPrice && books[i].Price<MaxPrice)
                {
                    k++;
                }
            }
            Book[] books3 = new Book[k];
            int j = 0;
            for(int i = 0; i < books.Length; i++)
            {
                if(books[i].Price > MinPrice && books[i].Price < MaxPrice)
                {
                    books3[j]=books[i];
                    j++;
                }
            }
            return books3;
        }

        public void GetInfo(Book[]book)
        {
            foreach (var item in book)
            {
                Console.WriteLine($"Name:{item.Name} Genre:{item.Genre} No:{item.No} Price:{item.Price} Count:{item.Count}");
            }
        }
    }
}
