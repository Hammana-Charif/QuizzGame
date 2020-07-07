using System;
using System.Collections.Generic;
using System.Text;

namespace QuizzGame
{
    public class Dice
    {
        Random DiceDraw = new Random();
        int _nbFacets;

        public Dice()
        {
            DiceDraw = new Random();
            DiceDraw.Next(1, 7);
        }

        public Dice(int nbFacets)
        {
            _nbFacets = nbFacets;
        }

        public int Launch() => DiceDraw.Next(0, _nbFacets);
    }
}
