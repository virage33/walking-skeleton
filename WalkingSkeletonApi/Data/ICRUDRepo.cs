﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WalkingSkeletonApi.Data
{
    public interface ICRUDRepo
    {
        Task<bool> Add<T>(T entity);
    }
}
