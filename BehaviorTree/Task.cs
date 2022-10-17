using BehaviorTree.Interfaces;

namespace BehaviorTree
{
    internal class Task : Node, ITask
    {
        public Action<IBlackBoard> Execute { get; set; }

        public Task():base(){ }

        public override void Invoke()
        {
            if(!ShouldExecute())
            {
                return;
            }

            if (Execute != null)
            {
                Execute(Board);
            }
        }
    }
}