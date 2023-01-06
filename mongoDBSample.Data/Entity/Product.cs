using mongoDBSample.Data.Attributes;
using mongoDBSample.Data.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mongoDBSample.Data.Entity
{
    [BsonCollection("Product")]
    public class Product : MongoDBEntity
    {
        public string CategoryId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
