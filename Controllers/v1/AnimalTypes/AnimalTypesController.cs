using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Farm.Data;
using API_Farm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Farm.Controllers.v1.AnimalTypes
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AnimalTypesController : ControllerBase
    {
        private readonly ApplicationDbContext Context; //esta es la llave de la base de datos, la que se encarga de enrutar

        public AnimalTypesController(ApplicationDbContext context)
        {
            Context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(){
            var AnimalTypes = await Context.AnimalTypes.ToListAsync();
            if (AnimalTypes.Any() == false)
            {
                return NoContent(); 
            }
            return Ok(AnimalTypes);
        }

        [HttpPost]

        public async Task<IActionResult> Create(animalType nuevoAnimalType){
            if (ModelState.IsValid == false)
            {
                return BadRequest(ModelState);
            }
            Context.AnimalTypes.Add(nuevoAnimalType);
            await Context.SaveChangesAsync();
            return Ok("created");
        }
    }
}