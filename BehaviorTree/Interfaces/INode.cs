

namespace BehaviorTree.Interfaces
{
    public interface INode
    {
        INode Parent { get; set; }
        IBlackBoard Board { get; set; }
        bool ShouldExecute();
        void AddDecorator(Predicate<IBlackBoard> decoratorFn);
        void Invoke();
    }
}
