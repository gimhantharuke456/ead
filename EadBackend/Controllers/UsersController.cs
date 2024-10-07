/*******************************************************************************
 * File: UsersController.cs
 * Author: RPGT Rajapaksha (IT21048500)
 * Date: 2024-10-07
 * Description: This file contains the UsersController class, which handles
 *              HTTP requests related to user operations in the EAD Backend application.
 ******************************************************************************/

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using EadBackend.DTOs;
using EadBackend.Services;

namespace EadBackend.Controllers
{
    /// <summary>
    /// Controller for handling user-related operations
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        /// <summary>
        /// Constructor for UsersController
        /// </summary>
        /// <param name="userService">The user service dependency</param>
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// Retrieves all users
        /// </summary>
        /// <returns>A list of all users</returns>
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetAll()
        {
            var users = await _userService.GetAllAsync();
            return Ok(users);
        }

        /// <summary>
        /// Retrieves a specific user by their ID
        /// </summary>
        /// <param name="id">The ID of the user to retrieve</param>
        /// <returns>The requested user if found, otherwise a 404 Not Found response</returns>
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<UserDto>> GetById(string id)
        {
            var user = await _userService.GetByIdAsync(id);
            if (user == null)
                return NotFound();
            return Ok(user);
        }

        /// <summary>
        /// Creates a new user
        /// </summary>
        /// <param name="createUserDto">The user creation data</param>
        /// <returns>The created user</returns>
        [HttpPost]
        public async Task<ActionResult<UserDto>> Create(CreateUserDto createUserDto)
        {
            var user = await _userService.CreateAsync(createUserDto);
            return CreatedAtAction(nameof(GetById), new { id = user.Id }, user);
        }

        /// <summary>
        /// Updates an existing user
        /// </summary>
        /// <param name="id">The ID of the user to update</param>
        /// <param name="updateUserDto">The updated user data</param>
        /// <returns>The updated user if successful, otherwise a 404 Not Found response</returns>
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin,User,Vendor")]
        public async Task<ActionResult<UserDto>> Update(string id, UpdateUserDto updateUserDto)
        {
            try
            {
                var user = await _userService.UpdateAsync(id, updateUserDto);
                return Ok(user);
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }

        /// <summary>
        /// Deletes a user
        /// </summary>
        /// <param name="id">The ID of the user to delete</param>
        /// <returns>A 204 No Content response</returns>
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(string id)
        {
            await _userService.DeleteAsync(id);
            return NoContent();
        }

        /// <summary>
        /// Authenticates a user and returns a JWT token
        /// </summary>
        /// <param name="loginDto">The login credentials</param>
        /// <returns>A JWT token if authentication is successful, otherwise a 401 Unauthorized response</returns>
        [HttpPost("login")]
        public async Task<ActionResult<string>> Login(LoginDto loginDto)
        {
            try
            {
                var token = await _userService.AuthenticateAsync(loginDto);
                return Ok(new { token });
            }
            catch (UnauthorizedAccessException)
            {
                return Unauthorized();
            }
        }
    }
}