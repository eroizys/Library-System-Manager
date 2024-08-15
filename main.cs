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

        string opt, opt2, title, author, isbn, copies, newItem;
        int counter;

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
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Adding A New Book");
                Console.Write("Title: ");
                title = Console.ReadLine();
                Console.Write("Author: ");
                author = Console.ReadLine();
                Console.Write("ISBN: ");
                isbn = Console.ReadLine();
                Console.Write("Available Copies: ");
                copies = Console.ReadLine();
                if (int.TryParse(copies, out int iCopies))
                {
                    books.Add(new Book(title, author, isbn, iCopies));

                    counter = 1;
                    foreach (var book in books)
                    {
                        Console.Write(Convert.ToString(counter) + ". ");
                        book.display();
                        counter++;
                    }
                }
                else
                {
                    Console.WriteLine("The value you have entered for number of copies is not valid");
                }

                break;
            case "2":
                Console.BackgroundColor = ConsoleColor.Green;
                counter = 1;
                Console.WriteLine("Updating Book");
                foreach (var book in books)
                {
                    Console.Write(Convert.ToString(counter) + ". ");
                    book.display();
                    counter++;
                }

                Console.Write("Enter the number of the book you'd like to update: ");
                opt = Console.ReadLine();

                Console.WriteLine("What would you like to update? ");
                Console.WriteLine("1. Title");
                Console.WriteLine("2. Author");
                Console.WriteLine("3. ISBN");
                Console.WriteLine("4. Add Copies");
                Console.WriteLine("5. Remove Copies");
                Console.Write("Enter number: ");
                opt2 = Console.ReadLine();
                
                if (int.TryParse(opt, out counter))
                {
                    Console.WriteLine(counter);
                    switch (opt2)
                    {
                        case "1":
                            Console.Write("Enter New Title: ");
                            newItem = Console.ReadLine();

                            books[counter - 1].Title = newItem;
                            books[counter - 1].display();
                            break;
                        case "2":
                            Console.Write("Enter New Author: ");
                            newItem = Console.ReadLine();

                            books[counter - 1].Author = newItem;
                            books[counter - 1].display();
                            break;
                        case "3":
                            Console.Write("Enter New ISBN: ");
                            newItem = Console.ReadLine();

                            books[counter - 1].ISBN = newItem;
                            books[counter - 1].display();
                            break;
                        case "4":
                            try
                            {
                                Console.Write("Enter Amount of Added Copies: ");
                                newItem = Console.ReadLine();

                                books[counter - 1].addCopies(int.Parse(newItem));
                                books[counter - 1].display();
                            }
                            catch (ArgumentOutOfRangeException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                        case "5":
                            try
                            {
                                Console.Write("Enter Amount of Removed Copies: ");
                                newItem = Console.ReadLine();

                                books[counter - 1].removeCopies(int.Parse(newItem));
                                books[counter - 1].display();
                                break;
                            }
                            catch (ArgumentOutOfRangeException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                        default:
                            Console.WriteLine("You have not entered a number within range");

                            break;
                    }
                }
                else
                {
                    Console.WriteLine("You have not entered a number");
                }

                break;
            case "3":
                Console.BackgroundColor = ConsoleColor.Blue;
                counter = 1;
                foreach (var book in books)
                {
                    Console.Write(Convert.ToString(counter) + ". ");
                    book.display();
                    counter++;
                }
                break;
            case "4":
                Console.BackgroundColor = ConsoleColor.Cyan;
                Environment.Exit(0);
                break;
            default:
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.WriteLine("d");
                break;
        }
    }
}