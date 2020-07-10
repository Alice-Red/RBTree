using System;
using System.Collections.Generic;
using System.Text;

namespace RBTree
{
    public interface ITree<TKey, TValue>
    {

        public bool Search(TKey target);

        public TValue Get(TKey target);

        public ITree<TKey, TValue> Insert(TKey key, TValue value);

        public ITree<TKey, TValue> Delete(TKey target);

    }
}
