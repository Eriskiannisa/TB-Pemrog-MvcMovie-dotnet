using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Booking
    {
        public int Id{ get; set; }
        public string Nama { get; set; }

        [DataType(DataType.Date)]
        public DateTime Jadwal{ get; set; }
    }
}