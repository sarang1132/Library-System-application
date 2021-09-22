using System;
using customValidation;
using Sqlcommands;
using System.Data.SqlClient;
namespace LibraryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------Library Management Application---------------------------");
            Console.Write("\tEnter Admin Id:-\t");
            string AdId =Console.ReadLine();
            Console.Write("\tEnter your password:-\t");
            string ADpass =Console.ReadLine();
            if (validate.valid(AdId, ADpass) == true)
            {
                
                Console.WriteLine("---------------Welcome toLibrary Management System---------------");                
                
                    Console.WriteLine("1.Add New Book");
                    Console.WriteLine("2.Remove Book ");
                    Console.WriteLine("3.Update Book");
                    Console.WriteLine("4.Find a Book");
                    Console.WriteLine("5.Add New Library Member");
                    Console.WriteLine("6.Remove member");
                    Console.WriteLine("7.Update library Member Information");
                    Console.WriteLine("8.Logout");
                    Console.WriteLine("Enter yuor choice");
                    int ch = Convert.ToInt32(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            sqlConnect.CreateConnection();
                            Console.WriteLine("Enter bookname");
                            string bookname = Console.ReadLine();
                            Console.WriteLine("Enter bookauthor");
                            string bookAuthor = Console.ReadLine();
                            Console.WriteLine("Enter bookedition number");
                            int edition = Convert.ToInt32(Console.ReadLine());
                            sqlConnect.addBook(bookname, bookAuthor, edition);
                            Console.WriteLine("{0} added succesfully", bookname);
                            break;
                        case 2:
                            sqlConnect.CreateConnection();
                            Console.WriteLine("Enter bookname");
                            string bkname = Console.ReadLine();
                            Console.WriteLine("Enter bookauthor");
                            string author = Console.ReadLine();
                            sqlConnect.removebook(bkname, author);
                            Console.WriteLine("record delted successfully");
                            break;
                        case 3:

                            sqlConnect.CreateConnection();
                            Console.WriteLine("Enter the updated bookname  ");
                            string A = Console.ReadLine();
                            Console.WriteLine("Enter the old bookname aur author name");
                            string old = Console.ReadLine();
                            sqlConnect.updateBook(A, old);
                            break;
                        case 4:
                            Console.WriteLine("1:Enter author name\t2:enter Bookname");
                            int a = Convert.ToInt32(Console.ReadLine());
                            switch(a)
                        {
                            case 1:
                                sqlConnect.CreateConnection();
                                string authoname = Console.ReadLine();
                                sqlConnect.searchbook(authoname);
                                
                                break;
                            case 2:
                                sqlConnect.CreateConnection();
                                string b0kname = Console.ReadLine();
                                sqlConnect.searchbook(b0kname);

                                break;

                        }

                            break;
                        case 5:

                            sqlConnect.CreateConnection();
                            Console.WriteLine("Enter the new library member name  ");
                            string Name = Console.ReadLine();
                            sqlConnect.addMember(Name);
                            Console.WriteLine("member added");
                            break;
                        case 6:
                            sqlConnect.CreateConnection();
                            Console.WriteLine("Enter bookauthor");
                            string Memname = Console.ReadLine();
                            sqlConnect.removemember(Memname);
                            Console.WriteLine("record delted successfully");
                            break;
                        case 7:
                            sqlConnect.CreateConnection();
                            Console.WriteLine("Enter bookauthor");
                            string  updatemem= Console.ReadLine();
                            sqlConnect.removemember(updatemem);

                        break;
                        case 8:

                            break;


                    }
                
              
            }
            else
            {
                Console.WriteLine("\t\t\t\t\t\t\t\t\tWorng ID and Password!!!!!");
            }





        }
    }
}
