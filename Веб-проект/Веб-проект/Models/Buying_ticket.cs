using System.ComponentModel.DataAnnotations;

namespace Веб_проект.Models
{
    public class Buying_ticket
    {
        [Display(Name = "Город вылета")]
        public string City_there { get; set; }
        [Display(Name = "Город прилета")]
        public string City_back { get; set; }
        [Display(Name = "Дата вылета")]
        public DateTime Date_there { get; set; }
        [Display(Name = "Дата прилета")]
        public DateTime Date_back { get; set; }


    }
}
