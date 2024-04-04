using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceID { get; set; }
        [Required(ErrorMessage = "Service İcon Linki Giriniz.")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Hizmet Başlığı Giriniz.")]
        [StringLength(100, ErrorMessage = "En Fazla 100 Karakter Girebilirsiniz.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Hizmet Açıklaması Giriniz.")]
        [StringLength(500, ErrorMessage = "En Fazla 500 Karakter Girebilirsiniz.")]
        public string Description { get; set; }
    }
}
