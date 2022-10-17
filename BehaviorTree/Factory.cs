using BehaviorTree.Interfaces;
using BehaviorTree.Composites;

namespace BehaviorTree
{
    public class BehaviorTreeFactory
    {

        private IComposite _root;
        public INode Root => _root;
        IBlackBoard _board;

        public BehaviorTreeFactory(IBlackBoard board)
        {
            _root = new SelectorComposite();
            _root.Board = board;
            _board = board;
        }

        public BehaviorTree Create()
        {
            return new BehaviorTree(_root);
        }

        public IComposite AddSelector(INode parent) => (IComposite)AddNode<SelectorComposite>(parent);
        public IComposite AddSequence(INode parent) => (IComposite)AddNode<SequenceComposite>(parent);
        public ITask AddTask(INode parent, Action<IBlackBoard> executeFn)
        {
            ITask task = (ITask)AddNode<Task>(parent);
            task.Execute = executeFn;
            return task;
        } 

        private INode AddNode<T>(INode parent) where T : INode
        {
            INode node = Activator.CreateInstance<T>();
            node.Board = _board;
            node.Parent = parent;
            if (parent is IComposite)
            {
                (parent as IComposite).AddChild(node);
            }
            return node;
        }
    }
}