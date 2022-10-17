

namespace BehaviorTree.Tests
{
    public class BehaviorTreeTests
    {
        private BehaviorTreeFactory _factory;
        private IBlackBoard _board;

        [SetUp]
        public void Setup()
        {
            _board = new BlackBoard();
            _factory = new BehaviorTreeFactory(_board);
        }

        [Test]
        public void ShouldSetHelloWorldUsingTaskInBlackBoard()
        {
            INode root = _factory.Root;
            _factory.AddTask(root, (board) => board.SetValue("Hello", "World"));
            BehaviorTree tree = _factory.Create();
            tree.Traverse();
            Assert.AreEqual("World", _board.GetValue<string>("Hello"));
        }

        [Test]
        public void ShouldOverridSetHelloWorldByUsingSecondTaskInBlackBoard()
        {
            INode root = _factory.Root;
            var sequence = _factory.AddSequence(root);
            _factory.AddTask(sequence, (board) => board.SetValue("Hello", "World"));
            _factory.AddTask(sequence, (board) => board.SetValue("Hello", "World2"));
            BehaviorTree tree = _factory.Create();
            tree.Traverse();
            Assert.AreEqual("World2", _board.GetValue<string>("Hello"));
        }
    }
}
