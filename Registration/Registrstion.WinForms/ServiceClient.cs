using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Registration.Model;

namespace Registration.WinForms
{
    internal class ServiceClient
    {
        private readonly HttpClient _client;

        public ServiceClient(string connectionString)
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(connectionString);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public Letter CreateLetter(Letter letter)
        {
            using (var response = _client.PostAsJsonAsync("letter", letter).Result)
            {
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return response.Content.ReadAsAsync<Letter>().Result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public void DelLetter(Guid id)
        {
            _client.DeleteAsync("letter/" + Convert.ToString(id));
        }

        public List<Letter> GetLettersOrderByName()
        {
            return _client.GetAsync($"letters/orderByName").Result.Content.ReadAsAsync<List<Letter>>().Result;
        }

        public List<Letter> GetLettersOrderByDate()
        {
            return _client.GetAsync($"letters/orderByDate").Result.Content.ReadAsAsync<List<Letter>>().Result;
        }
        public List<Letter> GetLettersOrderBySender()
        {
            return _client.GetAsync($"letters/orderBySender").Result.Content.ReadAsAsync<List<Letter>>().Result;
        }

        public Letter GetLetter(Guid id)
        {
            return _client.GetAsync($"letter/{id}").Result.Content.ReadAsAsync<Letter>().Result;
        }

        public List<string> GetReceivers(Guid id)
        {
            return _client.GetAsync($"letter/{id}/receivers").Result.Content.ReadAsAsync<List<string>>().Result;
        }

        public string GetSender(Guid id)
        {
            return _client.GetAsync($"letter/{id}/sender").Result.Content.ReadAsAsync<string>().Result;
        }

        public User GetWorker(string login)
        {
            using (var response = _client.GetAsync($"worker/{login}").Result)
            {
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return response.Content.ReadAsAsync<User>().Result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }

            }
        }

        public List<User> GetWorkers()
        {
            return _client.GetAsync("workers").Result.Content.ReadAsAsync<List<User>>().Result;
        }

        public User CreateWorker(User worker)
        {
            using (var response = _client.PostAsJsonAsync("worker", worker).Result)
            {
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return response.Content.ReadAsAsync<User>().Result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }

            }
        }

        public Letter UpdateSingleValue<T> (Guid id, T newValue, string field)
        {
            using (var response = _client.PutAsJsonAsync($"letter/{id}/" + field, newValue).Result)
            {
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var letter = response.Content.ReadAsAsync<Letter>().Result;
                    return letter;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public void DeleteLetter(Guid id)
        {
            _client.DeleteAsync($"letter/{id}");
        }

    }
}
