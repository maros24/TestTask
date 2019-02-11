using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyTestTask.Models
{
   public enum Types
    {
        GeneralPartnership,
        LimitedPartnership,
        Ltd,
        Inc,
        SocialEn,
    }

    public class Organization:Base
    {
        [Required]
        public int Code { get; set; }
        public string Name { get; set; }
        public Types Type { get; set; }
        public string Owner { get; set; }
    }
}
