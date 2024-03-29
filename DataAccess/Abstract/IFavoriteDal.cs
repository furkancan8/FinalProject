﻿using Core.DataAccess;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IFavoriteDal:IEntityRepository<Favorite>
    {
        public List<Favorite> GetByUserId (int userId);
    }
}
