using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlnErp102.Core.Repository.Stocks.Products;
using SlnErp102.Core.UnitOfWork;
using SlnErp102.Data.Repository.Stocks.Products;

namespace SlnErp102.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        SlnDbContext _db;
        private IProductEntryRepository _productEntryRepo;

        public UnitOfWork(SlnDbContext db)
        {
            _db = db;
        }

        public IProductEntryRepository ProductEntryRepo => _productEntryRepo ??= new ProductEntryRepository(_db);


        public void Commit()
        {
            _db.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}
