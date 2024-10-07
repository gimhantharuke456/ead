/*******************************************************************************
 * File: Models.cs
 * Author: RPGT Rajapaksha (IT21048500)
 * Date: 2024-10-07
 * Description: This file contains the model classes for ShopItem and User
 *              in the EAD Backend application.
 ******************************************************************************/



using MongoDB.Driver;
using EadBackend.Models;
using Microsoft.Extensions.Options;

namespace EadBackend.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IMongoCollection<Order> _orders;

        public OrderRepository(IMongoClient mongoClient, IOptions<MongoDatabaseSettings> databaseSettings)
        {
            var database = mongoClient.GetDatabase(databaseSettings.Value.DatabaseName);
            _orders = database.GetCollection<Order>("Orders");
        }

        public async Task<Order> GetByIdAsync(string id) =>
            await _orders.Find(order => order.Id == id).FirstOrDefaultAsync();

        public async Task<IEnumerable<Order>> GetAllAsync() =>
            await _orders.Find(_ => true).ToListAsync();

        public async Task CreateAsync(Order order) =>
            await _orders.InsertOneAsync(order);

        public async Task UpdateAsync(string id, Order order) =>
            await _orders.ReplaceOneAsync(o => o.Id == id, order);

        public async Task DeleteAsync(string id) =>
            await _orders.DeleteOneAsync(order => order.Id == id);
    }
}
