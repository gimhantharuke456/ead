/*******************************************************************************
 * File: IUserService.cs
 * Author: KT Navodya (IT21057106)
 * Date: [2024-10-07]
 * Description: This file contains the IUserService interface, which defines
 *              the contract for user-related business operations in the EAD Backend application.
 ******************************************************************************/

using EadBackend.DTOs;

namespace EadBackend.Services
{
    /// <summary>
    /// Interface for user service operations
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Retrieves a user by their unique identifier
        /// </summary>
        /// <param name="id">The unique identifier of the user</param>
        /// <returns>The user DTO if found, otherwise null</returns>
        Task<UserDto> GetByIdAsync(string id);

        /// <summary>
        /// Retrieves all users in the system
        /// </summary>
        /// <returns>An enumerable collection of all user DTOs</returns>
        Task<IEnumerable<UserDto>> GetAllAsync();

        /// <summary>
        /// Creates a new user in the system
        /// </summary>
        /// <param name="createUserDto">The DTO containing the user creation information</param>
        /// <returns>The created user DTO</returns>
        Task<UserDto> CreateAsync(CreateUserDto createUserDto);

        /// <summary>
        /// Updates an existing user in the system
        /// </summary>
        /// <param name="id">The unique identifier of the user to be updated</param>
        /// <param name="updateUserDto">The DTO containing the updated user information</param>
        /// <returns>The updated user DTO</returns>
        Task<UserDto> UpdateAsync(string id, UpdateUserDto updateUserDto);

        /// <summary>
        /// Deletes a user from the system
        /// </summary>
        /// <param name="id">The unique identifier of the user to be deleted</param>
        Task DeleteAsync(string id);

        /// <summary>
        /// Authenticates a user and generates a login response
        /// </summary>
        /// <param name="loginDto">The DTO containing the login credentials</param>
        /// <returns>The login response, typically containing authentication token and user information</returns>
        Task<LoginResponse> AuthenticateAsync(LoginDto loginDto);
    }
}