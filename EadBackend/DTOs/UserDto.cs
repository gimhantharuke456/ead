/*******************************************************************************
 * File: UserDTOs.cs
 * Author: RPGT Rajapaksha (IT21048500)
 * Date: 2024-10-07
 * Description: This file contains the Data Transfer Objects (DTOs) related to
 *              users in the EAD Backend application.
 ******************************************************************************/

namespace EadBackend.DTOs
{
    /// <summary>
    /// DTO for representing a user
    /// </summary>
    public class UserDto
    {
        /// <summary>
        /// Unique identifier for the user
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Username of the user
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Email address of the user
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Role of the user in the system
        /// </summary>
        public string Role { get; set; }
    }

    /// <summary>
    /// DTO for creating a new user
    /// </summary>
    public class CreateUserDto
    {
        /// <summary>
        /// Username for the new user
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Email address for the new user
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Password for the new user
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Role for the new user in the system
        /// </summary>
        public string Role { get; set; }
    }

    /// <summary>
    /// DTO for updating an existing user
    /// </summary>
    public class UpdateUserDto
    {
        /// <summary>
        /// Updated username for the user
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Updated email address for the user
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Updated role for the user in the system
        /// </summary>
        public string Role { get; set; }
    }

    /// <summary>
    /// DTO for user login credentials
    /// </summary>
    public class LoginDto
    {
        /// <summary>
        /// Email address for login
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Password for login
        /// </summary>
        public string Password { get; set; }
    }

    /// <summary>
    /// DTO for login response
    /// </summary>
    public class LoginResponse
    {
        /// <summary>
        /// User ID of the logged-in user
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Role of the logged-in user
        /// </summary>
        public string role { get; set; }

        /// <summary>
        /// Authentication token for the logged-in user
        /// </summary>
        public string token { get; set; }
    }
}