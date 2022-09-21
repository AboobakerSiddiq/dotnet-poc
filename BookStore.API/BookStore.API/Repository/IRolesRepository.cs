using BookStore.API.Data;
using BookStore.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStore.API.Repository
{
    public interface IRolesRepository
    {
        Task<User> GetUser(string userId);
        Task<Roles> PostUser(UserModel users);
    }
}
