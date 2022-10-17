using BehaviorTree.Interfaces;


namespace BehaviorTree.Composites
{
    internal class SelectorComposite : BaseComposite
    {
        public SelectorComposite() : base()
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
                if(child.ShouldExecute())
                {
                    child.Invoke();
                    return;
                }
            }
        }
    }
}