namespace TaskService.API.Services;

public interface IAuthManager
{
    Task<bool> ValidateUser(LoginUserDto userDto);
    Task<string> CreateToken();
}