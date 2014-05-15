using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class EdgesLinkedList
    {
        /*
         * this is specific class for LinkedList for edges
         * there are no need to use library or my own class for this,
         * because I don't need a lot of functions for it
         */

        //Node class
        public class Refer
        {
            private Edge edge;
            private Refer next;
            private Refer previous;

            public Edge Edge
            {
                get { return edge; }
                set { edge = value; }
            }

            public Refer Next
            {
                get { return next; }
                set { next = value; }
            }

            public Refer Previous
            {
                get { return previous; }
                set { previous = value; }
            }

            public Refer(Edge edge)
            {
                Edge = edge;
                Next = null;
                Previous = null;
            }

            public Refer(Edge edge, Refer next, Refer previous)
            {
                Edge = edge;
                Next = next;
                Previous = previous;
            }
        }

        private int count = 0;

        private Refer firstElement;
        private Refer lastElement;

        private Refer current;
        private int currentIndex;

        public EdgesLinkedList()
        {
            count = 0;
            firstElement = null;
            lastElement = null;
            current = firstElement;
            currentIndex = 0;
        }

        public int size()
        {
            return count;
        }

        public bool isEmpty()
        {
            return size() == 0;
        }

        //add element to the end of the list
        public void append(Edge edge)
        {
            if (isEmpty())
            {
                count++;
                firstElement = new Refer(edge);
                lastElement = new Refer(edge);
            }

            else if (size() == 1)
            {
                count++;
                lastElement = new Refer(edge);
                firstElement.Next = lastElement;
                lastElement.Previous = firstElement;
            }

            else
            {
                count++;
                Refer insertElement = new Refer(edge);
                insertElement.Previous = lastElement;
                lastElement.Next = insertElement;
                lastElement = insertElement;
            }
        }

        public void removeBack()
        {
            if (isEmpty())
                throw new Exception("List is emtpy!");
            if (lastElement.Previous != null)
                lastElement.Previous.Next = null;
            lastElement = lastElement.Previous;
            count--;
        }

        public void removeFront()
        {
            if (isEmpty())
                throw new Exception("List is emtpy!");
            if (firstElement.Next != null)
                firstElement.Next.Previous = null;
            firstElement = firstElement.Next;
            count--;
        }

        //after removing one vertex, we should shift numbers of vertexes, which is higher
        public void setEdgesAfterRemovingVertex(int index)
        {
            current = firstElement;
            while (current != null)
            {
                if (current.Edge.First > index)
                    current.Edge.First -= 1;
                if (current.Edge.Second > index)
                    current.Edge.Second -= 1;
                current = current.Next;
            }
        }

        //after adding one vertex, we should shift numbers of vertexes, which is higher
        public void setEdgesAfterAddingVertex(int index)
        {
            current = firstElement;
            while (current != null)
            {
                if (current.Edge.First > index)
                    current.Edge.First += 1;
                if (current.Edge.Second > index)
                    current.Edge.Second += 1;
                current = current.Next;
            }
        }

        //returns array of edges, to quick sort
        public Edge[] ToArray()
        {
            Edge[] edges = new Edge[size()];
            Refer cur = firstElement;
            for (int i = 0; i < size(); i++)
            {
                edges[i] = cur.Edge;
                cur = cur.Next;
            }
            return edges;
        }

        public void remove(int index)
        {
            if (index < 0 || index >= size())
                throw new Exception("Index out of bounds exception!");

            if (index == 0)
                removeFront();

            else if (index == size() - 1)
                removeBack();

            else
            {
                Refer deleteRefer = getElement(index);

                deleteRefer.Previous.Next = deleteRefer.Next;
                deleteRefer.Next.Previous = deleteRefer.Previous;
                count--;
            }
        }

        //change weight of one edge
        public void change(int firstVertex, int secondVertex, int weight)
        {
            Edge edge = new Edge(firstVertex, secondVertex, weight);
            Refer cur = firstElement;
            for ( ; !cur.Edge.Equals(edge); cur = cur.Next) ;
            cur.Edge.Weigth = weight;
        }

        public bool contains(Edge edge)
        {
            Refer cur = firstElement;
            for (; cur != null && !cur.Edge.Equals(edge); cur = cur.Next) ;
            return cur != null;
        }

        public void clear()
        {
            while (!isEmpty())
                removeFront();
        }

        public Edge get(int index)
        {
            return getElement(index).Edge;
        }

        private Refer getElement(int index)
        {
            if (index < 0 || index >= size())
                throw new Exception("Index out of bounds exception!");

            //analize the shorter way - from begin or from end
            if (index < size() - index)
            {
                current = firstElement;
                currentIndex = 0;
                while (currentIndex < index)
                {
                    current = current.Next;
                    currentIndex++;
                }
            }

            else
            {
                current = lastElement;
                currentIndex = size() - 1;
                while (currentIndex > index)
                {
                    current = current.Previous;
                    currentIndex--;
                }
            }
            return current;
        }
        
    }
}