using System;
using System.Collections.Generic;

namespace TrieTree
{
    class TreeNode<T>
    {
        public Dictionary<char, TreeNode<T>> Childs { get; set; }
        public T Value { get; set; }
        public bool HasValue { get; set; }

        public TreeNode(bool hasValue)
        {
            Childs = new Dictionary<char, TreeNode<T>>();
            HasValue = hasValue;
        }
    }
}
