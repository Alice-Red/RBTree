using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using RBTree;
using System.ComponentModel.Design.Serialization;

namespace RUtil.Collections
{
    public class BTree<TKey, TValue> : ITreeNode<BTree<TKey, TValue>>, ITree<TKey, TValue>, IEnumerable<TValue> where TKey : IComparable
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
        BTree<TKey, TValue> ITreeNode<BTree<TKey, TValue>>.Parent { get; set; }
        IList<BTree<TKey, TValue>> ITreeNode<BTree<TKey, TValue>>.Children { get; set; }

        public int MaxBranchCount { get; set; } = 2;

        public bool IsRoot { get; }

        public ITree<TKey, TValue> Delete(TKey target) {
            throw new NotImplementedException();
        }

        public TValue Get(TKey target) {
            throw new NotImplementedException();
        }

        public IEnumerator<TValue> GetEnumerator() {
            throw new NotImplementedException();
        }

        public ITree<TKey, TValue> Insert(TKey key, TValue value) {
            throw new NotImplementedException();
        }

        public bool Search(TKey target) {
            throw new NotImplementedException();
        }

        BTree<TKey, TValue> ITreeNode<BTree<TKey, TValue>>.AddChild(BTree<TKey, TValue> child) {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            throw new NotImplementedException();
        }

        BTree<TKey, TValue> ITreeNode<BTree<TKey, TValue>>.RemoveOwn() {
            throw new NotImplementedException();
        }

        bool ITreeNode<BTree<TKey, TValue>>.TryRemoveChild(BTree<TKey, TValue> child) {
            throw new NotImplementedException();
        }

    }
}
