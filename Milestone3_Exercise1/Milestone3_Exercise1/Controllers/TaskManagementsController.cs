using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Milestone3_Exercise1.Data;
using Milestone3_Exercise1.Models;

namespace Milestone3_Exercise1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskManagementsController : ControllerBase
    {
        private readonly Milestone3_Exercise1Context _context;

        public TaskManagementsController(Milestone3_Exercise1Context context)
        {
            _context = context;
        }

        // GET: api/TaskManagements
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaskManagement>>> GetTaskManagement()
        {
          if (_context.TaskManagement == null)
          {
              return NotFound();
          }
            return await _context.TaskManagement.ToListAsync();
        }

        // GET: api/TaskManagements/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TaskManagement>> GetTaskManagement(int id)
        {
          if (_context.TaskManagement == null)
          {
              return NotFound();
          }
            var taskManagement = await _context.TaskManagement.FindAsync(id);

            if (taskManagement == null)
            {
                return NotFound();
            }

            return taskManagement;
        }

        // PUT: api/TaskManagements/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTaskManagement(int id, TaskManagement taskManagement)
        {
            if (id != taskManagement.Id)
            {
                return BadRequest();
            }

            _context.Entry(taskManagement).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TaskManagementExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TaskManagements
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TaskManagement>> PostTaskManagement(TaskManagement taskManagement)
        {
          if (_context.TaskManagement == null)
          {
              return Problem("Entity set 'Milestone3_Exercise1Context.TaskManagement'  is null.");
          }
            _context.TaskManagement.Add(taskManagement);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTaskManagement", new { id = taskManagement.Id }, taskManagement);
        }

        // DELETE: api/TaskManagements/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTaskManagement(int id)
        {
            if (_context.TaskManagement == null)
            {
                return NotFound();
            }
            var taskManagement = await _context.TaskManagement.FindAsync(id);
            if (taskManagement == null)
            {
                return NotFound();
            }

            _context.TaskManagement.Remove(taskManagement);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TaskManagementExists(int id)
        {
            return (_context.TaskManagement?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
