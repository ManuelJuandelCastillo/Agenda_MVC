using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Contactos_MVC.Models
{
    public class Contacto
    {
        public int ID { get; set; }

        [Display(Name = "Nombre" )]
        public string name { get; set; }

        [Display(Name = "Número")]
        public String tnumber { get; set; }

        [Display(Name = "Email")]
        public string mail { get; set; }

        [Display(Name = "Dirección")]
        public string address { get; set; }

        [Display(Name = "Grupo")]
        public string group { get; set; }
    }
    
    public class ContactosDBContext : DbContext
    {
        public DbSet<Contacto> Contactos { get; set; }
    }
}