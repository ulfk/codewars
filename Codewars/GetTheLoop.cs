﻿using System.Collections.Generic;
using System.Linq;

namespace Codewars
{
    public class GetTheLoop
    {
        // https://www.codewars.com/kata/52a89c2ea8ddc5547a000863

        public class Node
        {
            public Node Next { get; set; }
        }

        private class NodeItem(Node node, int index)
        {
            public Node Node { get; } = node;
            public int Index { get; } = index;

            public override bool Equals(object obj)
            {
                return Node.Equals(((NodeItem)obj)?.Node);
            }

            public override int GetHashCode()
            {
                return Node.GetHashCode();
            }
        }

        public static int GetLoopSize(Node startNode)
        {
            var items = new HashSet<NodeItem>();
            var index = 0;
            var item = new NodeItem(startNode, index);
            while (item.Node != null && !items.Contains(item))
            {
                items.Add(item);
                index++;
                item = new NodeItem(item.Node.Next, index);
            }

            var branch = items.Single(n => n.Equals(item));
            return items.Count - branch.Index;
        }
    }
}
