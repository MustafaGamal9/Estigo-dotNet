
using System.ComponentModel.DataAnnotations;

namespace Estigo.DTO
{
    public class PaymentDTO
    {
        public int PaymentId { get; set; }
        [Required]
        public string StudentId { get; set; }
        [Required]
        public int courseId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string PaymentMethod { get; set; }
    }
}