using System;
using System.Collections.Generic;
using System.Text;

namespace BookingSystem
{
   public class Bookdetails
   
    {
        public Bookdetails()
        {
        }

        public  Bookdetails(string type, string name, long price, string location, string author, int copies)
        {

            Type = type;
            Name = name;
            Price = price;
            Location = location;
            Author = author;
            Copies = copies;

        }

        public Bookdetails( string person, long contact, string b_name, string issue)
        {

            
            Person = person;
            Contact = contact;
            B_name = b_name;
            Issue= issue;

        }


        public string Type { get; set; }
        public string Name { get; set; }
        public long Price { get; set; }
        public string Location { get; set; }
        public string Author { get; set; }

        public int Copies { get; set; }
        public string Person { get; set; }
        public string B_name { get; set; }
        public long Contact { get; set; }
        public string Issue { get; set; }

        public void menu_options()
        {
            var books = new List<Bookdetails>();
            var details= new List<Bookdetails>();
        
            while (true)
            {
                Console.Write("Choice: ");


                int choice = Convert.ToInt32(Console.ReadLine());

                // condition for user preference 
                if (choice == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Add a New Book");// add new book
                    Console.WriteLine("");

                    Console.Write("Type: ");//  Book type, according to categories
                    string type = Console.ReadLine();

                    Console.Write("Name: ");// Name of the book
                    string name = Console.ReadLine();

                    Console.Write("Price: ");// Price of a book
                    var price = Convert.ToInt64(Console.ReadLine());

                    Console.Write("Location: ");// Books location
                    string location = Console.ReadLine();

                    Console.Write("Author: ");// course instructor
                    string author = Console.ReadLine();

                    Console.Write(" Total no. of Copies: ");// No. of copies is there in libraries
                    int copies = Convert.ToInt32(Console.ReadLine());


                    books.Add(new Bookdetails(type, name, price, location, author, copies));

                    Console.WriteLine("");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadLine();
                    Menu m = new Menu();
                    m.menu_list();

                }
                else if (choice == 2)
                {
                    Console.Clear();
                    Console.WriteLine("List of all Book details");
                    Console.WriteLine("");

                    if (books.Count > 0)
                    {
                        //displaying all info of the Books
                        foreach (var book in books)
                        {
                            Console.WriteLine("****-----------------------------------------****");
                            Console.WriteLine($"Type: {book.Type}");
                            Console.WriteLine($"Name: {book.Name}");
                            Console.WriteLine($"Price: {book.Price}");
                            Console.WriteLine($"eligiblity: {book.Location}");
                            Console.WriteLine($"coordinator: {book.Author}");
                            Console.WriteLine($"Total no. of copies: {book.Copies}");
                        }

                    }
                    else
                    {
                        Console.WriteLine("sorry! you did not enter any book yet.");
                    }


                    Console.WriteLine("");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadLine();
                    Menu m = new Menu();
                    m.menu_list();

                }
                else if (choice == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Add a name for registration");// add new book
                    Console.WriteLine("");


                    Console.Write("Name of Person: ");// Name of the Person
                    string person = Console.ReadLine();

                    Console.Write("Contact No: ");// Contact number
                    var contact = Convert.ToInt64(Console.ReadLine());

                    Console.Write("Book Name : ");// Books Name
                    string b_name = Console.ReadLine();

                    Console.Write("Date of issue: ");// Date
                    string issue = Console.ReadLine();




                    details.Add(new Bookdetails(person, contact, b_name, issue));

                    Console.WriteLine("");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadLine();
                    Menu m = new Menu();
                    m.menu_list();

                }

                else if (choice == 4)
                {
                    Console.Clear();
                    Console.WriteLine("List of all issued Books ");
                    Console.WriteLine("");

                    if (details.Count > 0)
                    {
                        //displaying all info of the issued Books
                        foreach (var detail in details)
                        {
                            Console.WriteLine("****-----------------------------------------****");
                            Console.WriteLine($"Person: {detail.Person}");
                            Console.WriteLine($"Contact: {detail.Contact}");
                            Console.WriteLine($"Issued Book: {detail.B_name}");
                            Console.WriteLine($"Date of issue: {detail.Issue}");

                        }

                    }
                    else
                    {
                        Console.WriteLine("sorry! there are not any registration yet.");
                    }


                    Console.WriteLine("");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadLine();
                    Menu m = new Menu();
                    m.menu_list();
                }

                else if (choice == 5)//  for user exit
                {
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Sorry, Its an invalid option.");
                    Console.WriteLine("");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadLine();
                    Menu m = new Menu();
                    m.menu_list();

                }
                

            }
        }
    }
}
