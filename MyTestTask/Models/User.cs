using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTestTask.Models
{
    public class User:Base
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
    }
}
