using System;
using System.Collections.Generic;
using System.Linq;

namespace Codewars
{
    // https://www.codewars.com/kata/585894545a8a07255e0002f1

    public class ScreenLockPatterns
    {
        private class Position
        {
            public Position(int x, int y, char value)
            {
                X = x;
                Y = y;
                Value = value;
            }

            public int X { get; }
            public int Y { get; }
            public char Value { get; }
        }

        private class PathNode
        {
            private readonly PathNode _parent;
            private readonly List<PathNode> _children = new List<PathNode>();
            private readonly Position _position;

            public PathNode(Position position, PathNode parent = null)
            {
                _parent = parent;
                _position = position;
                _parent?._children.Add(this);
            }

            // scan tree to the top if given position is part of this path
            public bool IsNotOnPath(Position pos)
            {
                var current = this;
                while (current != null)
                {
                    if (current._position.Value == pos.Value)
                        return false;
                    current = current._parent;
                }

                return true;
            }

            // returns true if it's not a wide move or it is a valid wide move
            public bool IsNoWideMoveOrValidOne(Position pos)
            {
                if (!IsWideMove(pos))
                    return true;

                // the position in between needs to be already on the path

                var betweenX = (_position.X + pos.X) / 2;
                var betweenY = (_position.Y + pos.Y) / 2;
                var current = _parent;
                while (current != null)
                {
                    if (current._position.X == betweenX && current._position.Y == betweenY)
                        return true;
                    current = current._parent;
                }

                return false;
            }

            public int CountPaths()
            {
                return _children.Count == 0 ? 1 : _children.Sum(c => c.CountPaths());
            }

            public override string ToString()
            {
                return $"{_position.Value}";
            }

            private bool IsWideMove(Position to)
            {
                var xDiff = Math.Abs(_position.X - to.X);
                var yDiff = Math.Abs(_position.Y - to.Y);

                return    xDiff == 2 && yDiff != 1
                       || xDiff != 1 && yDiff == 2;
            }
        }

        private static readonly List<Position> Positions = new List<Position>
            {
                new Position(0, 0, 'A'),
                new Position(1, 0, 'B'),
                new Position(2, 0, 'C'),
                new Position(0, 1, 'D'),
                new Position(1, 1, 'E'),
                new Position(2, 1, 'F'),
                new Position(0, 2, 'G'),
                new Position(1, 2, 'H'),
                new Position(2, 2, 'I')
            };

        public static int CountPatternsFrom(char firstPoint, int length)
        {
            if (length == 0 || length >= 10)
                return 0;

            var node = new PathNode(Positions.First(p => p.Value == firstPoint));
            DoStep(node, 0, length);

            return node.CountPaths();
        }

        private static void DoStep(PathNode current, int depth, int maxDepth)
        {
            depth++;
            if (depth >= maxDepth)
                return;

            var possibleMoves = Positions.Where(p => current.IsNotOnPath(p)
                                                     && current.IsNoWideMoveOrValidOne(p));
            foreach (var possibleMove in possibleMoves)
            {
                DoStep(new PathNode(possibleMove, current), depth, maxDepth);
            }
        }
    }
}
