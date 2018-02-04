using System;
using System.Collections.Generic;
using Registration.Model;

namespace Registration.DataInterface
{
    public interface ILetter
    {
        Letter Create(string nameLetter, List<Guid> recievers, Guid sender, string msg);

        List<Guid> GetIdReceivers(Guid id);
        List<string> GetReceivers(Guid id);
        string GetSender(Guid id);
        Letter Get(Guid id);

        List<Letter> GetLettersOrderBySender();
        List<Letter> GetLettersOrderByName();
        List<Letter> GetLettersOrderByDate();

        Letter ChangeLetterName(Guid id, string newName);
        Letter ChangeLetterText(Guid id, string newText);
        Letter ChangeLetterIdSender(Guid id, Guid newIdSender);
        Letter ChangeLetterReceivers(Guid id, List<Guid> newIdReceivers);

        void Delete(Guid id);
    }
}
