using System;
using BehaviorTree.Interfaces;

namespace BehaviorTree
{
   public class BehaviorTree
    {

        INode _rootNode;

        public BehaviorTree(INode rootNode)
        {
            _rootNode = rootNode;
        }

        public void Traverse()
        {
            _rootNode.Invoke();
        }
    }
}