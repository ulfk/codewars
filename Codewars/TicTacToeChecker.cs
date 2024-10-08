using System.Linq;

namespace Codewars;

// https://www.codewars.com/kata/525caa5c1bf619d28c000335/train/csharp
public class TicTacToeChecker
{
    private  const int NotFinished = -1;
    private  const int Draw = 0;
    private readonly (int[] x, int[] y)[] _patterns = { 
        (new[] { 0, 0, 0 }, new[] { 0, 1, 2 }), 
        (new[] { 1, 1, 1 }, new[] { 0, 1, 2 }),
        (new[] { 2, 2, 2 }, new[] { 0, 1, 2 }),
        (new[] { 0, 1, 2 }, new[] { 0, 0, 0 }),
        (new[] { 0, 1, 2 }, new[] { 1, 1, 1 }),
        (new[] { 0, 1, 2 }, new[] { 2, 2, 2 }),
        (new[] { 0, 1, 2 }, new[] { 0, 1, 2 }),
        (new[] { 2, 1, 0 }, new[] { 0, 1, 2 })
    };

    private readonly int[] _players = { 1, 2 };
    
    public int IsSolved(int[,] board)
    {
        foreach (var (x,y) in _patterns)
        {
            foreach (var player in _players)
            {
                if (board[x[0], y[0]] == player && board[x[1],y[1]] == player && board[x[2],y[2]] == player)
                {
                    return player;
                }
            }
        }
        return board.Cast<int>().Any(x => x == 0) ? NotFinished : Draw;
    }
}