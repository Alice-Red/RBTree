using System;
using System.Collections.Generic;
using System.Text;

namespace RBTree
{
    public abstract class TreeNodeBase<T>
    {
        protected T Parent { get; set; }
        protected IList<T> Children { get; set; }

        protected abstract T AddChild(T child);
        protected abstract bool TryRemoveChild(T child);
        protected abstract T RemoveOwn();
    }
}
