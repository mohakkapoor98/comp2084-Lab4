using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhoneApplication.Models
{
    public class Phone
    {
        public Phone()
        {
            PhoneName = "";

            DateReleased = new DateTime();

        }
        [Key]
        public int PhoneID { get; set; }

        public String PhoneName { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

        public double MSRP { get; set; }

        public double ScreenSize { get; set; }

        public DateTime DateReleased { get; set; }

        [ForeignKey("Manufacturer")]
        public int ManufacturerID { get; set; }



    }
}