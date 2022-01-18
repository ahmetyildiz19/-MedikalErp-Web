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
    public class ProductEntriesController : ControllerBase
    {
        private readonly IProductEntryService _service;
        private readonly IMapper _mapper;
        public ProductEntriesController(IProductEntryService service,
IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/ProductEntries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductEntry>>> GetProductEntry()
        {
             var pro = await _service.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<ProductEntryDto>>(pro));
        }

        // GET: api/ProductEntries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductEntry>> GetProductEntry(int id)
        {
            var pro = await _service.GetByIdAsync(id);
            return Ok(value: _mapper.Map<ProductEntryDto>(pro));
        }

        // PUT: api/ProductEntries/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductEntry(int id, ProductEntryDto proDto)
        {
            if (id != proDto.Id)
            {
                return BadRequest();
            }
            var pro = await _service.GetByIdAsync(id);
            pro.CompanyId = proDto.CompanyId;
            pro.InvoiceNumber = proDto.InvoiceNumber;
            pro.ProductId = proDto.ProductId;
            pro.LotSerial = proDto.LotSerial;
            pro.Quantity = proDto.Quantity;
            pro.EntryTypeId = proDto.EntryTypeId;
            pro.SurgerySide = proDto.SurgerySide;
            pro.SurgeryType = proDto.SurgeryType;
            pro.Barcode = proDto.Barcode;
            pro.Description = proDto.Description;           
            pro.EntryDate = proDto.EntryDate;
            pro.ProductionDate = proDto.ProductionDate;
            pro.ExpirationDate = proDto.ExpirationDate;


            _service.Update(_mapper.Map<ProductEntry>(pro));

            return NoContent();
        }

        // POST: api/ProductEntries
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProductEntry>> PostProductEntry(ProductEntryDto productEntryDto)
        {
            var pro = await _service.AddAsync(_mapper.Map<ProductEntry>(productEntryDto));
            return Created(string.Empty, _mapper.Map<ProductEntryDto>(pro));
        }

        // DELETE: api/ProductEntries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductEntry(int id)
        {

            var pro = await _service.GetByIdAsync(id);

            _service.Remove(pro);
            return NoContent();
        }

        //private bool ProductEntryExists(int id)
        //{
        //    return _context.ProductEntry.Any(e => e.Id == id);
        //}
    }
}
