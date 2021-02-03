using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Theater
    {
        public int Id { get; set; }

         public string Name { get; set; }

        public string City { get; set; }
    }
}