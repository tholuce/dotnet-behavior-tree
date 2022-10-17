

namespace BehaviorTree.Interfaces
{
    public interface ITask : INode
    {
        Action<IBlackBoard> Execute { get; set; }
    }
}