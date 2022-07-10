using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryRepository.Models
{
    public class Sentence
    {
        public int SentenceId { get; set; }
        public string Data { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
