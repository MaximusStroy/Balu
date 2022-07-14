namespace Balu.Data.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public ushort Price { get; set; }
        public int CategoryId { get; set; }
        public bool IsFavourite { get; set; }
        public virtual Category Category { get; set; }
    }
}
