using mongoDBSample.Core.Abstract;
using mongoDBSample.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mongoDBSample.Service.Abstract
{
    public interface ICategoryService : IRepository<Category, string>
    {
    }
}
