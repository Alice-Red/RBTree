using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// 使わないかも
/// 
/// すみませんやっぱ使いますめっちゃ使います
/// 
/// </summary>
namespace RBTree
{
    class BTreeEnumerator<T> : IEnumerator<T>
    {
        public T Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose() {
            throw new NotImplementedException();
        }

        public bool MoveNext() {
            throw new NotImplementedException();
        }

        public void Reset() {
            throw new NotImplementedException();
        }
    }
}
