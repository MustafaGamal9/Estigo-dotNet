using System.Threading.Tasks;
using Estigo.Models;
using Microsoft.PowerBI.Api.Models;

public interface IJwtService
{
    Task<string> CreateTokenAsync(AppUser user);
}
