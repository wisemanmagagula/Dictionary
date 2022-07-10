using Dictionary.Services.Interfaces;
using DictionaryRepository;
using DictionaryRepository.Models;

namespace Dictionary.Services
{
    public class DictionaryService : IDictionary
    {
        public List<Sentence> CreateSentence(string sentence)
        {
            using (var dbContext = new DictionaryDB())
            {
                dbContext.Sentences.Add(new Sentence { Data = sentence, CreatedOn = DateTime.Now });
                dbContext.SaveChanges();
                return dbContext.Sentences.ToList();
            }
        }

        public string GetSentenceById(int id)
        {
            using (var dbContext = new DictionaryDB())
            {
                var data = dbContext.Sentences.Where(s => s.SentenceId == id).FirstOrDefault();
                if (data != null)
                    return data.Data;
                return null;
            }
        }

        public List<string> GetWordsByType(string type)
        {
            if (string.IsNullOrEmpty(type))
                throw new ArgumentException("Please provide valid type");
            return Helpers.Dictionary.WordsByType[type];
        }

        public List<string> GetWordTypes()
        {
            return Helpers.Dictionary.WordTypes;
        }
    }
}
