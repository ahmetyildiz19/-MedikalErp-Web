using SlnErp102.Core.Models.Stocks.Products;
using SlnErp102.Core.Repository;
using SlnErp102.Core.Service.Stocks.Products;
using SlnErp102.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnErp102.Service.Services.Stocks.Products
{
    public class StockStateService : Service<StockState>, IStockStateService
    {
        public StockStateService(IUnitOfWork unitOfWork, IRepository<StockState> repository) : base(unitOfWork, repository)
        {
        }
    }
}
