using System;
using System.Collections.Generic;
using SWS.Models;

namespace SWS.Core.Services
{
    public interface IJWTService
    {
        string GenerateToken(User user, List<string> userRoles);
    }
}
