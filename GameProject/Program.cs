using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { 
                Id = 1,
                BirthYear = 1985,
                FirstName = "Yasir",
                LastName = "Demirci",
                IdentityNumber = 123456
            });
            gamerManager.Update(new Gamer
            {
                Id = 1,
                BirthYear = 1985,
                FirstName = "Yasir",
                LastName = "Demirci",
                IdentityNumber = 123456
            });
            gamerManager.Delete(new Gamer
            {
                Id = 1,
                BirthYear = 1985,
                FirstName = "Yasir",
                LastName = "Demirci",
                IdentityNumber = 123456
            });
            Console.WriteLine("---------------------");
        }
    }
}