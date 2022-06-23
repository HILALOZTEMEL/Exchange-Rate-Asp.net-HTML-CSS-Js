using System.ComponentModel.DataAnnotations;

namespace finalSerbestPiyasaDoviz.Models
{
    public class Customer
    {
     
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "Lütfen ismi Giriniz .")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen DolarTahmin Giriniz")]
        
        public string DolarTahmin { get; set; }
     

    }
}
