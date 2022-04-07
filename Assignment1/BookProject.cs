using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment1
{
    internal class BookProject
    {
        struct Book {

            // Structure Variables
            int bookId;
            string title;
            double price;

            // Accepting Details
            public void setDetails(int bookId, string title, double price) { 
                this.bookId = bookId;
                this.title = title; 
                this.price = price;
            }

            // Displaying Details
           public void display() {

                Console.WriteLine("The book ID is : " + bookId);
                Console.WriteLine("The book Title is : " + title);
                Console.WriteLine("The book Price is : " + price);
                Console.WriteLine("The book Type is : " + bookType.Magazine);    
            }

            enum bookType
            {
                Magazine, Novel, ReferenceBook, Miscellaneous

            }

        }
       
        public static void Main(String [] args) {

            // declaring variables
            int bookId;
            string title;
            double price;

            // decalring object for structure
            Book book = new Book();

            // initalizing variables
            Console.WriteLine("Enter Book ID: ");
            bookId = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter Book Title: ");
            title = Console.ReadLine();

            Console.WriteLine("Enter Book Price : ");
            price = Convert.ToInt16(Console.ReadLine());

            // calling methods
            book.setDetails(bookId, title, price);
            book.display();

            Console.ReadKey();
        
        }

    }
}
