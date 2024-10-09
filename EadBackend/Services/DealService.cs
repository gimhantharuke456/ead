using EadBackend.Models;
using EadBackend.DTOs;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EadBackend.Services
{
    public class DealService
    {
        private readonly IMongoCollection<Deal> _deals;

        public DealService(IMongoDatabase database)
        {
            _deals = database.GetCollection<Deal>("Deals");
        }

        public async Task<List<Deal>> GetAllDealsAsync()
        {
            return await _deals.Find(_ => true).ToListAsync();
        }

        public async Task<Deal> GetDealByIdAsync(string id)
        {
            return await _deals.Find(deal => deal.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Deal> CreateDealAsync(CreateDealDto dealDto)
        {
            var deal = new Deal
            {
                Name = dealDto.Name,
                ImageUrl = dealDto.ImageUrl,
                Description = dealDto.Description
            };

            await _deals.InsertOneAsync(deal);
            return deal;
        }

        public async Task<bool> UpdateDealAsync(string id, UpdateDealDto dealDto)
        {
            var updateDefinition = Builders<Deal>.Update
                .Set(d => d.Name, dealDto.Name)
                .Set(d => d.ImageUrl, dealDto.ImageUrl)
                .Set(d => d.Description, dealDto.Description);

            var result = await _deals.UpdateOneAsync(deal => deal.Id == id, updateDefinition);
            return result.ModifiedCount > 0;
        }

        public async Task<bool> DeleteDealAsync(string id)
        {
            var result = await _deals.DeleteOneAsync(deal => deal.Id == id);
            return result.DeletedCount > 0;
        }
    }
}