using System;
using System.Collections.Generic;
using System.Text;

namespace RBTree
{
    interface ITreeNode<T>
    {
        T Parent { get; set; }
        IList<T> Children { get; set; }

        protected T AddChild(T child);
        protected bool TryRemoveChild(T child);
        protected T RemoveOwn();
    }
}
