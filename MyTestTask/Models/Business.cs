using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyTestTask.Models
{
    public class Business:Base
    {
        [Required]
        public string Name { get; set; }

        [JsonIgnore]
        public virtual ICollection<Family> Family { get; set; }
    }
}
