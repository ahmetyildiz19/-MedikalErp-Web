using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlnErp102.Core.UnitOfWork;

namespace SlnErp102.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        SlnDbContext _db;

        public UnitOfWork(SlnDbContext db)
        {
            _db = db;
        }
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
