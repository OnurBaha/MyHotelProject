using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage ="Ad Alanı Zorunludur.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyad Alanı Zorunludur.")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Kullanıcı Adı Alanı Zorunludur.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Mail Alanı Zorunludur.")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Şifre Alanı Zorunludur.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Şifre Tekrar Alanı Zorunludur.")]
        public string ConfirmPassword { get; set; }
    }
}
