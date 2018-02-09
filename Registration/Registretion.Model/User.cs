using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Model
{
    public class User
    {
        public string login { get; set; }
        public string name { get; set; }
        public Guid id { get; set; }
    }
}
