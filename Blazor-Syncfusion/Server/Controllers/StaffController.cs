using BlazorSyncfusion.Server.Data;
using BlazorSyncfusion.Shared;
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

        [HttpGet("{id}")]
        public async Task<ActionResult<string>> GetStaffById(int id)
        {
            var result = await _context.Employees.FindAsync(id);
            if(result is null)
            {
                return NotFound("Staff not found.");
            }

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<Employee>> CreateStaff(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();

            return Ok(employee);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<string>> UpdateStaff(int id, Employee employee)
        {
            var dbContact = await _context.Employees.FindAsync(id);
            if (dbContact is null)
            {
                return NotFound("Staff not found.");
            }

            dbContact.FirstName = employee.FirstName;
            dbContact.LastName = employee.LastName;
            dbContact.NickName = employee.NickName;
            dbContact.Title = employee.Title;
            dbContact.Mail = employee.Mail;
            dbContact.Phone = employee.Phone ?? dbContact.Phone;
            dbContact.BirthDate = employee.BirthDate;
            dbContact.DateLastUpdated = DateTime.Now;

            await _context.SaveChangesAsync();

            return Ok(employee);
        }
    }
}