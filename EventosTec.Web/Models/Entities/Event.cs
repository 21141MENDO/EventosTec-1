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
    public class Event
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Nombre")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Fecha del Evento")]
        public DateTime? EventDate { get; set; }
        [Display(Name = "Descripcion")]
        public string Description { get; set; }
        [Display(Name = "Foto")]
        public byte[] Picture { get; set; }
        [Display(Name = "Asistentes")]
        public int People { get; set; }
        [Display(Name = "Diracion")]
        public int Duration { get; set; }
        [Required]
        public int CityId { get; set; }
        [ForeignKey("CityId")]
        public City City { get; set; }
    }
}
