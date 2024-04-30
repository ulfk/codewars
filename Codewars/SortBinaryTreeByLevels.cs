using System.Collections.Generic;
using System.Linq;

namespace Codewars;

// https://www.codewars.com/kata/52bef5e3588c56132c0003bc/train/csharp
public static class SortBinaryTreeByLevels
{
    #region FirstVersion
    public static List<int> TreeByLevels_FirstVersion(Node node)
    {
        var nodeLevels = new List<(Node node, int level)>();
        var result = new List<int>();

        var maxLevel = Traverse(0, node, nodeLevels);
        for (int level = 0; level <= maxLevel; level++)
        {
            result.AddRange(nodeLevels.Where(n => n.level == level).Select(n => n.node.Value));
        }

        return result;
    }

    private static int Traverse(int level, Node node, List<(Node node, int level)> nodeLevels)
    {
        if (node == null) return -1;
        nodeLevels.Add((node, level));
        var left = Traverse(level + 1, node.Left, nodeLevels);
        var right = Traverse(level + 1, node.Right, nodeLevels);
        var max = left > right ? left : right;
        return max != -1 ? max : level;
    }
    #endregion

    #region SecondVersion
    public static List<int> TreeByLevels(Node node)
    {
        var queue = new Queue<Node>();
        var result = new List<int>();

        queue.Enqueue(node);

        while (queue.Count > 0)
        { 
            var currNode = queue.Dequeue();
            result.Add(currNode.Value);
            if (currNode.Left != null) queue.Enqueue(currNode.Left);
            if (currNode.Right != null) queue.Enqueue(currNode.Right);
        }

        return result;
    }
    #endregion

    public class Node
    {
        public Node Left;
        public Node Right;
        public int Value;

        public Node(Node l, Node r, int v)
        {
            Left = l;
            Right = r;
            Value = v;
        }
    }
}

