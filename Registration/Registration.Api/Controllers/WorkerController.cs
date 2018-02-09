using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Registration.DataInterface;
using Registration.DataInterface.Sql;
using Registration.Model;
using Registration.Logger;

namespace Messenger.Api.Controllers
{
    public class WorkerController : ApiController
    {
        private readonly IWorker _workerInterface;
        private const string ConnectionString = @"Data Source = (local)\SQLEXPRESS;
                                                    Initial Catalog = Registration.DB;
                                                    Integrated Security = True";

        public WorkerController()
        {
            _workerInterface = new WorkerInterface(ConnectionString);
        }

    
        [HttpPost]
        [Route("api/worker")]
        public User Create([FromBody] User worker)
        {
            NLogger.Logger.Trace("Запрос на создание нового сотрудника");
            return _workerInterface.Create(worker.name, worker.login);
        }

        [HttpGet]
        [Route("api/worker/{login}")]
        public User Get(string login)
        {
            NLogger.Logger.Trace($"Запрос на получение сотрудника с логином: {login}");
            return _workerInterface.Get(login);
        }

        [HttpGet]
        [Route("api/workers")]
        public List<User> GetAll()
        {
            NLogger.Logger.Trace("Запрос на получение списка всех сотрудников");
            return _workerInterface.GetAll();
        }
    }
}
