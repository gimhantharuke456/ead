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
    public class ShopItemRepository : IShopItemRepository
    {
        private readonly IMongoCollection<ShopItem> _shopItems;

        public ShopItemRepository(IMongoClient mongoClient, IOptions<MongoDatabaseSettings> databaseSettings)
        {
            var database = mongoClient.GetDatabase(databaseSettings.Value.DatabaseName);
            _shopItems = database.GetCollection<ShopItem>("ShopItems");
        }

        public async Task<ShopItem> GetByIdAsync(string id) =>
            await _shopItems.Find(item => item.Id == id).FirstOrDefaultAsync();

        public async Task<IEnumerable<ShopItem>> GetAllAsync() =>
            await _shopItems.Find(_ => true).ToListAsync();

        public async Task<IEnumerable<ShopItem>> GetByShopIdAsync(string shopId) =>
            await _shopItems.Find(item => item.ShopId == shopId).ToListAsync();

        public async Task CreateAsync(ShopItem shopItem) =>
            await _shopItems.InsertOneAsync(shopItem);

        public async Task UpdateAsync(string id, ShopItem shopItem) =>
            await _shopItems.ReplaceOneAsync(item => item.Id == id, shopItem);

        public async Task DeleteAsync(string id) =>
            await _shopItems.DeleteOneAsync(item => item.Id == id);
    }
}