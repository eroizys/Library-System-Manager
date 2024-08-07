using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//namespace Library_System_Manager
//{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        private int copiesAvailable;


        public Book(string title, string author, string iSBN, int copiesAvailable)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
            this.copiesAvailable = copiesAvailable;
        }

        public int CopiesAvailable
        {
            get { return copiesAvailable; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Invalid Number");
                }
                else
                {
                    copiesAvailable = value;
                }
            }
        }

        public void addCopies(int copies)
        {
            if (copies > 0)
            {
                copiesAvailable += copies;
            } else
            {
                Console.WriteLine("Cannot add the entered Number");
            }
        }

        public void removeCopies(int copies)
        {
            if (copies < copiesAvailable)
            {
                copiesAvailable += copies;
            }
            else
            {
                Console.WriteLine("Cannot add the entered number of books");
            }
        }

        public void display() {
            Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBN}, Available Copies: {CopiesAvailable}");
        }

   // }
}