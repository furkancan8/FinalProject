﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrate.EntityFramework
{
    public class EfDistrictDal:EfEntityRepositoryBase<District,NorthwindContext>,IDistrictDal
    {
    }
}
