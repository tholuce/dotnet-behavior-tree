using BehaviorTree.Interfaces;


namespace BehaviorTree.Composites
{
    internal class SequenceComposite : BaseComposite
    {
        public SequenceComposite() : base()
        {
        }

        public override void Invoke()
        {
            if (!ShouldExecute())
            {
                return;
            }
            foreach (INode child in Childs)
            {
                child.Invoke();
            }
        }
    }
}