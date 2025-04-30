using AutoMapper;
using Entities.Dtos;
using Microsoft.AspNetCore.Identity;
using Services.Contrats;

public class AuthManager : IAuthManager
{
    private readonly UserManager<IdentityCitizen> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly IMapper _mapper;

    public AuthManager(UserManager<IdentityCitizen> userManager, RoleManager<IdentityRole> roleManager, IMapper mapper)
    {
        _userManager = userManager;
        _roleManager = roleManager;
        _mapper = mapper;
    }

    public IEnumerable<IdentityCitizen> GetAllCitizens() => _userManager.Users;

    public async Task<IdentityCitizen> GetUserByUsername(string userName) => await _userManager.FindByNameAsync(userName);

    public async Task<IdentityResult> CreateUser(UserDtoForCreation userDto)
    {
        var user = _mapper.Map<IdentityCitizen>(userDto);        
        return await _userManager.CreateAsync(user, userDto.Password);
    }

    public async Task<bool> CheckPasswordForUser(IdentityCitizen user, string password) => await _userManager.CheckPasswordAsync(user, password);

    public async Task<IdentityResult> AssignRole(string userName, string role)
    {
        var user = await GetUserByUsername(userName);
        if (user == null) return IdentityResult.Failed();

        return await _userManager.AddToRoleAsync(user, role);
    }

    public async Task<IdentityResult> DeleteUser(string userName)
    {
        var user = await GetUserByUsername(userName);
        if (user == null) return IdentityResult.Failed();

        return await _userManager.DeleteAsync(user);
    }
}
