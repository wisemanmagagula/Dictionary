using DictionaryRepository.Models;

namespace Dictionary.Services.Interfaces
{
    public interface IDictionary
    {
        List<string> GetWordTypes();

        List<string> GetWordsByType(string type);

        List<Sentence> CreateSentence(string sentence);

        string GetSentenceById(int id);
    }
}
