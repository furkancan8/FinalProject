using Core.DataAccess;
using Entities.Concrate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{

    public interface IProductDal:IEntityRepository<Product> //referans vermek 8.gün ödev i 
    {
        List<ProductDetailDto> GetProductDetails();
        List<Product> GetPopCategoryFirstTen(int categoryId);
        List<Product> GetPopulerProducts();
    }
}
