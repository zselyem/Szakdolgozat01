using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace Szakdolgozat01.Models
{
    [Table("Foglalasok")]
    public class Foglalas
    {
        public int Id { get; set; }
        public string VezetekNev { get; set; }
        public string KeresztNev { get; set; }
        public string Email { get; set; }
        public string TelSzam { get; set; }
        public DateTime Idopont { get; set; }
        public int Fo { get; set; }
        
    }
}