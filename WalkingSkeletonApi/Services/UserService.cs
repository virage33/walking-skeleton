using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalkingSkeletonApi.Data.Repositories.Database;
using WalkingSkeletonApi.Models;

namespace WalkingSkeletonApi.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepo;

        public UserService(IUserRepository userRepository)
        {
            _userRepo = userRepository;
        }
        public List<User> Users {
            get {
                return _userRepo.GetUsers().Result;
            }
        }

        public Task<bool> Login(string email, string password)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Register(User user, string password)
        {
            throw new NotImplementedException();
        }
    }
}
