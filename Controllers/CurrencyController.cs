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

        [HttpGet("{id:int}")]
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

        [HttpGet("{name}")]
        //synchronous call to get data by using where clause
        //public IActionResult GetCurrencyByName([FromRoute] string name)
        //{
        //    //filtering data using where condition to fetch records

        //    //using First method: it generates error if record doesn't found
        //    //var result = _appDbContext.Currencies.Where(c => c.Title==name).First();

        //    //using FirstOrDefault method: it doesn't generates error if record doesn't found
        //    //var result = _appDbContext.Currencies.Where(c => c.Title == name).FirstOrDefault();

        //    //using Single method: it generates error if multiple records are found
        //    //var result = _appDbContext.Currencies.Where(c => c.Title == name).Single();

        //    //using SingleOrDefault method: it doesn't generates error if record doesn't found while generates error if multiple records are found
        //    var result = _appDbContext.Currencies.Where(c => c.Title == name).SingleOrDefault();

        //    return Ok(result);
        //}

        //asynchronous call to get data by using where clause
        public async Task<IActionResult> GetCurrencyByNameAsync([FromRoute] string name)
        {
            //    //filtering data using where condition to fetch records

            //using First method: it generates error if record doesn't found
            //var result = await _appDbContext.Currencies.Where(c => c.Title == name).FirstAsync();

            //using FirstOrDefault method: it doesn't generates error if record doesn't found
            //var result = await _appDbContext.Currencies.Where(c => c.Title == name).FirstOrDefaultAsync();

            //using Single method: it generates error if multiple records are found
            //var result = await _appDbContext.Currencies.Where(c => c.Title == name).SingleAsync();

            //using SingleOrDefault method: it doesn't generates error if record doesn't found while generates error if multiple records are found
            var result = await _appDbContext.Currencies.Where(c => c.Title == name).SingleOrDefaultAsync();

            return Ok(result);
        }
    }
}
