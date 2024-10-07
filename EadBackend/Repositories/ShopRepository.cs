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
    public class ShopRepository : IShopRepository
    {
        private readonly IMongoCollection<Shop> _shops;

        public ShopRepository(IMongoClient mongoClient, IOptions<MongoDatabaseSettings> databaseSettings)
        {
            var database = mongoClient.GetDatabase(databaseSettings.Value.DatabaseName);
            _shops = database.GetCollection<Shop>("Shops");
        }

        public async Task<Shop> GetByIdAsync(string id) =>
            await _shops.Find(shop => shop.Id == id).FirstOrDefaultAsync();

        public async Task<IEnumerable<Shop>> GetAllAsync() =>
            await _shops.Find(_ => true).ToListAsync();

        public async Task<IEnumerable<Shop>> GetByVendorIdAsync(string vendorId) =>
            await _shops.Find(shop => shop.VendorId == vendorId).ToListAsync();

        public async Task CreateAsync(Shop shop) =>
            await _shops.InsertOneAsync(shop);

        public async Task UpdateAsync(string id, Shop shop) =>
            await _shops.ReplaceOneAsync(s => s.Id == id, shop);

        public async Task DeleteAsync(string id) =>
            await _shops.DeleteOneAsync(shop => shop.Id == id);
    }
}