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
        protected T RemoveChild(T child);
        protected bool TryRemoveChild(T child);
        protected T ClearChildren();
        protected bool TryRemoveOwn();
        protected T RemoveOwn();
    }
}
