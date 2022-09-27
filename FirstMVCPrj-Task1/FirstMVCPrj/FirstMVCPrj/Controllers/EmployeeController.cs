using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCPrj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private WFMContext _context;
        public EmployeeController(WFMContext context)
        {
            _context = context;



        }
        [HttpGet]
       

        [HttpPost]
        public async Task<ActionResult<IEnumerable<Employees>>> Post(Employees person)
        {
            try
            {
                //await _context.Employees.AddAsync(person);
                await _context.SaveChangesAsync();
                return StatusCode(StatusCodes.Status201Created, person);
            }



            catch (DbUpdateException)
            {
              
                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    message = "Server Error"
                });
            }
        }


       
     
    }
}
