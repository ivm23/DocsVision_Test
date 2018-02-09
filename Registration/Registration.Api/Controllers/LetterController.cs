using Registration.DataInterface;
using Registration.DataInterface.Sql;
using Registration.Model;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Registration.Logger;

namespace Messenger.Api.Controllers
{
    public class LetterController : ApiController
    {

        private readonly ILetter _letterInterface;
        private const string ConnectionString = @"Data Source = (local)\SQLEXPRESS;
                                                    Initial Catalog = Registration.DB;
                                                    Integrated Security = True";

        public LetterController()
        {
            _letterInterface = new LetterInterface(ConnectionString);
        }

        [HttpPost]
        [Route("api/letter")]
        public Letter Create([FromBody] Letter letter)
        {
            NLogger.Logger.Trace("Запрос на создание пользователя");
            var newLetter = _letterInterface.Create(letter.name, letter.idReceiver, letter.idSender, letter.text);
            NLogger.Logger.Trace("Пользователь успешно создан");
            return newLetter;
        }

        [HttpGet]
        [Route("api/letter/{id}/idReceivers")]
        public List<Guid> GetIdReceivers(Guid id)
        {
            NLogger.Logger.Trace($"Запрос на получение списка ID получателей письма с ID: {id}");
            return _letterInterface.GetIdReceivers(id);
        }


        [HttpGet]
        [Route("api/letter/{id}/receivers")]
        public List<string> GetReceivers(Guid id)
        {
            NLogger.Logger.Trace($"Запрос на получение списка имен и логинов получателей письма с ID: {id}");
            return _letterInterface.GetReceivers(id);
        }

        [HttpGet]
        [Route("api/letter/{id}/sender")]
        public string GetSender(Guid id)
        {
            NLogger.Logger.Trace($"Запрос на получение ID отправителя письма с ID: {id}");
            return _letterInterface.GetSender(id);
        }

        [HttpGet]
        [Route("api/letter/{id}")]
        public Letter GetLetter(Guid id)
        {
            NLogger.Logger.Trace($"Запрос на получение письма с ID: {id}");
            return _letterInterface.Get(id);
        }

        [HttpGet]
        [Route("api/letters/orderBySender")]
        public List<Letter> GetLettersOrderBySender()
        {
            NLogger.Logger.Trace("Запрос на получение списка писем, упорядоченных по имени отправителя");
            return _letterInterface.GetLettersOrderBySender();
        }

        [HttpGet]
        [Route("api/letters/orderByName")]
        public List<Letter> GetLettersOrderByName()
        {
            NLogger.Logger.Trace("Запрос на получение списка писем, упорядоченных по названию письма");
            return _letterInterface.GetLettersOrderByName();
        }

        [HttpGet]
        [Route("api/letters/orderByDate")]
        public List<Letter> GetLettersOrderByDate()
        {
            NLogger.Logger.Trace("Запрос на получение списка писем, упорядоченных по дате регистрации письма");
            return _letterInterface.GetLettersOrderByDate();
        }

        [HttpPut]
        [Route("api/letter/{id}/newName")]
        public Letter ChangeLetterName(Guid id, [FromBody] string newName)
        {
            NLogger.Logger.Trace($"Запрос на изменение названия письма с ID: {id}");
            return _letterInterface.ChangeLetterName(id, newName);
        }

        [HttpPut]
        [Route("api/letter/{id}/newText")]
        public Letter ChangeLetterText(Guid id, [FromBody] string newText)
        {
            NLogger.Logger.Trace($"Запрос на изменение содержания письма с ID: {id}");
            return _letterInterface.ChangeLetterText(id, newText);
        }

        [HttpPut]
        [Route("api/letter/{id}/newIdSender")]
        public Letter ChangeLetterName(Guid id, [FromBody] Guid newIdSender)
        {
            NLogger.Logger.Trace($"Запрос на изменение отправителя письма с ID: {id}");
            return _letterInterface.ChangeLetterIdSender(id, newIdSender);
        }


        [HttpPut]
        [Route("api/letter/{id}/newIdReceivers")]
        public Letter ChangeLetterIdReceivers(Guid id, [FromBody] List<Guid> newReceivers)
        {
            NLogger.Logger.Trace($"Запрос на изменение списка получателей письма с ID: {id}");
            return _letterInterface.ChangeLetterReceivers(id, newReceivers);
        }

        [HttpDelete]
        [Route("api/letter/{id}")]
        public void Delete(Guid id)
        {
            NLogger.Logger.Trace($"Запрос на удаление письма с ID: {id}");
            _letterInterface.Delete(id);
        }
    }
}
