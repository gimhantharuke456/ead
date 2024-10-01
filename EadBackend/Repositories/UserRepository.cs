using MongoDB.Driver;
using EadBackend.Models;
using Microsoft.Extensions.Options;

namespace EadBackend.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IMongoCollection<User> _users;

        public UserRepository(IMongoClient mongoClient, IOptions<MongoDatabaseSettings> databaseSettings)
        {
            var database = mongoClient.GetDatabase("EadProjectDb");
            _users = database.GetCollection<User>("Users");
        }

        public async Task<User> GetByIdAsync(string id) =>
            await _users.Find(user => user.Id == id).FirstOrDefaultAsync();

        public async Task<User> GetByEmailAsync(string email) =>
            await _users.Find(user => user.Email == email).FirstOrDefaultAsync();

        public async Task<IEnumerable<User>> GetAllAsync() =>
            await _users.Find(_ => true).ToListAsync();

        public async Task CreateAsync(User user) =>
            await _users.InsertOneAsync(user);

        public async Task UpdateAsync(string id, User user) =>
            await _users.ReplaceOneAsync(u => u.Id == id, user);

        public async Task DeleteAsync(string id) =>
            await _users.DeleteOneAsync(user => user.Id == id);
    }
}