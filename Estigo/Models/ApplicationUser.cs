using Microsoft.AspNetCore.Identity;
using Microsoft.Graph.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;
using System.Text;

namespace Estigo.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        [Phone]
        public string Phone { get; set; }
        public string Gender { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdatedAt { get; set; }

        
    }
}