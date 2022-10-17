

namespace BehaviorTree.Interfaces
{
    public interface IComposite : INode
    {
        void AddChild(INode node);
    }
}