using DictionaryRepository.Models;
using System;
using System.Data.Entity;

namespace DictionaryRepository
{
    public class DictionaryContext : DbContext
    {
        public DbSet<Sentence> Sentences { get; set; }
    }
}
