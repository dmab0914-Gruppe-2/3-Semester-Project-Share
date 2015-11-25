using System;
using System.Collections.Generic;
using System.Linq;
using Library;
using Server.Database;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hit a button when ready..");
            System.Console.ReadLine();
            Console.WriteLine("");
            DbContext dbContext = new DbContext();
            //var d = dbContext.Users.Where(x => x.Username.Contains("jo"));
            //foreach (User user in d)
            //{
            //    Console.WriteLine("ID: " + user.Id);
            //    Console.WriteLine("Username: " + user.Username);
            //    Console.WriteLine("Password: " + user.Password);
            //    Console.WriteLine("");
            //}

            var d = dbContext.Projects.Where(x => x.Id.Equals(1));
            foreach (Project project in d)
            {
                Console.WriteLine("ID: " + project.Id);
                Console.WriteLine("Title: " + project.Title);
                Console.WriteLine("Members: ");
                foreach (User member in project.ProjectMembers)
                {
                    Console.WriteLine("Member: " + member.Username);
                }
                Console.WriteLine("");
            }

            Console.WriteLine("DONE!");
            Console.ReadLine();
        }
    }
}
