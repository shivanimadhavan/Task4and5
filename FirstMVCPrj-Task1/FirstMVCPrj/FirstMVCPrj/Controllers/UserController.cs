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
    public class UserController : ControllerBase
    {
        private WFMContext _context;



        public UserController(WFMContext context)
        {
            _context = context;



        }



        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Users>>> Get()
        //{



        //    return await _context.Users.ToListAsync();
        //}



        [HttpPost]
        public async Task<ActionResult<IEnumerable<Users>>> Post(Users User)
        {
            try
            {
                //await _context.Users.AddAsync(User);
                await _context.SaveChangesAsync();
                return StatusCode(StatusCodes.Status201Created, User);
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
