using Dictionary.Services;
using DictionaryRepository;
using DictionaryRepository.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dictionary.Controllers
{
    public class DictionaryController : Controller
    {
        private DictionaryService _dictionaryService;

        public DictionaryController() //Inject service
        {
            _dictionaryService = new DictionaryService();
        }
        
        // GET: Words Types
        [HttpGet("get-word-type")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status200OK)]
        public ActionResult GetWordTypes()
        {
            return Ok(_dictionaryService.GetWordTypes());
        }

        // GET: Words Types
        [HttpGet("get-words-by-type/type")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status200OK)]
        public ActionResult GetWordsByType(string type)
        {
            return Ok(_dictionaryService.GetWordsByType(type));
        }

        [HttpPost("create-sentence/sentence")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(List<Sentence>), StatusCodes.Status200OK)]
        public ActionResult CreateSentence(string sentence)
        {
            return Ok(_dictionaryService.CreateSentence(sentence));
        }

        [HttpPost("get-sentence-by-id/id")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(List<Sentence>), StatusCodes.Status200OK)]
        public ActionResult GetSentenceById(int id)
        {
            return Ok(_dictionaryService.GetSentenceById(id));
        }

    }
}
