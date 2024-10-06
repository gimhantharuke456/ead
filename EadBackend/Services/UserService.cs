using EadBackend.Repositories;
using EadBackend.DTOs;
using EadBackend.Models;
using EadBackend.Auth;

namespace EadBackend.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IJwtUtils _jwtUtils;

        public UserService(IUserRepository userRepository, IJwtUtils jwtUtils)
        {
            _userRepository = userRepository;
            _jwtUtils = jwtUtils;
        }

        public async Task<UserDto> GetByIdAsync(string id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            return MapToDto(user);
        }

        public async Task<IEnumerable<UserDto>> GetAllAsync()
        {
            var users = await _userRepository.GetAllAsync();
            return users.Select(MapToDto);
        }

        public async Task<UserDto> CreateAsync(CreateUserDto createUserDto)
        {
            var user = new User
            {
                Username = createUserDto.Username,
                Email = createUserDto.Email,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(createUserDto.Password),
                Role = createUserDto.Role,
                Address = createUserDto.Address,
                PhoneNumber = createUserDto.PhoneNumber,
                FirstName = createUserDto.FirstName,
                LastName = createUserDto.LastName,
                Gender = createUserDto.Gender
            };

            await _userRepository.CreateAsync(user);
            return MapToDto(user);
        }

        public async Task<UserDto> UpdateAsync(string id, UpdateUserDto updateUserDto)
        {
            var user = await _userRepository.GetByIdAsync(id);
            if (user == null) throw new KeyNotFoundException("User not found");

            user.Username = updateUserDto.Username;
            user.Email = updateUserDto.Email;
            user.Role = updateUserDto.Role;
            user.Address = updateUserDto.Address;
            user.PhoneNumber = updateUserDto.PhoneNumber;
            user.FirstName = updateUserDto.FirstName;
            user.LastName = updateUserDto.LastName;
            user.Gender = updateUserDto.Gender;

            await _userRepository.UpdateAsync(id, user);
            return MapToDto(user);
        }

        private UserDto MapToDto(User user) => new UserDto
        {
            Id = user.Id,
            Username = user.Username,
            Email = user.Email,
            Role = user.Role,
            Address = user.Address,
            PhoneNumber = user.PhoneNumber,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Gender = user.Gender
        };


        public async Task DeleteAsync(string id)
        {
            await _userRepository.DeleteAsync(id);
        }

        public async Task<LoginResponse> AuthenticateAsync(LoginDto loginDto)
        {
            var user = await _userRepository.GetByEmailAsync(loginDto.Email);
            if (user == null || !BCrypt.Net.BCrypt.Verify(loginDto.Password, user.PasswordHash))
                throw new UnauthorizedAccessException("Invalid email or password");
            LoginResponse response = new LoginResponse();
            response.token = _jwtUtils.GenerateToken(user);
            response.id = user.Id;
            response.role = user.Role;
            return response;
        }
    }
}