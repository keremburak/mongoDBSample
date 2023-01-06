using Microsoft.Extensions.Options;
using mongoDBSample.Core.Concrete;
using mongoDBSample.Data.Entity;
using mongoDBSample.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Settings;

namespace mongoDBSample.Service.Concrete
{
    public class ProductService : MongoDbRepositoryBase<Product>, IProductService
    {
        public ProductService(IOptions<MongoDBSettings> options) : base(options)
        {

        }
    }
}
