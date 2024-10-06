using EadBackend.Repositories;
using EadBackend.DTOs;
using EadBackend.Models;
using System.Diagnostics;

namespace EadBackend.Services
{
    public class ShopService : IShopService
    {
        private readonly IShopRepository _shopRepository;

        public ShopService(IShopRepository shopRepository)
        {
            _shopRepository = shopRepository;
        }

        public async Task<ShopDto> GetByIdAsync(string id)
        {
            var shop = await _shopRepository.GetByIdAsync(id);
            return MapToDto(shop);
        }

        public async Task<IEnumerable<ShopDto>> GetAllAsync()
        {
            var shops = await _shopRepository.GetAllAsync();
            return shops.Select(MapToDto);
        }

        public async Task<IEnumerable<ShopDto>> GetByVendorIdAsync(string vendorId)
        {
            Debug.WriteLine("vendor id " + vendorId);
            var shops = await _shopRepository.GetByVendorIdAsync(vendorId);
            return shops.Select(MapToDto);
        }

        public async Task<ShopDto> CreateAsync(string vendorId, CreateShopDto createShopDto)
        {
            var shop = new Shop
            {
                Name = createShopDto.Name,
                ImageUrl = createShopDto.ImageUrl,
                VendorId = createShopDto.VendorId,
                Address = createShopDto.Address,
                ContactNumber = createShopDto.ContactNumber
            };

            await _shopRepository.CreateAsync(shop);
            return MapToDto(shop);
        }

        public async Task<ShopDto> UpdateAsync(string id, string vendorId, UpdateShopDto updateShopDto)
        {
            var shop = await _shopRepository.GetByIdAsync(id);
            if (shop == null || shop.VendorId != vendorId)
                throw new UnauthorizedAccessException("Shop not found or you're not authorized to update it.");

            shop.Name = updateShopDto.Name;
            shop.ImageUrl = updateShopDto.ImageUrl;
            shop.Address = updateShopDto.Address;
            shop.ContactNumber = updateShopDto.ContactNumber;
            shop.VendorId = updateShopDto.VendorId;

            await _shopRepository.UpdateAsync(id, shop);
            return MapToDto(shop);
        }

        public async Task DeleteAsync(string id, string vendorId)
        {
            var shop = await _shopRepository.GetByIdAsync(id);
            if (shop == null)
                throw new UnauthorizedAccessException("Shop not found or you're not authorized to delete it.");

            await _shopRepository.DeleteAsync(id);
        }

        private ShopDto MapToDto(Shop shop) => new ShopDto
        {
            Id = shop.Id,
            Name = shop.Name,
            ImageUrl = shop.ImageUrl,
            VendorId = shop.VendorId,
            Address = shop.Address,
            ContactNumber = shop.ContactNumber
        };
    }
}