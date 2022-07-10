using DictionaryRepository.Models;
using System;
using System.Data.Entity;

namespace DictionaryRepository
{
    public class DictionaryDB : DbContext
    {
        public DbSet<Sentence> Sentences { get; set; }
    }
}
