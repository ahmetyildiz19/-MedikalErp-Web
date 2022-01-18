using SlnErp102.Core.Models.Stocks.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnErp102.Core.Repository.Stocks.Products
{
    public interface IProductEntryRepository:IRepository<ProductEntry>
    {
        Task<IEnumerable<ProductEntry>> DistincListByCompany();
        
    }
}
