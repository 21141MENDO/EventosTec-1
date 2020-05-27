using EventosTec.Web.Models;
using EventosTec.Web.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EventosTec.Web.Models.Entities
{
    public class Client
    {
        public int Id { get; set; }

        [MaxLength(500)]
        [Display(Name = "Dirección")]
        public string Address { get; set; }

        public User User { get; set; }

        public ICollection<Event> Events { get; set; }
    }
}