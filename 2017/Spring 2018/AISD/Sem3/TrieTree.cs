using System;

namespace TrieTree
{
    class TrieTree<T>
    {
        TreeNode<T> Root = new TreeNode<T>(false);

        public void Add(string key, T value)
        {
            TreeNode<T> current = Root;
            foreach (char c in key)
            {
                if (current.Childs[c] == null) current.Childs[c] = new TreeNode<T>(false);
                current = current.Childs[c];
            }
            current.Value = value;
            current.HasValue = true;
        }

        public T GetValue(string key)
        {
            TreeNode<T> current = Root;
            foreach (var c in key)
            {
                if (current.Childs[c] == null)
                    throw new ArgumentException();
                current = current.Childs[c];
            }
            if (current.HasValue)
                return current.Value;
            else
                throw new ArgumentException();
        }

        public void Remove(string key)
        {
            TreeNode<T> current = Root;
            foreach (var c in key)
            {
                if (current.Childs[c] == null)
                    throw new ArgumentException();
                current = current.Childs[c];
            }
            current.HasValue = false;
            current.Value = default(T);
        }
    }
}
