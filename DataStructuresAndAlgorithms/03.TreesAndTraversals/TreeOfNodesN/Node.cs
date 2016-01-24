namespace TreeOfNodesN
{
    using System.Collections.Generic;

    public class Node<T>
    {
        public Node(T value, List<Node<T>> childNodes)
        {
            this.Value = value;
            this.ChildNodes = childNodes;
        }

        public Node(T value)
            : this(value, new List<Node<T>>())
        {
        }

        public T Value { get; set; }

        public List<Node<T>> ChildNodes { get; private set; }

        public void AddChildNode(Node<T> childNode)
        {
            this.ChildNodes.Add(childNode);
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}
