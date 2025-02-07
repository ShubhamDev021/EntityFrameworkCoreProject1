using EntityFrameworkCoreProject1.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreProject1.Controllers
{
    [Route("api/currencies")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public CurrencyController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet("")]
        //synchronous call, less efficient
        //public IActionResult GetAllCurrencies()
        //{
        //    //method 1
        //    //var result = _appDbContext.Currencies.ToList();

        //    //method 2
        //    var result = (from currencies in _appDbContext.Currencies
        //                  select currencies).ToList();
        //    return Ok(result);
        //}

        //asynchronous call, more efficient
        public async Task<IActionResult> GetAllCurrencies()
        {
            // do not forgot to use await here otherwise there will be no use of using async

            //method 1
            //var result = await _appDbContext.Currencies.ToListAsync();

            //method 2
            var result = await (from currencies in _appDbContext.Currencies
                          select currencies).ToListAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        //synchronous call to get data by Primary key
        //public IActionResult GetCurrencyById([FromRoute] int id)
        //{
        //    var result = _appDbContext.Currencies.Find(id);
        //    return Ok(result);
        //}

        //asynchronous call to get data by Primary key
        public async Task<IActionResult> GetCurrencyByIdAsync([FromRoute] int id)
        {
            var result = await _appDbContext.Currencies.FindAsync(id);
            return Ok(result);
        }
    }
}
