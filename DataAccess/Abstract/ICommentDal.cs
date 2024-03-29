﻿using Core.DataAccess;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICommentDal:IEntityRepository<Comment>
    {
        public List<Comment> GetProductComment(int productId);
    }
}
