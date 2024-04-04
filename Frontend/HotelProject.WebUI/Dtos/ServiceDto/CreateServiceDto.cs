using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage ="Service İcon Linki Giriniz.")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Hizmet Başlığı Giriniz.")]
        [StringLength(100,ErrorMessage = "En Fazla 100 Karakter Girebilirsiniz.")]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
