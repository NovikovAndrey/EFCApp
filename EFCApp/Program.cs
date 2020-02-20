using EFCApp.Entities;
using System;

namespace EFCApp
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User() {Name="Andrey", Surname="Nov" };
            Operations.Create(user);
            User user1 = Operations.Read(1);
            Console.WriteLine($"Name = {user1.Name}, Surname = {user1.Surname}, ID = {user1.Id}");
            Operations.Update( user = new User() { Name = "bb", Surname = "gg" });
            User user2 = Operations.Read(1);
            Console.WriteLine($"Name = {user2.Name}, Surname = {user2.Surname}, ID = {user2.Id}");
            Console.ReadKey();
        }
    }
}
