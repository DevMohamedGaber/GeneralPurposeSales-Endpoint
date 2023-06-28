using GeneralPurposeSalesAppEndpoint.Types;

namespace GeneralPurposeSalesAppEndpoint.Services.Interfaces
{
    public interface IUserService
    {
        Task<LoginResponse> Login(LoginCredentials credentials);
        Task<CreateUserResponse> Register(CreateUserRequest request);
    }
}
