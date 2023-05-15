using BlazorSyncfusion.Server.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorSyncfusion.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly DataContext _context;
        
        public StaffController(DataContext context) 
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<string>> GetAllStaff()
        {
            return Ok(await _context.Employees
                .Where(c => c.IsEmployee)
                .ToListAsync());
        }
    }
}