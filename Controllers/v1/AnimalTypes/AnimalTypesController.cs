using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Farm.Data;
using Microsoft.AspNetCore.Mvc;

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

        
    }
}