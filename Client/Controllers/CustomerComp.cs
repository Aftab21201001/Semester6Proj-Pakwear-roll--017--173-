
using Pakwear.Shared;
using Microsoft.AspNetCore.Components;
using WebApiGrey.Server.Data;
using Client.Other;

namespace Client.Server.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public CustomerController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        // GET: api/v1/Customer
        [HttpGet]
        public IActionResult Get()
        {
            var customers = _appDbContext.Customers.ToList();
            return Ok(customers);
        }

        private IActionResult Ok(List<cUSTOMERR> customers)
        {
            throw new NotImplementedException();
        }

        // POST api/v1/Customer
        [HttpPost]
        public IActionResult Post([FromBody] cUSTOMERR customer)
        {
            try
            {
                _appDbContext.Customers.Add(customer);
                _appDbContext.SaveChanges();
                return Ok("Message: Save successful");
            }
            catch
            {
                return BadRequest();
            }
        }

        private IActionResult BadRequest()
        {
            throw new NotImplementedException();
        }

        private IActionResult Ok(string v)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object? obj)
        {
            return obj is CustomerController controller &&
                   EqualityComparer<AppDbContext>.Default.Equals(_appDbContext, controller._appDbContext);
        }
    }
}
