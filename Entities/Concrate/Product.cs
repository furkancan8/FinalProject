using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrate
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public int Reviews { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
        public int SellCount{ get; set; }

    }
}
