using DataAccess.Entities.Base;
using DataAccess.Entities.CartEntities;

namespace DataAccess.Entities.BookEntities
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public int PublishedYear { get; set; }
        public double Price { get; set; }
        public string CoverPhotoPath { get; set; }
        public List<Cart> Cart { get; set; } = new List<Cart>();
    }
}