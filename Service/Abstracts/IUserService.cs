using DataAccess.Entities.UserEntities;
using DTO.User;

namespace Service.Abstracts
{
    public interface IUserService : IBaseService<UserDTO, User, UserDTO>
    {
        UserDTO Login(UserDTO dto);
    }
}