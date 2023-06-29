using AutoMapper;
using DataAccess.Entities.BookEntities;
using DataAccess.Entities.CartEntities;
using DataAccess.Entities.UserEntities;
using DTO.Book;
using DTO.Cart;
using DTO.User;

namespace Service.Config.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<UserDTO, User>();
            CreateMap<User, UserDTO>();

            CreateMap<BookDTO, Book>();
            CreateMap<Book, BookDTO>();

            CreateMap<CartDTO, Cart>();
            CreateMap<Cart, CartDTO>();
        }
    }
}