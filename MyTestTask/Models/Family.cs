using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTestTask.Models
{
    public class Family:Base
    { 
        public string Name { get; set; }

        [JsonIgnore]
        public virtual ICollection<Offering> Offerings { get; set; }
    }
}
