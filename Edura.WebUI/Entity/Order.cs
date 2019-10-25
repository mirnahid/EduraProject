using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Edura.WebUI.Entity
{
    public class Order
    {
        public Order()
        {
            orderLines = new List<OrderLine>();
        }
        public int OrderId { get; set; }
        public string OrderName { get; set; }
        public double Total { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderNumber { get; set; }
        public EnumOrderState OrderState { get; set; }
        public string UserName { get; set; }
        public string Unvan { get; set; }
        public string Adres { get; set; }
        public string Seher { get; set; }
        public string Erazi { get; set; }
        public string Telefon { get; set; }
        public virtual List<OrderLine> orderLines { get; set; }
    }
    public enum EnumOrderState
    {
        [Display(Name ="Təsdiq gözləyir")]
        Waiting,
        [Display(Name = "Sifariş uğurla tamamlandı")]
        Completed
    }
}
