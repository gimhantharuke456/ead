namespace EadBackend.DTOs
{
    public class ShopDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string VendorId { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
    }

    public class CreateShopDto
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        public string VendorId { get; set; }
    }

    public class UpdateShopDto
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string VendorId { get; set; }
    }
}