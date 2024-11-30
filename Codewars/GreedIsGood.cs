using System.Collections.Generic;
using System.Linq;

namespace Codewars;

public static class GreedIsGood
{
    private static readonly Dictionary<(int Value, int Amount), int> Rules = new()
    { 
        { (1,3), 1000 },
        { (6,3), 600 },
        { (5,3), 500 },
        { (4,3), 400 },
        { (3,3), 300 },
        { (2,3), 200 },
        { (1,1), 100 },
        { (5,1), 50 }
    };

    private class DiceGroup
    {
        public int Value { get; init; }
        public int Count { get; set; }
    }

    public static int Score(int[] dice)
    {
        var score = 0;
        var sorted = dice.GroupBy(x => x).Select(x => new DiceGroup { Value = x.Key, Count = x.Count() }).ToList();

        var stop = false;
        while(sorted.Count > 0 && ! stop)
        {
            stop = true;
            foreach (var rule in Rules)
            {
                var found = sorted.FirstOrDefault(x => x.Value == rule.Key.Value && x.Count >= rule.Key.Amount);
                if (found != null)
                {
                    score += rule.Value;
                    found.Count -= rule.Key.Amount;
                    if(found.Count == 0) sorted.Remove(found);
                    stop = false;
                }
            }
        }

        return score;
    }
}
