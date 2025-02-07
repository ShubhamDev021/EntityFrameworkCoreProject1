using EntityFrameworkCoreProject1.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult GetAllCurrencies()
        {
            //method 1
            //var result = _appDbContext.Currencies.ToList();

            //method 2
            var result = (from currencies in _appDbContext.Currencies
                          select currencies).ToList();
            return Ok(result);
        }
    }
}
