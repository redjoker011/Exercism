using System;
using System.Linq;
using System.Collections.Generic;

public static class Dominoes
{
    public static bool CanChain(IEnumerable<(int, int)> dominoes)
    {
        var _dominoes = dominoes.ToList();

        if (_dominoes.Count == 0)
            return true;

        return CanChainRecursive(
            _dominoes.GetRange(1, _dominoes.Count - 1),
            _dominoes[0].Item1,
            _dominoes[0].Item2
        );
    }

    public static bool CanChainRecursive(List<(int, int)> dominoes, int first, int second)
    {
        if (dominoes.Count == 0)
            return first == second;

        for (int i = 0; i < dominoes.Count; i++)
        {
            (int, int) currentDomino = dominoes[i];

            // Check if the previous domino has matched sides with the current
            if (currentDomino.Item1 == first || currentDomino.Item2 == first)
            {
                var _doms = dominoes.ToList();
                _doms.RemoveAt(i); // Remove current list item


                // Check which side matches the previous domino and recursively
                //  try to match again
                if (currentDomino.Item1 == first)
                    if (CanChainRecursive(_doms, currentDomino.Item2, second))
                        return true;

                if (currentDomino.Item2 == first)
                    if (CanChainRecursive(_doms, currentDomino.Item1, second))
                        return true;
            }
        }
        return false;
    }
}
