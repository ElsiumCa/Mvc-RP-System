using Microsoft.AspNetCore.Identity;
using Entities.Dtos;
using System.Threading.Tasks;

namespace Services.Contrats
{
    public interface IAuthManager
    {
        IEnumerable<IdentityCitizen> GetAllCitizens();
        Task<IdentityCitizen> GetUserByUsername(string userName);

        Task<IdentityResult> CreateUser(UserDtoForCreation userDto);

        Task<bool> CheckPasswordForUser(IdentityCitizen user, string password);

        Task<IdentityResult> AssignRole(string userName, string role);

        Task<IdentityResult> DeleteUser(string userName);
    }
}
