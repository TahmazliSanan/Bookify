using DataAccess.Entities.CartEntities;
using DTO.Cart;

namespace Service.Abstracts
{
    public interface ICartService : IBaseService<CartDTO, Cart, CartDTO>
    {
        void AddToCart(CartDTO dto);
        void DeleteFromCart(int cartId);
        IEnumerable<CartDTO> GetCart(int userId);
        void Buy(int userId);
        int GetCountOfBooksInMyCart(int userId);
    }
}