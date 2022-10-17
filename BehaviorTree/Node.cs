using BehaviorTree.Interfaces;

namespace BehaviorTree
{
    internal class Node : INode
    {
        private IEnumerable<Predicate<IBlackBoard>> _decorators;

        public INode Parent { get; set; }
       
        public IBlackBoard Board { get; set; }

        public Node()
        {
            _decorators = new List<Predicate<IBlackBoard>>();
        }

        public void AddDecorator(Predicate<IBlackBoard> decorator)
        {
            _decorators.Append(decorator);
        }

        public virtual void Invoke(){}

        public bool ShouldExecute()
        {
            if (!_decorators.Any())
            {
                return true;
            }
            return _decorators.Select(decorator => decorator(Board)).Any(el => el);
        }
    }
}
