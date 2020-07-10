using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using RBTree;

namespace RUtil.Collections
{
    public class BTree<T> :ITree<T>, IEnumerable<T> where T :IComparable
    {
        public bool Search(T target) {
            throw new NotImplementedException();
        }

        public ITree<T> Insert(T target) {
            throw new NotImplementedException();
        }

        public ITree<T> Delete(T target) {
            throw new NotImplementedException();
        }

        //private bool AddChild() {

        //}






        public IEnumerator<T> GetEnumerator() {
            throw new NotImplementedException();
        }


        IEnumerator IEnumerable.GetEnumerator() {
            throw new NotImplementedException();
        }
    }
}
