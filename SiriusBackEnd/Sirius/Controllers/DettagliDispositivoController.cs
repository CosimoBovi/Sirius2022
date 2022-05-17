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
    public class DettagliDispositivoController : ControllerBase
    {
        private readonly SiriusContext _context;

        public DettagliDispositivoController(SiriusContext context)
        {
            _context = context;
        }

        // GET: api/DettagliDispositivo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DettagliDispositivo>>> GetDettagliDispositivo()
        {
            return await _context.DettagliDispositivo.ToListAsync();
        }

        // GET: api/DettagliDispositivo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DettagliDispositivo>> GetDettagliDispositivo(int id)
        {
            var dettagliDispositivo = await _context.DettagliDispositivo.FindAsync(id);

            if (dettagliDispositivo == null)
            {
                return NotFound();
            }

            return dettagliDispositivo;
        }

        // GET: api/DettagliDispositivo/Dispositivo/5
        [HttpGet("Dispositivo/{id}")]
        public List<DettagliDispositivo> GetDettagliDispositivobyIdDispositivo(int id)
        {
            List<DettagliDispositivo> dettagliDispositivo = _context.DettagliDispositivo.Where(d => d.Dispositivoid == id).ToList<DettagliDispositivo>();

            if (dettagliDispositivo == null)
            {
                return null;
            }

            return dettagliDispositivo;
        }

        // PUT: api/DettagliDispositivo/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDettagliDispositivo(int id, DettagliDispositivo dettagliDispositivo)
        {
            if (id != dettagliDispositivo.id)
            {
                return BadRequest();
            }

            _context.Entry(dettagliDispositivo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DettagliDispositivoExists(id))
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

        // POST: api/DettagliDispositivo
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DettagliDispositivo>> PostDettagliDispositivo(DettagliDispositivo dettagliDispositivo)
        {
            _context.DettagliDispositivo.Add(dettagliDispositivo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDettagliDispositivo", new { id = dettagliDispositivo.id }, dettagliDispositivo);
        }

        // DELETE: api/DettagliDispositivo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDettagliDispositivo(int id)
        {
            var dettagliDispositivo = await _context.DettagliDispositivo.FindAsync(id);
            if (dettagliDispositivo == null)
            {
                return NotFound();
            }

            _context.DettagliDispositivo.Remove(dettagliDispositivo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DettagliDispositivoExists(int id)
        {
            return _context.DettagliDispositivo.Any(e => e.id == id);
        }
    }
}
