using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API_Farm.Models

{
    [Table("animal_types")]
    public class animalType
    {
        [Column("id")]
        public int Id {get; set;}

        [Column("name")]
        [MinLength(4, ErrorMessage = "The field Name needs {0} character at least")]
        public required string Name {get; set;}
        
        [Column("description")]
        public string? Description {get; set;}


    }
}