﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AbsenderAPI.Data;
using AbsenderAPI.Models.UniversityModels;

namespace AbsenderAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Matieres")]
    public class MatieresController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MatieresController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Matieres
        [HttpGet]
        public IEnumerable<Matiere> GetMatiere()
        {
            return _context.Matiere;
        }

        // GET: api/Matieres/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMatiere([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var matiere = await _context.Matiere.SingleOrDefaultAsync(m => m.IdMatiere == id);

            if (matiere == null)
            {
                return NotFound();
            }

            return Ok(matiere);
        }

        // PUT: api/Matieres/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMatiere([FromRoute] int id, [FromBody] Matiere matiere)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != matiere.IdMatiere)
            {
                return BadRequest();
            }

            _context.Entry(matiere).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MatiereExists(id))
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

        // POST: api/Matieres
        [HttpPost]
        public async Task<IActionResult> PostMatiere([FromBody] Matiere matiere)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var module = _context.Module.FirstOrDefault(u => u.IdModule.Equals(matiere.IdModule));
            matiere.ModuleMatiere = module;            
            _context.Matiere.Add(matiere);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMatiere", new { id = matiere.IdMatiere }, matiere);
        }

        // DELETE: api/Matieres/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMatiere([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var matiere = await _context.Matiere.SingleOrDefaultAsync(m => m.IdMatiere == id);
            if (matiere == null)
            {
                return NotFound();
            }

            _context.Matiere.Remove(matiere);
            await _context.SaveChangesAsync();

            return Ok(matiere);
        }

        private bool MatiereExists(int id)
        {
            return _context.Matiere.Any(e => e.IdMatiere == id);
        }
    }
}