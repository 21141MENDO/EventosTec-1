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
using Microsoft.AspNetCore.Identity;

namespace EventosTec.Web.Models.Entities
{
    public class User:IdentityUser
    {
        [Display(Name = "Nombre Completo")]
        [MaxLength(150)]
        public string FullName { get; set; }
        [Display(Name = "Descripción")]
        [MaxLength(300)]
        public string Description { get; set; }
        [Display(Name = "Foto")]
        public string ImgUrl { get; set; }
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime? BirthDate { get; set; }

    }
}
