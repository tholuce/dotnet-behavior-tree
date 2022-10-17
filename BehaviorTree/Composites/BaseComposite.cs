using System.Collections.Generic;
using BehaviorTree.Interfaces;


namespace BehaviorTree.Composites
{
    internal class BaseComposite: Node, IComposite
    {
        
        private ICollection<INode> _childs;

        protected ICollection<INode> Childs => _childs;

        public BaseComposite(): base()
        {   
            _childs = new List<INode>();
        }

        public void AddChild(INode node)
        {
            _childs.Add(node);
        }
    }
}