using System;
using System.Collections.Generic;
using WalkingSkeletonApi.Models;

namespace WalkingSkeletonApi.Services
{
    public interface IJWTService
    {
        string GenerateToken(User user, List<string> userRoles);
    }
}
