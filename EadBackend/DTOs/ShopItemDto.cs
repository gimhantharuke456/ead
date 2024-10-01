namespace EadBackend.DTOs
{
    public class ShopItemDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int InstockAmount { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string ShopId { get; set; }
    }

    public class CreateShopItemDto
    {
        public string Name { get; set; }
        public int InstockAmount { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }

    public class UpdateShopItemDto
    {
        public string Name { get; set; }
        public int InstockAmount { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}