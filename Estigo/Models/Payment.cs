// Models/Payment.cs
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estigo.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }

        public DateTime PurchaseDate { get; set; } = DateTime.UtcNow;
        public string PaymentMethod { get; set; }

        [ForeignKey("Student")]
        public string StudentId { get; set; } 
        
        [ForeignKey("Course")]
        public int courseId { get; set; }

        // Navigation property 
        public Course Course { get; set; } 
        public Student Student { get; set; }

    }
}