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
            //TestDb();
        }

        static void TestDb()
        {
            System.Console.WriteLine("Hit a button when ready..");
            System.Console.ReadLine();
            Console.WriteLine("");
            //var d = dbContext.Users.Where(x => x.Username.Contains("jo"));
            //foreach (User user in d)
            //{
            //    Console.WriteLine("ID: " + user.Id);
            //    Console.WriteLine("Username: " + user.Username);
            //    Console.WriteLine("Password: " + user.Password);
            //    Console.WriteLine("");
            //}
            IDbProject dbProject = new DbProject();
            foreach (Project project in dbProject.GetAllProjects())
            {
                Console.WriteLine("ID: " + project.Id);
                Console.WriteLine("Project Title: " + project.Title);
                Console.WriteLine("Members: ");
                foreach (User member in project.ProjectMembers)
                {
                    Console.WriteLine("  Member: " + member.Username);
                    Console.WriteLine("    UserType: " + member.Type);
                }
                Console.WriteLine("Project Administrators:");
                foreach (User admin in dbProject.GetProject(project.Id).ProjectAdministrators)
                {
                    Console.WriteLine("  Name: " + admin.Username);
                }
                Console.WriteLine("");
            }

            Console.WriteLine("DONE!");
            Console.ReadLine();
        }
    }
}
