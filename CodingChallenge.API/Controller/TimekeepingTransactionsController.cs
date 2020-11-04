using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CodingChallenge.Domain.Models.Models;
using CodingChallenge.EntityFramework;

namespace CodingChallenge.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimekeepingTransactionsController : ControllerBase
    {
        private readonly CodingChallengeDbContext _context;

        public TimekeepingTransactionsController(CodingChallengeDbContext context)
        {
            _context = context;
        }

        // GET: api/TimekeepingTransactions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TimekeepingTransaction>>> GetTimekeepingTransactions()
        {
            return await _context.TimekeepingTransactions
                .Include(c => c.Employee)
                .Include(c => c.TransactionType)
                .ToListAsync();
        }

        // GET: api/TimekeepingTransactions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TimekeepingTransaction>> GetTimekeepingTransaction(int id)
        {
            var timekeepingTransaction = await _context.TimekeepingTransactions.FindAsync(id);

            if (timekeepingTransaction == null)
            {
                return NotFound();
            }

            return timekeepingTransaction;
        }

        // PUT: api/TimekeepingTransactions/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTimekeepingTransaction(int id, TimekeepingTransaction timekeepingTransaction)
        {
            if (id != timekeepingTransaction.EmployeeId)
            {
                return BadRequest();
            }

            _context.Entry(timekeepingTransaction).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TimekeepingTransactionExists(id))
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

        // POST: api/TimekeepingTransactions
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TimekeepingTransaction>> PostTimekeepingTransaction(TimekeepingTransaction timekeepingTransaction)
        {
            _context.TimekeepingTransactions.Add(timekeepingTransaction);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TimekeepingTransactionExists(timekeepingTransaction.EmployeeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTimekeepingTransaction", new { id = timekeepingTransaction.EmployeeId }, timekeepingTransaction);
        }

        // DELETE: api/TimekeepingTransactions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TimekeepingTransaction>> DeleteTimekeepingTransaction(int id)
        {
            var timekeepingTransaction = await _context.TimekeepingTransactions.FindAsync(id);
            if (timekeepingTransaction == null)
            {
                return NotFound();
            }

            _context.TimekeepingTransactions.Remove(timekeepingTransaction);
            await _context.SaveChangesAsync();

            return timekeepingTransaction;
        }

        private bool TimekeepingTransactionExists(int id)
        {
            return _context.TimekeepingTransactions.Any(e => e.EmployeeId == id);
        }
    }
}
