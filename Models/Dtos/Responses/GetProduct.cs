namespace backend.Models.Dtos
{
    public class GetProduct
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string ImageSrc {get;set;}
        public string ImageAlt {get;set;}
        public string CategoryName { get; set; }
        public int Price { get; set; }
    }
}
