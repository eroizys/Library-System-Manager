using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        List<Book> books = new List<Book>();

        books.Add(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565", 10));
        books.Add(new Book("1984", "George Orwell", "9780451524935", 5));
        books.Add(new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084", 0));
        
        string opt, title, author, isbn, copies;
        int x;
        
        Console.WriteLine("LIBRARY SYSTEM MANAGER");
        Console.WriteLine("");
        Console.WriteLine("1. Add New Book");
        Console.WriteLine("2. Update Book");
        Console.WriteLine("3. Display List of Books");
        Console.WriteLine("4. Exit");
        Console.WriteLine("");
        Console.WriteLine("Enter number of option you would like to choose:");
        opt = Console.ReadLine();

        switch (opt)
        {
            case "1":
            Console.WriteLine("Adding A New Book");
            Console.Write("Title: ");
            title = Console.ReadLine();
            Console.Write("Author: ");
            author = Console.ReadLine();
            Console.Write("ISBN: ");
            isbn = Console.ReadLine();
            Console.Write("Available Copies: ");
            copies = Console.ReadLine();
            
            books.Add(new Book(title, author, isbn, Convert.ToInt32(copies)));

            //books[3].display();

             break;
            case "2":
            Console.BackgroundColor = ConsoleColor.Black;
                foreach (var book in books)
                {
                    Console.Write(Convert.ToString(x) + ". ");
                    book.display();
                    x++;
                }
                break;
            case "3":
            foreach (var book in books)
            {
                Console.Write(Convert.ToString(j) + ". ");
                book.display();
                x++;
            }
                break;
            case "4":
                Console.WriteLine("4");
                break;
            default:
                Console.WriteLine("d");
            break;
        }

        //Console.ReadLine();
    }
}