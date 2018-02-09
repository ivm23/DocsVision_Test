using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registration.Model;

namespace Registration.DataInterface
{
    public interface IWorker
    {
        User Create(string name, string login);
        User Get( string login);
        List<User> GetAll();
    }
}
