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
using SlnErp102.Core.Service.Infos.Companies;
using SlnErp102.Core.Service.Stocks.Products;

namespace SlnErp102.Api.Controllers.Stocks.Products
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductEntriesController : ControllerBase
    {
        private readonly IProductEntryService _service;
        private readonly ICompanyService _cService;
        private readonly IMapper _mapper;
        private readonly IStockStateService _ssService;

        public ProductEntriesController(IProductEntryService service,
        IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
            _ssService = _ssService;
            _cService = _cService;
        }

        // GET: api/ProductEntries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductEntry>>> GetProductEntry()
        {
            //var pEntry = await _service.GetAllAsync();
            var test = await _service.DistincListByCompany();//2 kayıt getirmek için yaptım.
            var test1 = _mapper.Map<IEnumerable<ProductEntryDistinctDto>>(test);
            //var sonuc = 
            //foreach (var name in test1)
            //{
            //    name.CompanyName= await _cService.Where(x => x.Id ==name.CompanyId);
            //}
            //return Ok(_mapper.Map<IEnumerable<ProductEntryDto>>(pEntry));

            return Ok(test1);
        }

        // GET: api/ProductEntries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductEntry>> GetProductEntry(int id)
        {
            var pEntry = await _service.GetByIdAsync(id);
            return Ok(_mapper.Map<ProductEntryDto>(pEntry));
        }

        // PUT: api/ProductEntries/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductEntry(int id, ProductEntryDto pEntryDto)
        {
            if (id != pEntryDto.Id)
            {
                return BadRequest();
            }
            var pEntry = await _service.GetByIdAsync(id);

            pEntry.Barcode = pEntryDto.Barcode;
            pEntry.CompanyId = pEntryDto.CompanyId;
            pEntry.Description = pEntryDto.Description;
            pEntry.EntryDate = pEntryDto.EntryDate;
            pEntry.EntryTypeId = pEntryDto.EntryTypeId;
            pEntry.ExpirationDate = pEntryDto.ExpirationDate;
            pEntry.InvoiceNumber = pEntryDto.InvoiceNumber;
            pEntry.LotSerial = pEntryDto.LotSerial;
            pEntry.ProductId = pEntryDto.ProductId;
            pEntry.ProductionDate = pEntryDto.ProductionDate;
            pEntry.Quantity = pEntryDto.Quantity;

            //_service.Update(_mapper.Map<ProductEntry>(pEntry));
            _service.Update(pEntry);

            return NoContent();
        }

        // POST: api/ProductEntries
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProductEntry>> PostProductEntry(IEnumerable<ProductEntryDto> pEntryDto)
        {
            var pEntry = await _service.AddRangeAsync(_mapper.Map<IEnumerable<ProductEntry>>(pEntryDto));



            return Created(string.Empty, _mapper.Map<IEnumerable<ProductEntryDto>>(pEntry));
        }

        // DELETE: api/ProductEntries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductEntry(int id)
        {

            var pro = await _service.GetByIdAsync(id);

            _service.Remove(pro);
            return NoContent();
        }
    }
}
