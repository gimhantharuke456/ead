using EadBackend.Models;

namespace EadBackend.Repositories
{
    public interface IShopRepository
    {
        Task<Shop> GetByIdAsync(string id);
        Task<IEnumerable<Shop>> GetAllAsync();
        Task<IEnumerable<Shop>> GetByVendorIdAsync(string vendorId);
        Task CreateAsync(Shop shop);
        Task UpdateAsync(string id, Shop shop);
        Task DeleteAsync(string id);
    }
}