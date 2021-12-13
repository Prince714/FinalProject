using System;
using System.Collections.Generic;
using System.Text;


namespace BookingSystem
{
    class Menu
    { 
    public void menu_list()
    {
        Console.WriteLine("Please choose from one of the following:");
        Console.WriteLine("");
        Console.WriteLine("1. Add a new Book");
        Console.WriteLine("2. List of all Books");
        Console.WriteLine("3. Add a name for registration");
        Console.WriteLine("4. List of all issued books ");
            Console.WriteLine("5. Exit.");
    }
   } 
}
