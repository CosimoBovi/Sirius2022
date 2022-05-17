using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sirius.Models;

namespace Sirius.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DispositivoController : ControllerBase
    {
        private readonly SiriusContext _context;

        public DispositivoController(SiriusContext context)
        {
            _context = context;
        }

        // GET: api/Dispositivo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dispositivo>>> GetDispositivo()
        {
            return await _context.Dispositivo.ToListAsync();
        }

        // GET: api/Dispositivo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Dispositivo>> GetDispositivo(int id)
        {
            var dispositivo = await _context.Dispositivo.FindAsync(id);

            if (dispositivo == null)
            {
                return NotFound();
            }

            return dispositivo;
        }

        // GET: api/Dispositivo/Posizioni
        [HttpGet("Posizioni")]
        public IQueryable GetAllPlants()
        {
            var dispositivo =  _context.Dispositivo.Select(d => new { d.plant }).Distinct();

            if (dispositivo == null)
            {
                return null;
            }

            return dispositivo;
        }

        // GET: api/Dispositivo/{plant}
        [HttpGet("Plant/{plant}")]
        public List<Dispositivo> GetDispositivoByPlant(string plant)
        {
            List<Dispositivo> dispositivo = _context.Dispositivo.Where(d => d.plant == plant).ToList<Dispositivo>();

            if (dispositivo == null)
            {
                return null;
            }

            return dispositivo;
        }

        // PUT: api/Dispositivo/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDispositivo(int id, Dispositivo dispositivo)
        {
            if (id != dispositivo.id)
            {
                return BadRequest();
            }

            _context.Entry(dispositivo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DispositivoExists(id))
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

        // POST: api/Dispositivo
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Dispositivo>> PostDispositivo(Dispositivo dispositivo)
        {
            _context.Dispositivo.Add(dispositivo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDispositivo", new { id = dispositivo.id }, dispositivo);
        }

        // DELETE: api/Dispositivo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDispositivo(int id)
        {
            var dispositivo = await _context.Dispositivo.FindAsync(id);
            if (dispositivo == null)
            {
                return NotFound();
            }

            _context.Dispositivo.Remove(dispositivo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DispositivoExists(int id)
        {
            return _context.Dispositivo.Any(e => e.id == id);
        }
    }
}
