
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
   public class About : IEntity
    {
        [Key]
        public int AboutId { get; set; }
        [StringLength(1000)]
        public string AboutDetails1 { get; set; }
        [StringLength(1000)]
        public string AboutDetails2 { get; set; }
        [StringLength(1000)]
        public string AboutImage1 { get; set; }
        [StringLength(1000)]
        public string AboutImage2 { get; set; }






    }
}
