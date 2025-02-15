using Microsoft.EntityFrameworkCore.Storage.ValueConversion;


namespace Estigo.Models

{
    public class Admin: ApplicationUser
    {
        public string Role { get; set; }
        
    }
}
