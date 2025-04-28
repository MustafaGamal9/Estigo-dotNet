using Microsoft.AspNetCore.Identity;
using Microsoft.Graph.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estigo.Models
{
    public class Student : ApplicationUser // Corrected the class name to 'UserIdentity'
    {
       
        public int StudentCode{ get; set; }
        public DateOnly? BirthDate { get; set; }
        public string? Track { get; set; }
        public int? Level { get; set; }
        [Phone]
        public string? ParentPhone { get; set; }

        

        // Navigation property
        public ICollection<Course> Courses { get; set; }

        public ICollection<Payment> Payments { get; set; }
    }
}
