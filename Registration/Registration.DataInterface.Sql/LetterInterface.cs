using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Registration.Model;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registration.DataInterface;

namespace Registration.DataInterface.Sql
{
    public class LetterInterface : ILetter
    {
        private readonly string _connectionString;

        public LetterInterface(string connectionString)
        {
            _connectionString = connectionString;
        }

        public Letter Create(string nameLetter, List<Guid> receivers, Guid sender, string msg)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    var letter = new Letter
                    {
                        id = Guid.NewGuid(),
                        idSender = sender,
                        idReceiver = new List<Guid>(),
                        date = DateTime.Now,
                        name = nameLetter,
                        text = msg
                    };

                    foreach (Guid receiver in receivers)
                    {
                        letter.idReceiver.Add(receiver);
                    }

                    using (var command = connection.CreateCommand())
                    {
                        command.Transaction = transaction;

                        command.CommandText = @"insert into Letter (id, name, date, idSender, text) values 
                                                                                (@id, @name, @date, @idSender, @text)";

                        command.Parameters.AddWithValue("@id", letter.id);
                        command.Parameters.AddWithValue("@name", letter.name);
                        command.Parameters.AddWithValue("@date", letter.date);
                        command.Parameters.AddWithValue("@idSender", letter.idSender);
                        command.Parameters.AddWithValue("@text", letter.text);

                        command.ExecuteNonQuery();

                        foreach (var receiver in receivers)
                        {
                            command.Transaction = transaction;
                            command.CommandText = "insert into ListOfReceivers (idLetter, idWorker) values (@idLetter, @idWorker)";

                            command.Parameters.AddWithValue("@idLetter", letter.id);
                            command.Parameters.AddWithValue("@idWorker", receiver);
                            command.ExecuteNonQuery();

                            command.Parameters.Clear();
                        }


                        transaction.Commit();

                        return letter;
                    }
                }
            }

        }

        public List<Guid> GetIdReceivers(Guid id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    List<Guid> idReceivers = new List<Guid>();
                    command.CommandText = "select idWorker from ListOfReceivers where idLetter = @idLetter";
                    command.Parameters.AddWithValue("@idLetter", id);
                    using (var reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            throw new ArgumentException($"Сообщения с таким id {id} нет!");
                        }
                        idReceivers.Add(reader.GetGuid(reader.GetOrdinal("idWorker")));

                        while (reader.Read())
                        {
                            idReceivers.Add(reader.GetGuid(reader.GetOrdinal("idWorker")));
                        }
                        return idReceivers;
                    }
                }
            }
        }

        public List<string> GetReceivers(Guid id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    List<Guid> idReceivers = GetIdReceivers(id);
                    List<string> receivers = new List<string>();

                    foreach (var idRec in idReceivers)
                    {
                        command.CommandText = "select name, login from Worker where id = @id";
                        command.Parameters.AddWithValue("@id", idRec);

                        using (var reader = command.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                throw new ArgumentException($"Пользователя с таким id {idRec} нет!");
                            }
                            receivers.Add(reader.GetString(reader.GetOrdinal("name")) + " (" + reader.GetString(reader.GetOrdinal("login")) + ')');

                            while (reader.Read())
                            {
                                receivers.Add(reader.GetString(reader.GetOrdinal("name")) + " (" + reader.GetString(reader.GetOrdinal("login")) + ')');
                            }
                        }
                        command.Parameters.Clear();

                    }
                    return receivers;
                }
            }

        }

        public string GetSender(Guid idLetter)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    var letter = Get(idLetter);

                    command.CommandText = "select name, login from Worker where id = @id";
                    command.Parameters.AddWithValue("@id", letter.idSender);

                    using (var reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            throw new ArgumentException($"Пользователя с таким id {letter.idSender} нет!");
                        }
                        return reader.GetString(reader.GetOrdinal("name")) + " (" + reader.GetString(reader.GetOrdinal("login")) + ')';
                    }
                }
            }
        }

        public Letter Get(Guid idLetter)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "select name, date, idSender, text from Letter where id = @idLetter";
                    command.Parameters.AddWithValue("@idLetter", idLetter);
                    using (var reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            throw new ArgumentException($"Сообщения с таким id {idLetter} нет!");
                        }
                        Letter letter = new Letter
                        {
                            id = idLetter,
                            name = reader.GetString(reader.GetOrdinal("name")),
                            idSender = reader.GetGuid(reader.GetOrdinal("idSender")),
                            text = reader.GetString(reader.GetOrdinal("text")),
                            date = reader.GetDateTime(reader.GetOrdinal("date")),
                            idReceiver = new List<Guid>()
                        };

                        var receivers = GetIdReceivers(idLetter);

                        foreach (var rec in receivers)
                        {
                            letter.idReceiver.Add(rec);
                        }
                        return letter;
                    }
                }
            }
        }

        List<Letter> GetLetterOrderBy(string commandText)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = commandText;

                    using (var reader = command.ExecuteReader())
                    {
                        List<Letter> letters = new List<Letter>();
                        while (reader.Read())
                        {
                            Letter letter = new Letter
                            {
                                id = reader.GetGuid(reader.GetOrdinal("id")),
                                name = reader.GetString(reader.GetOrdinal("name")),
                                idSender = reader.GetGuid(reader.GetOrdinal("idSender")),
                                date = reader.GetDateTime(reader.GetOrdinal("date")),
                                text = reader.GetString(reader.GetOrdinal("text")),
                                idReceiver = new List<Guid>()
                            };

                            var receivers = GetIdReceivers(letter.id);

                            foreach (var rec in receivers)
                            {
                                letter.idReceiver.Add(rec);
                            }
                            letters.Add(letter);
                        }
                        return letters;
                    }
                }
            }
        }

        public List<Letter> GetLettersOrderBySender()
        {
            string commandText = "select Letter.id, Letter.name, date, idSender, text from Letter join Worker on idSender = Worker.id order by Worker.name";
            return GetLetterOrderBy(commandText);
        }

        public List<Letter> GetLettersOrderByName()
        {
            string commandText = "select id, name, date, idSender, text from Letter order by name";
            return GetLetterOrderBy(commandText);
        }
        public List<Letter> GetLettersOrderByDate()
        {
            string commandText = "select id, name, date, idSender, text from Letter order by date";
            return GetLetterOrderBy(commandText);
        }

        public Letter ChangeLetter<T>(Guid id, string commandText, string nameColumn, T newValue)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = commandText;
                    command.Parameters.AddWithValue(nameColumn, newValue);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();

                    command.CommandText = "update Letter set date = @date where id = @id";
                    command.Parameters.AddWithValue("@date", DateTime.Now);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();

                    return Get(id);
                }
            }
        }

        public Letter ChangeLetterName(Guid id, string newName)
        {
            string commandText = "update Letter set name = @name where id = @id";
            string nameColumn = "@name";
            return ChangeLetter(id, commandText, nameColumn, newName);
        }

        public Letter ChangeLetterText(Guid id, string newText)
        {
            string commandText = "update Letter set text = @text where id = @id";
            string nameColumn = "@text";
            return ChangeLetter(id, commandText, nameColumn, newText);
        }

        public Letter ChangeLetterIdSender(Guid id, Guid newIdSender)
        {
            string commandText = "update Letter set idSender = @idSender where id = @id";
            string nameColumn = "@idSender";
            return ChangeLetter(id, commandText, nameColumn, newIdSender);
        }

        public Letter ChangeLetterReceivers(Guid id, List<Guid> newIdReceivers)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "delete from ListOfReceivers where idLetter = @id";
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();

                    foreach (var idRec in newIdReceivers)
                    {
                        command.CommandText = "insert into ListOfReceivers (idLetter, idWorker) values (@idLetter, @idWorker)";
                        command.Parameters.AddWithValue("@idLetter", id);
                        command.Parameters.AddWithValue("@idWorker", idRec);
                        command.ExecuteNonQuery();
                        command.Parameters.Clear();
                    }

                    return Get(id);
                }
            }
        }

        public void Delete(Guid id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "delete from ListOfReceivers where idLetter = @id";
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();

                    command.CommandText = "delete from Letter where id = @id";
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

