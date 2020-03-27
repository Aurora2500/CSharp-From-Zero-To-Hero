using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            GridDemo();
        }

        static void GridDemo()
        {
            var boolGrid = new bool[6, 5] 
            { 
                {true, true, true, true, true },
                { false, false, true, false, false },
                { true, true, true, true, true},
                { false, false, true, false, false},
                { false, false, true, false, false},
                { false, false, true, false, false}
            };


            var grid = new ToggleableGrid2D(boolGrid);
            grid.Toggle(2, 2);
        }
    }
}
