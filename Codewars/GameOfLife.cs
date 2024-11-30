
namespace Codewars
{
    // https://www.codewars.com/kata/52423db9add6f6fc39000354

    public class GameOfLife
    {
        public static int[][] GameOfLive(int[][] universe, int generations)
        {
            var xlen = universe.GetLength(0);
            var ylen = universe.GetLength(1);

            var next = CreateUniverse(xlen + 2, ylen + 2);
            for (var x = -1; x < xlen + 1; x++)
            {
                for (var y = -1; y < ylen + 1; y++)
                {
                    var neighbors = CountNeighbors(universe, xlen, ylen, x, y);
                    if (TryGet(universe, xlen, ylen, x, y) == 1)
                    {
                        if (neighbors == 2 || neighbors == 3)
                            next[x][y] = 1;
                    }
                    else
                    {
                        if(neighbors == 3)
                            next[x][y] = 1;
                    }
                }
            }

            next = CropZeros(next);

            return next;
        }

        private static int[][] CropZeros(int[][] universe)
        {
            //TODO
            //while()

            return universe;
        }

        private static int CountNeighbors(int[][] universe, int xlen, int ylen, int x, int y)
        {
            var lives = 0;
            for (var chkX = -1; chkX < 2; chkX++)
            {
                for (var chkY = -1; chkY < 2; chkY++)
                {
                    var theX = chkX + x;
                    var theY = chkY + y;
                    if (TryGet(universe,xlen,ylen,theX,theY) == 1 && (chkX != 0 || chkY != 0))
                        lives++;
                }
            }

            return lives;
        }

        private static int TryGet(int[][] universe, int xlen, int ylen, int x, int y)
        {
            if (x >= 0 && x < xlen && y >= 0 && y < ylen)
                return universe[x][y];
            return 0;
        }

        private static int[][] CreateUniverse(int dimX, int dimY)
        {
            var result = new int[dimX][];
            for (int x = 0; x < dimX; x++)
            {
                result[x] = new int[dimY];
            }

            return result;
        }
    }
}
