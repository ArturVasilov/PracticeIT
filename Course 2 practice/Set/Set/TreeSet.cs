using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set
{
    class TreeSet<T> : Set<T> where T : IComparable<T>
    {
        private class Leaf
        {
            public T data;
            public Leaf left;
            public Leaf right;

            public Leaf(T data, Leaf left, Leaf right)
            {
                this.data = data;
                this.left = left;
                this.right = right;
            }
        }

        private Leaf root;

        private int Count { get; set; }
        
        public TreeSet()
        {
            Count = 0;
        }

        public TreeSet(T element)
        {
            add(element);
        }

        public TreeSet(params T[] elements)
        {
            addAll(elements);
        }

        public bool add(T element)
        {
            return add(element, root);
        }

        private bool add(T element, Leaf current)
        {
            if (current == null)
            {
                root = new Leaf(element, null, null);
                Count++;
                return true;
            }
            if (current.data.Equals(element))
            {
                return false;
            }
            if (element.CompareTo(current.data) < 0)
            {
                if (current.left == null)
                {
                    current.left = new Leaf(element, null, null);
                    Count++;
                    return true;
                }
                else
                {
                    return add(element, current.left);
                }
            }
            else
            {
                if (current.right == null)
                {
                    current.right = new Leaf(element, null, null);
                    Count++;
                    return true;
                }
                else
                {
                    return add(element, current.right);
                }
            }
        }

        public bool remove(T element)
        {
            return remove(element, null, true, root);
        }

        private bool remove(T element, Leaf parent, bool left, Leaf current)
        {
            if (Count == 0)
            {
                return false;
            }
            if (Count == 1)
            {
                if (root.data.Equals(element))
                {
                    root = null;
                    Count = 0;
                    return true;
                }
                return false;
            }
            if (current.data.Equals(element))
            {
                if (current.left == null && current.right == null)
                {
                    if (left)
                    {
                        parent.left = null;
                    }
                    else
                    {
                        parent.right = null;
                    }
                    Count--;
                    return true;
                }
                else if (current.left == null)
                {
                    current.data = current.right.data;
                    current.left = current.right.left;
                    current.right = current.right.right;
                    Count--;
                    return true;
                }
                else if (current.right == null)
                {
                    current.data = current.left.data;
                    current.right = current.left.right;
                    current.left = current.left.left;
                    Count--;
                    return true;
                }
                else
                {
                    Leaf temp = current.left;
                    if (temp.right == null)
                    {
                        current.data = temp.data;
                        current.left = temp.left;
                        Count--;
                        return true;
                    }
                    current.data = temp.right.data;
                    return remove(element, temp, false, temp.right);
                }
            }
            if (element.CompareTo(current.data) < 0)
            {
                if (current.left == null)
                {
                    return false;
                }
                else
                {
                    return remove(element, current, true, current.left);
                }
            }
            else
            {
                if (current.right == null)
                {
                    return false;
                }
                else
                {
                    return remove(element, current, false, current.right);
                }
            }
        }

        public bool contains(T element)
        {
            return contains(element, root);
        }

        private bool contains(T element, Leaf current)
        {
            if (current == null)
            {
                return false;
            }
            if (current.data.Equals(element))
            {
                return true;
            }
            return element.CompareTo(current.data) < 0 ? contains(element, current.left) : contains(element, current.right);
        }

        public bool addAll(IEnumerable<T> collection)
        {
            bool isAllAdded = true;
            foreach (T element in collection)
            {
                bool b = add(element);
                if (isAllAdded == true)
                {
                    isAllAdded = b;
                }
            }
            return isAllAdded;
        }

        public bool removeAll(IEnumerable<T> collection)
        {
            bool isAllRemoved = true;
            foreach (T element in collection)
            {
                bool b = remove(element);
                if (isAllRemoved == true)
                {
                    isAllRemoved = b;
                }
            }
            return isAllRemoved;
        }

        public bool containsAll(IEnumerable<T> collection)
        {
            foreach (T element in collection)
            {
                if (!contains(element))
                {
                    return false;
                }
            }
            return true;
        }

        public bool isEmpty()
        {
            return Count == 0;
        }

        public int size()
        {
            return Count;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            print(root, 0, false, ref builder);
            return builder.ToString();
        }

        private void print(Leaf current, int depth, bool left, ref StringBuilder builder)
        {
            if (current == null)
            {
                return;
            }
            if (left)
            {
                builder.Append("\n");
                for (int i = 0; i < depth - 1; i++)
                {
                    builder.Append("     ");
                }
                builder.Append("   \\  ");
            }
            builder.Append(current.data);
            if (current.right != null)
            {
                builder.Append(" - ");
                print(current.right, depth + 1, false, ref builder);
            }
            if (current.left != null)
            {
                print(current.left, depth + 1, true, ref builder);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new List<T>().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
