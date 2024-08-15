using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        //Declaring array to store books
        List<Book> books = new List<Book>();

        //Populating array
        books.Add(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565", 10));
        books.Add(new Book("1984", "George Orwell", "9780451524935", 5));
        books.Add(new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084", 0));
        books.Add(new Book("The Hitchhiker's Guide to the Galaxy", "Douglas Adams", "9780345391803", 50));

        //Declaring array for data manipulation and storage
        string opt, opt2, title, author, isbn, copies, newItem;
        int counter;

        //Menu
        Console.WriteLine("LIBRARY SYSTEM MANAGER");
        Console.WriteLine("");
        Console.WriteLine("1. Add New Book");
        Console.WriteLine("2. Update Book");
        Console.WriteLine("3. Display List of Books");
        Console.WriteLine("4. Exit");
        Console.WriteLine("");
        Console.WriteLine("Enter number of option you would like to choose:");
        opt = Console.ReadLine();

        //Switch statement to conduct action for each menu option
        switch (opt)
        {
            case "1": //Adding New Book
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
            case "2": //Update Book Details
                Console.BackgroundColor = ConsoleColor.Green;
                counter = 1;
                Console.WriteLine("Updating Book");
                foreach (var book in books)  //Display Book Menu For Selection
                {
                    Console.Write(Convert.ToString(counter) + ". ");
                    book.display();
                    counter++;
                }

                Console.Write("Enter the number of the book you'd like to update: ");
                opt = Console.ReadLine();

                //Display and Select Option For What Book Detail To Update
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
                    //Switch statement for editing booking details
                    switch (opt2)
                    {
                        case "1":  //Update Title
                            Console.Write("Enter New Title: ");
                            newItem = Console.ReadLine();

                            books[counter - 1].Title = newItem;
                            books[counter - 1].display();
                            break;
                        case "2":  //Update Author
                            Console.Write("Enter New Author: ");
                            newItem = Console.ReadLine();

                            books[counter - 1].Author = newItem;
                            books[counter - 1].display();
                            break;
                        case "3":  //Update ISBN number
                            Console.Write("Enter New ISBN: ");
                            newItem = Console.ReadLine();

                            books[counter - 1].ISBN = newItem;
                            books[counter - 1].display();
                            break;
                        case "4":  //Add Number of Copies
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
                            catch (IndexOutOfRangeException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                        case "5":  //Subtract Number Copies
                            try
                            {
                                Console.Write("Enter Amount of Removed Copies: ");
                                newItem = Console.ReadLine();

                                books[counter - 1].removeCopies(int.Parse(newItem));
                                books[counter - 1].display();
                            }
                            catch (ArgumentOutOfRangeException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            catch (IndexOutOfRangeException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            catch (Exception e)
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
            case "3":  //Display Books
                Console.BackgroundColor = ConsoleColor.Blue;
                counter = 1;
                foreach (var book in books)
                {
                    Console.Write(Convert.ToString(counter) + ". ");
                    book.display();
                    counter++;
                }
                break;
            case "4":  //Exit Program
                Console.BackgroundColor = ConsoleColor.Cyan;
                Environment.Exit(0);
                break;
            default:
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.WriteLine("You have entered an invalid value");
                break;
        }
    }
}