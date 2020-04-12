using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PhoneApplication.Models
{
    public class Manufacturer
    {
        public Manufacturer()
        {
            URL = "";
            ManufacturerName = "";
            DateReleased = new DateTime();
        }
        public String ManufacturerName { get; set; }
        public string URL { get; set; }
        public DateTime DateReleased { get; set; }
        [Key]
        public int ManufacturerID { get; set; }

        public ICollection<Phone> PhoneList { get; set; }

    }
}