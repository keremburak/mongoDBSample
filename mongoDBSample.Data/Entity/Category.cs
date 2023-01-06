using mongoDBSample.Data.Attributes;
using mongoDBSample.Data.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mongoDBSample.Data.Entity
{
    [BsonCollection("Category")]
    public class Category : MongoDBEntity
    {
        public string Name { get; set; }
    }
}
