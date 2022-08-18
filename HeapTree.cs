using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapTree
{
    internal class HeapTree
    {
        internal class Node
        {
            public int Key { get; set; }
            public object Element { get; set; }
            public Node? Parent { get; set; }
            public Node? LeftChild { get; set; }
            public Node? RightChild { get; set; }
            public Node(int key, object element, Node parent)
            {
                Key = key;
                Element = element;
                Parent = parent;
            }
        }
        
        public class Heap
        {
            private Node Root { get; set; }
            private Node LastNode { get; set; }
            private Node InsertionNode { get; set; } 
            public int Size { get; set; }
            public Heap(int rootKey, object rootElement)
            {
                Root = new Node(rootKey, rootElement, null);
                InsertionNode = Root.LeftChild;
                InsertionNode.Parent = Root;
                LastNode = Root;
                Size = 1;
            }
            public bool IsEmpty()
            {
                return this.Size == 0;
            }
            public void Insert(object element, int key)
            {
                this.InsertionNode.Element = element;
                this.InsertionNode.Key = key;
                this.Size++;
                UpHeap();
                NewInsertionNode();
            }
            private void UpHeap()
            {

            }
            private void NewInsertionNode()
            {

            }
        }
    }
}
