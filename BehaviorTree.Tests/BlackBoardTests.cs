
namespace BehaviorTree.Tests
{
    public class BlackboardTests
    {
        private IBlackBoard _blackBoard;

        [SetUp]
        public void Setup()
        {
            _blackBoard = new BlackBoard();
        }

        [TestCase("Hello", "World")]
        [TestCase("Int", 1)]
        [TestCase("Boolean", true)]
        public void ShouldGetAndCorrectGenericValueFromBlackBoardTest<T>(string keyName, T expectedValue)
        {
            _blackBoard.SetValue(keyName, expectedValue);
            Assert.AreEqual(expectedValue, _blackBoard.GetValue<T>(keyName));
        }
    }
}