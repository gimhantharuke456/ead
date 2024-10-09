namespace EadBackend.DTOs
{
    public class CreateDealDto
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }

    public class UpdateDealDto
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}