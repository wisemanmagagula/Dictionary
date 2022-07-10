
using Dictionary.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dictionary.Test
{
    [TestClass]
    public class DictionaryTest
    {

        private DictionaryService _dictionaryService;

        [TestInitialize()]
        public void Setup()
        {
            _dictionaryService = new DictionaryService();
        }

        [TestMethod]
        public void GetWordTypes_Should_Return_Words_Containing_Verbs()
        {
            //Arrange
            var expected = "Verbs";

            //Act
            var results = _dictionaryService.GetWordTypes();

            //Assert
            Assert.IsNotNull(results);
            Assert.IsTrue(results.Contains(expected));
        }
    }
}