using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using ProjCarApi.Data;

namespace ProjCarApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ProjCarApiContext _context;

        public CarsController(ProjCarApiContext context)
        {
            _context = context;
        }

        // GET: api/Cars
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Car>>> GetCar()
        {
            if (_context.Car == null)
            {
                return NotFound();
            }
            return await _context.Car.ToListAsync();
        }

        // GET: api/Cars/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Car>> GetCar(string id)
        {
            if (_context.Car == null)
            {
                return NotFound();
            }
            var car = await _context.Car.FindAsync(id);

            if (car == null)
            {
                return NotFound();
            }

            return car;
        }

        // PUT: api/Cars/5
        [HttpPut("{id}")]
        //O objeto carro corresponde ao request body do swagger, ou seja, ja vem o objeto carro atualizado
        public async Task<IActionResult> PutCar(string id, Car car)
        {
            //Se o id do request body for diferente do id passado la, retornara bad request
            if (id != car.CarPlate)
            {
                return BadRequest();
            }

            //Muda o estado do objeto com as atualizacoes
            _context.Entry(car).State = EntityState.Modified;

            try
            {
                //Salva os updates e joga pro banco de dados atualizado
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarExists(id))
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

        // POST: api/Cars
        [HttpPost]
        public async Task<ActionResult<Car>> PostCar(Car car)
        {
            if (_context.Car == null)
            {
                return Problem("Entity set 'ProjCarApiContext.Car'  is null.");
            }
            _context.Car.Add(car);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CarExists(car.CarPlate))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }
            //O metodo abaixo serve para retornar o status 201 e tambem para gerar uma resposta visual melhor
            return CreatedAtAction("GetCar", new { id = car.CarPlate }, car);
        }

        // DELETE: api/Cars/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCar(string id)
        {
            if (_context.Car == null)
            {
                return NotFound();
            }
            var car = await _context.Car.FindAsync(id);
            if (car == null)
            {
                return NotFound();
            }

            _context.Car.Remove(car);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CarExists(string id)
        {
            return (_context.Car?.Any(e => e.CarPlate == id)).GetValueOrDefault();
        }
    }
}