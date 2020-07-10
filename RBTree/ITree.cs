using System;
using System.Collections.Generic;
using System.Text;

namespace RBTree
{
    public interface ITree<T>
    {
        public bool Search(T target);

        public ITree<T> Insert(T target);

        public ITree<T> Delete(T target);

    }
}
