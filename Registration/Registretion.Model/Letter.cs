using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Model
{
    public class Letter
    {
        public Guid id; 
        public Guid idSender { get; set; }
        public List<Guid> idReciever { get; set; }
        public DateTime date { get; set; }
        public string name { get; set; }
        public string text { get; set; }
    }
}
