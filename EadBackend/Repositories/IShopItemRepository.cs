using EadBackend.Models;

namespace EadBackend.Repositories
{
    public interface IShopItemRepository
    {
        Task<ShopItem> GetByIdAsync(string id);
        Task<IEnumerable<ShopItem>> GetAllAsync();
        Task<IEnumerable<ShopItem>> GetByShopIdAsync(string shopId);
        Task CreateAsync(ShopItem shopItem);
        Task UpdateAsync(string id, ShopItem shopItem);
        Task DeleteAsync(string id);
    }
}