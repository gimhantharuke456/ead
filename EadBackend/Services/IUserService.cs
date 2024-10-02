using EadBackend.DTOs;

namespace EadBackend.Services
{
    public interface IUserService
    {
        Task<UserDto> GetByIdAsync(string id);
        Task<IEnumerable<UserDto>> GetAllAsync();
        Task<UserDto> CreateAsync(CreateUserDto createUserDto);
        Task<UserDto> UpdateAsync(string id, UpdateUserDto updateUserDto);
        Task DeleteAsync(string id);
        Task<LoginResponse> AuthenticateAsync(LoginDto loginDto);
    }
}