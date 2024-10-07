namespace EadBackend.DTOs
{
    public class OrderDto
    {
        public string Id { get; set; }
        public string ShopItemId { get; set; }
        public string ShopId { get; set; }
        public string UserId { get; set; }
        public int Quantity { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }
    }

    public class OrderGetDto
    {
        public string Id { get; set; }
        public string ShopItemId { get; set; }
        public string ShopId { get; set; }
        public string UserId { get; set; }
        public int Quantity { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }

        public string UserName { get; set; }

        public string ShopName { get; set; }

        public string ItemName { get; set; }
    }

    public class CreateOrderDto
    {
        public string ShopItemId { get; set; }
        public string ShopId { get; set; }
        public int Quantity { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }

        public string UserId { get; set; }
    }

    public class UpdateOrderDto
    {
        public int Quantity { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }
    }
}
