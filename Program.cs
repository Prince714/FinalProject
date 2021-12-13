using System;
using System.Collections.Generic;

namespace BookingSystem
{
    class Program
    {
        private class Course
        {

            static void Main(string[] args)
            {
                
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("Booking System Database");
                    Console.WriteLine("");
                    Console.WriteLine("This is a basic Booking System database system where Librarian have all the information about each  individual type of  books in detail and store the information about the books. Librarian will be able to see the book type, book name, book's author name,  books price, all the books location, No.of copies available of each and every book");
                    Console.WriteLine("");
                    Console.WriteLine("");

                    Menu m = new Menu();
                    m.menu_list();

                    Bookdetails Be = new Bookdetails();
                    Be.menu_options();
                }
            }
        }
    }
}
