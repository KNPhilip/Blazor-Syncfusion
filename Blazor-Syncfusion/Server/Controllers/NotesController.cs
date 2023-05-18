using BlazorSyncfusion.Server.Data;
using BlazorSyncfusion.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace BlazorSyncfusion.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly DataContext _context;

        public NotesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Note>>> GetAllNotes()
        {
            return await _context.Notes
                .Include(n => n.Teacher)
                .OrderByDescending(n => n.DateCreated)
                .ToListAsync();
        }

        [HttpGet("{employeeId}")]
        public async Task<ActionResult<List<Note>>> GetNotesFromEmployee(int employeeId)
        {
            return await _context.Notes
                .Where(n => n.TeacherId == employeeId)
                .OrderByDescending(n => n.DateCreated)
                .ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<List<Note>>> CreateNote(Note note)
        {
            _context.Notes.Add(note);
            await _context.SaveChangesAsync();

            return await _context.Notes
                .Where(n => n.TeacherId == note.TeacherId)
                .OrderByDescending(n => n.DateCreated)
                .ToListAsync();
        }

        [HttpDelete]
        public async Task<ActionResult<List<Note>>> DeleteNote(int id)
        {
            var dbNote = await _context.Notes.FindAsync(id);
            if (dbNote is null)
            {
                return NotFound("Note not found.");
            }

            _context.Notes.Remove(dbNote);
            await _context.SaveChangesAsync();

            return await _context.Notes
                .Where(n => n.TeacherId == dbNote.TeacherId)
                .OrderByDescending(n => n.DateCreated)
                .ToListAsync();
        }
    }
}