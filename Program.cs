using System;
using System.Collections.Generic;
using Programa_Hotel.Entities;

namespace Programa_Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Client> list = new List<Client>();

                Console.WriteLine("Welcome to Hotel: ");
                Console.WriteLine("\n1 - Add client.");
                Console.WriteLine("2 - Remove client."); //Menu 
                Console.WriteLine("3 - List rooms.");
                Console.WriteLine("4 - Exit.");

                Console.Write("Select: ");
                int op = int.Parse(Console.ReadLine());
                char op2 = 's';
                while (op2 == 's') //Loop
                {
                    switch (op) //Switch for options
                    {
                        case 1: // firts option of menu selected;

                            Console.WriteLine("\n\t\t.:Add client:.");
                            Console.Write("Insert name: ");
                            string name = Console.ReadLine();

                            Console.Write("Insert age: ");
                            int age = int.Parse(Console.ReadLine());

                            Console.Write("Do you have a email (s/n)? ");
                            char op3 = char.Parse(Console.ReadLine());

                            if (op3 == 's') // If for know if client have a email.
                            {
                                Console.Write("Insert email: ");
                                string email = Console.ReadLine();

                                Console.Write("Insert cell phone: ");
                                Int64 numberCel = Int64.Parse(Console.ReadLine());

                                Console.Write("Insert room: ");
                                int room = int.Parse(Console.ReadLine());


                                list.Add(new Client(name, age, email, numberCel, room));

                            }
                            else // case the client dont have a email. 
                            {
                                Console.Write("Insert cell phone: ");
                                Int64 numberCel = Int64.Parse(Console.ReadLine());

                                Console.Write("Insert room: ");
                                int room = int.Parse(Console.ReadLine());

                                list.Add(new Client(name, age, "XXXX-XXXX", numberCel, room));

                            }
                            break;

                        case 2: // second option of menu selected;

                            Console.Write("Enter the number room to delete reservation: ");
                            int deleteReservation = int.Parse(Console.ReadLine());

                            list.RemoveAt(deleteReservation);

                            break;

                        case 3: // third option of menu selected;

                            foreach (Client obj in list)
                            {
                                Console.WriteLine(obj); // list the costumers
                            }

                            break;

                        case 4: // fourth option of menu selected.

                            Environment.Exit(0); //exit 
                            break;

                        default:
                            Console.WriteLine("Invalid command."); // message case selected a option invalid.
                            break;
                    }


                    Console.Write("\nDo you wish select other option (s/n)?");
                    op2 = char.Parse(Console.ReadLine());

                    if (op2 == 's')
                    {

                        Console.WriteLine("\n1 - Add client.");
                        Console.WriteLine("2 - Remove client.");
                        Console.WriteLine("3 - List rooms.");
                        Console.WriteLine("4 - Exit.");

                        Console.Write("Select: ");
                        op = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                    }
                }

                Console.Read();
            }
            catch(Exception e)
            {
                Console.WriteLine("\nError occurred: {0}", e.Message);
                Console.Read();
            }
            }
    }
}
