using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars;

/// <summary>
/// https://www.codewars.com/kata/56882731514ec3ec3d000009
/// </summary>
public static class ConnectFour
{
    private const int Draw = 0;
    private const int Red = 1;
    private const int Yellow = 2;
    private const int Rows = 6;
    private const int Columns = 7;
    private static readonly string[] Players = { "Draw", "Red", "Yellow" };

    public static string Play(List<string> moves)
    {
        // init
        int[][] grid = new int[Rows][];
        for(var row = 0; row < Rows; row++) grid[row] = new int[Columns];

        // execute moves
        foreach (var move in moves)
        {
            var column = move[0] - 'A';
            var player = move[2] == 'R' ? Red : Yellow;

            // let piece "fall" down the rows and get row where it "lands"
            var row = 0;
            for (var r = 0; r < Rows; r++)
            {
                if (r == Rows - 1 || grid[r + 1][column] != 0)
                {
                    grid[r][column] = player;
                    row = r;
                    break;
                }
            }

            PrintGrid(grid);

            // horizontal check
            var start = column;
            var end = column;
            while (IsPlayer(grid, row, start - 1, player, () => start--));
            while (IsPlayer(grid, row, end + 1, player, () => end++));
            if (end - start >= 3) 
                return Players[player];

            // vertical check
            start = row;
            while (IsPlayer(grid,start + 1, column, player, () => start++));
            if (start - row >= 3) 
                return Players[player];

            // diagonal check forward slash
            var startRow = row;
            var tempCol = column;
            while (IsPlayer(grid, startRow + 1, tempCol - 1, player, () => { startRow++; tempCol--; }));
            var endRow = row;
            tempCol = column;
            while (IsPlayer(grid, endRow - 1, tempCol + 1, player, () => { endRow--; tempCol++; }));
            if (startRow - endRow >= 3) 
                return Players[player];

            // diagonal check back slash
            startRow = row;
            tempCol = column;
            while (IsPlayer(grid, startRow + 1, tempCol + 1, player, () => { startRow++; tempCol++; }));
            endRow = row;
            tempCol = column;
            while (IsPlayer(grid, endRow - 1, tempCol - 1, player, () => { endRow--; tempCol--; }));
            if (startRow - endRow >= 3) 
                return Players[player];
        }

        return Players[Draw];
    }

    private static bool IsPlayer(int[][] grid, int row, int column, int player, Action action)
    {
        var valid = row >= 0 && row < Rows 
                 && column >= 0 && column < Columns 
                 && grid[row][column] == player;
        if (valid) action();
        return valid;
    }

    private static void PrintGrid(int[][] grid)
    {
        Console.WriteLine("*********************");
        for(int row = 0; row < Rows; row++)
        {
            Console.WriteLine(string.Join("",grid[row].Select(c => c switch { Red => " R ", Yellow => " Y ", _ => "   " })));
        }
    }
}
