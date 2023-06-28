using GeneralPurposeSalesAppEndpoint.Services.Interfaces;
using GeneralPurposeSalesAppEndpoint.Types;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;

namespace GeneralPurposeSalesAppEndpoint.Services;
public class UserService : IUserService
{
    private readonly UserManager<IdentityUser> manager;
    public UserService(UserManager<IdentityUser> manager)
    {
        this.manager = manager;
    }
    public async Task<LoginResponse> Login(LoginCredentials credentials)
    {
        return null;
    }
    public async Task<CreateUserResponse> Register(CreateUserRequest req)
    {
        if (!req.IsValid())
        {
            return new CreateUserResponse
            {
                isSuccess = false,
                errors = new List<string> { "Invalid Request parametars" }
            };
        }

        var user = new IdentityUser
        {
            Email = req.email,
            UserName = req.username
        };

        var result = await manager.CreateAsync(user, req.password);

        if(result.Succeeded)
        {
            return new CreateUserResponse { isSuccess = true };
        }
        return new CreateUserResponse
        {
            isSuccess = false,
            errors = result.Errors.Select(err => err.Description)
        };
    }
}

