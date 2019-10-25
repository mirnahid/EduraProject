using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Edura.WebUI.Models
{
    public class OrderDetails
    {
        [Required(ErrorMessage ="Zehmet olmasa unvani daxil edin")]
        public string Unvan { get; set; }
        [Required(ErrorMessage = "Zehmet olmasa adresi daxil edin")]
        public string Adres { get; set; }
        [Required(ErrorMessage = "Zehmet olmasa Seheri daxil edin")]
        public string Seher { get; set; }
        [Required(ErrorMessage = "Zehmet olmasa Erazini daxil edin")]
        public string  Erazi { get; set; }
        [Required(ErrorMessage = "Zehmet olmasa Telefonu daxil edin")]
        public string Telefon { get; set; }
    }
}
