using SlnErp102.Core.Models.Stocks.Products;
using SlnErp102.Core.Repository.Stocks.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnErp102.Data.Repository.Stocks.Products
{
    public class ProductEntryRepository : Repository<ProductEntry>, IProductEntryRepository
    {
        private SlnDbContext SlnDbContext { get => _db as SlnDbContext; }
        public ProductEntryRepository(SlnDbContext db) : base(db)
        {
        }
    }
}
