using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    //MicroService

    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Oyuncu Eklendi.");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt Başarısız.");
            }
        }

        public void Delete(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Oyuncu Silindi.");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt Başarısız.");
            }
        }

        public void Update(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Oyuncu Güncellendi.");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt Başarısız.");
            }
        }
    }
}