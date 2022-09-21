using AutoMapper;
using BookStore.API.Data;
using BookStore.API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace BookStore.API.Repository
{
    public class RolesRepository :IRolesRepository
    {
        private readonly BookStoreContext _context;
        private readonly IMapper _mapper;

        public RolesRepository(BookStoreContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<Roles> PostUser(UserModel users)
        {

            dynamic user = await _context.Users.FirstOrDefaultAsync(x=>x.UserId==users.UserId);
            if (user == null)
            {
                var creatingUser = new User
                {
                    UserId = users.UserId,
                    UserName = users.UserName,
                    CreatedAt = System.DateTime.Now,
                    CreatedBy = "POC"
                };
                var userCreated =  _context.Users.Add(creatingUser);
                await _context.SaveChangesAsync();
                dynamic result = await _context.Users.FirstOrDefaultAsync(x => x.UserId == users.UserId);
                UserRole res = await _context.UserRoles.FirstOrDefaultAsync(x => x.UserId == users.UserId);
                dynamic res2 = await _context.Role.FirstOrDefaultAsync(x => x.RoleId == res.RoleId);
                return res2;

            }
            else
            {
                dynamic result = await _context.Users.FirstOrDefaultAsync(x => x.UserId == users.UserId);
                UserRole res = await _context.UserRoles.FirstOrDefaultAsync(x => x.UserId == users.UserId);
                dynamic res2 = await _context.Role.FirstOrDefaultAsync(x => x.RoleId == res.RoleId);
                return res2;
            }

        }
        public async Task<User> GetUser(string userId)
        {
            dynamic user = await _context.Users.FirstOrDefaultAsync(x => x.UserId == userId);
            return user;
        }
    }
}
