using EventosTec.Web.Models;
using EventosTec.Web.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventosTec.Web.Models.Entities
{
    public class Category
    {
        public int Id { get; set; }
        [Display(Name = "Categoría")]
        [MaxLength(100)]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Descripción")]
        [MaxLength(300)]
        public string Description { get; set; }

        public ICollection<Event> Events { get; set; }
    }
}
