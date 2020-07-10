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
    public class BTree<T> : ITreeNode<BTree<T>>, ITree<BTree<T>>, IEnumerable<T> where T : IComparable
    {

        public BTree<T> Parent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IList<BTree<T>> Children { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        BTree<T> ITreeNode<BTree<T>>.Parent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        IList<BTree<T>> ITreeNode<BTree<T>>.Children { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Search(BTree<T> target) {
            throw new NotImplementedException();
        }
        public ITree<BTree<T>> Insert(BTree<T> target) {
            throw new NotImplementedException();
        }

        public ITree<BTree<T>> Delete(BTree<T> target) {
            throw new NotImplementedException();
        }






        BTree<T> ITreeNode<BTree<T>>.AddChild(BTree<T> child) {
            throw new NotImplementedException();
        }

        BTree<T> ITreeNode<BTree<T>>.RemoveChild(BTree<T> child) {
            throw new NotImplementedException();
        }

        bool ITreeNode<BTree<T>>.TryRemoveChild(BTree<T> child) {
            throw new NotImplementedException();
        }

        BTree<T> ITreeNode<BTree<T>>.ClearChildren() {
            throw new NotImplementedException();
        }

        bool ITreeNode<BTree<T>>.TryRemoveOwn() {
            throw new NotImplementedException();
        }

        BTree<T> ITreeNode<BTree<T>>.RemoveOwn() {
            throw new NotImplementedException();
        }



        public IEnumerator<T> GetEnumerator() {
            throw new NotImplementedException();
        }


        IEnumerator IEnumerable.GetEnumerator() {
            throw new NotImplementedException();
        }

    }
}
