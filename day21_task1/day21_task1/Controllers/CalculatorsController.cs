using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using day21_task1.Data;
using day21_task1.Models;

namespace day21_task1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorsController : ControllerBase
    {
        private readonly day21_task1Context _context;

        public CalculatorsController(day21_task1Context context)
        {
            _context = context;
        }

        // GET: api/Calculators
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Calculator>>> GetCalculator()
        {
          if (_context.Calculator == null)
          {
              return NotFound();
          }
            return await _context.Calculator.ToListAsync();
        }

        // GET: api/Calculators/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Calculator>> GetCalculator(int id)
        {
          if (_context.Calculator == null)
          {
              return NotFound();
          }
            var calculator = await _context.Calculator.FindAsync(id);

            if (calculator == null)
            {
                return NotFound();
            }

            return calculator;
        }

        // PUT: api/Calculators/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCalculator(int id, Calculator calculator)
        {
            if (id != calculator.Id)
            {
                return BadRequest();
            }

            _context.Entry(calculator).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CalculatorExists(id))
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

        // POST: api/Calculators
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Calculator>> PostCalculator(Calculator calculator)
        {
          if (_context.Calculator == null)
          {
              return Problem("Entity set 'day21_task1Context.Calculator'  is null.");
          }
            _context.Calculator.Add(calculator);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCalculator", new { id = calculator.Id }, calculator);
        }

        // DELETE: api/Calculators/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCalculator(int id)
        {
            if (_context.Calculator == null)
            {
                return NotFound();
            }
            var calculator = await _context.Calculator.FindAsync(id);
            if (calculator == null)
            {
                return NotFound();
            }

            _context.Calculator.Remove(calculator);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CalculatorExists(int id)
        {
            return (_context.Calculator?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
