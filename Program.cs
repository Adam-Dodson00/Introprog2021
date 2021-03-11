using System;

namespace Selectiontasks
{
    class Program
    {
        static void Main(string[] args)
        {   
            string user = "Adam";
            string pass = "1234";

            Console.WriteLine("Please enter username");
            string username =  Console.ReadLine();

            if (username == user){
                Console.WriteLine("Please enter password");
                string password = Console.ReadLine();

                if (password == pass){
                    Console.WriteLine("Login Successful");
                }
                else{ 
                    Console.WriteLine("Login Unsuccessful");
                }
            }
            else{
                Console.WriteLine("Login Unsuccessful");
            }  
        }
    }
}
