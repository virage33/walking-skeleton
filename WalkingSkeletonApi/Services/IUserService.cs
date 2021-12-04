using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalkingSkeletonApi.Models;

namespace WalkingSkeletonApi.Services
{
    public interface IUserService
    {
        public List<User> Users { get;}
        Task<bool> Register(User user, string password);
        Task<bool> Login(string email, string password);
    }
}
