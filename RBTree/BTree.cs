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
    public class BTree<TKey, TValue> : TreeNodeBase<BTree<TKey, TValue>>, ITree<TKey, TValue>, IEnumerable<TValue> where TKey : IComparable
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }

        public BTree() {
            Parent = null;
        }

        private BTree(TKey key, TValue value) : this() {
            Insert(key, value);
        }

        public void Add(TKey key, TValue value) {
            Insert(key, value);
        }

        public int MaxBranchCount { get; set; } = 2;

        private bool isRoot { get => (Parent == null); }

        public long Length(TKey key, long tmp) {
            throw new NotImplementedException();
        }

        public ITree<TKey, TValue> Delete(TKey target) {
            throw new NotImplementedException();
        }

        public TValue Get(TKey target) {
            throw new NotImplementedException();
        }

        public ITree<TKey, TValue> Insert(TKey key, TValue value) {
            throw new NotImplementedException();
        }

        public bool Search(TKey target) {
            throw new NotImplementedException();
        }

        protected override BTree<TKey, TValue> RemoveOwn() {
            throw new NotImplementedException();
        }

        protected override BTree<TKey, TValue> AddChild(BTree<TKey, TValue> child) {
            throw new NotImplementedException();
        }
        protected override bool TryRemoveChild(BTree<TKey, TValue> child) {
            throw new NotImplementedException();
        }

        public IEnumerator<TValue> GetEnumerator() {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            throw new NotImplementedException();
        }

    }
}
