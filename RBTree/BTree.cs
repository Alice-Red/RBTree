using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using RBTree;
using System.ComponentModel.Design.Serialization;
using System.ComponentModel.DataAnnotations;

namespace RUtil.Collections
{
    public class BTree<TKey, TValue> : ITree<TKey, TValue>, IEnumerable<TValue> where TKey : IComparable
    {
        protected BTree<TKey, TValue> Parent { get; set; }

        protected BTree<TKey, TValue>[] Children { get; set; }

        public SortedDictionary<TKey, TValue> Values { get; private set; }

        public BTree() {
            Parent = null;
            Values = new SortedDictionary<TKey, TValue>();
            Children = new BTree<TKey, TValue>[MaxBranchCount];
        }

        private BTree(BTree<TKey, TValue> parent) : this() {
            Parent = parent;
        }

        private BTree(TKey key, TValue value, BTree<TKey, TValue> parent) : this() {
            Parent = parent;
            Insert(key, value);
        }

        public void Add(TKey key, TValue value) {
            Insert(key, value);
        }

        public int MaxBranchCount { get; set; } = 2;

        private bool isRoot { get => (Parent == null); }

        /// <summary>
        /// 指定されたキーの階層の深さを測ります。デバッグで使えるかもしれない
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public long Length(TKey key) {
            if (!Search(key))
                return 1;

            if (Values.ContainsKey(key))
                return 0;
            else {
                return 1 + SafeGetChildren(ChoiceChildren(key)).Length(key);
            }

        }

        public ITree<TKey, TValue> Delete(TKey target) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 指定されたキーの値を返します。これが本体だ
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public TValue Get(TKey key) {
            if (Values.ContainsKey(key))
                return Values[key];
            else if (Children.Count() == 0)
                return default;
            else
                return SafeGetChildren(ChoiceChildren(key)).Get(key);
        }

        /// <summary>
        /// キーと値のセットを登録します
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public ITree<TKey, TValue> Insert(TKey key, TValue value) {
            if (Values.ContainsKey(key))
                Values[key] = value;
            else if (Values.Count() < (MaxBranchCount / 2))
                Values.Add(key, value);
            else
                SafeGetChildren(ChoiceChildren(key)).Insert(key, value);
            return this;
        }

        /// <summary>
        /// 指定されたキーが存在するか調べます
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool Search(TKey key) {
            if (Values.ContainsKey(key))
                return true;
            else if (Children.All(s => s == null))
                return false;
            else
                return SafeGetChildren(ChoiceChildren(key)).Search(key);
        }

        /// <summary>
        /// キーに対し適切な子ノードの番号を返します
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private int ChoiceChildren(TKey key) {
            for (int i = 0; i < Values.Count(); i++)
                if (Values.ElementAt(i).Key.CompareTo(key) > 0)
                    return i;
            return Values.Count();
        }

        /// <summary>
        /// 子ノードがnullのまま参照されるのを防ぎます
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private BTree<TKey, TValue> SafeGetChildren(int index) {
            if (Children[index] == null)
                Children[index] = new BTree<TKey, TValue>(this);
            return Children[index];
        }

        //private BTree<TKey, TValue> TurnLeft() {

        //}

        //private BTree<TKey, TValue> TurnRight() {

        //}

        public IEnumerator<TValue> GetEnumerator() {
            foreach (var item in Values) {
                yield return item.Value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() {
            foreach (var item in Values) {
                yield return item.Value;
            }
        }
    }
}
