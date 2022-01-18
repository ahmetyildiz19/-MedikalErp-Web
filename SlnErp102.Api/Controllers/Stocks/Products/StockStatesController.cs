#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SlnErp102.Api.DTOs.Stocks.Products;
using SlnErp102.Core.Models.Stocks.Products;
using SlnErp102.Core.Service.Stocks.Products;

namespace SlnErp102.Api.Controllers.Stocks.Products
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockStatesController : ControllerBase
    {
        private readonly IStockStateService _service;
        private readonly IMapper _mapper;

        public StockStatesController(IStockStateService service,
 IMapper mapper
)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/StockStates
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StockState>>> GetStockState()
        {

            var ss = await _service.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<StockStateDto>>(ss));
        }

        // GET: api/StockStates/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StockState>> GetStockState(int id)
        {
            var ss = await _service.GetByIdAsync(id);
            return Ok(value: _mapper.Map<StockStateDto>(ss));
        }

        // PUT: api/StockStates/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStockState(int id, StockStateDto stockStateDto)
        {
            if (id != stockStateDto.Id)
            {
                return BadRequest();
            }
            var ss = await _service.GetByIdAsync(id);
            ss.ProductCode = stockStateDto.ProductCode;
            ss.LotSerial = stockStateDto.LotSerial;
            ss.StockQuantity  = stockStateDto.StockQuantity ;
            ss.ShelfQuantity  = stockStateDto.ShelfQuantity ;
            ss.BranchQuantity = stockStateDto.BranchQuantity;
            ss.ConsigmentQuantity = stockStateDto.ConsigmentQuantity;
            ss.TransferedProductQuantity = stockStateDto.TransferedProductQuantity;
  


            _service.Update(_mapper.Map<StockState>(ss));

            return NoContent();
        }

        // POST: api/StockStates
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StockState>> PostStockState(StockStateDto stockStateDto)
        {
            var ss = await _service.AddAsync(_mapper.Map<StockState>(stockStateDto));
            return Created(string.Empty, _mapper.Map<StockStateDto>(ss));
        }

        // DELETE: api/StockStates/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStockState(int id)
        {
            var ss = await _service.GetByIdAsync(id);

            _service.Remove(ss);
            return NoContent();
        }

        //private bool StockStateExists(int id)
        //{
        //    return _context.StockState.Any(e => e.Id == id);
        //}
    }
}
