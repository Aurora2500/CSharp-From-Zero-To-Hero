using System;

namespace BootCamp.Chapter
{
    public class ToggleableGrid2D : IToggleableGrid
    {
        bool[,] boolGrid;
        const char offChar = ' ';
        const char onChar = '■';

        public ToggleableGrid2D(bool[,] toggles)
        {
            boolGrid = toggles;
            updateScreen();
        }

        public void Toggle(int x, int y)
        {
            boolGrid[x, y] = !boolGrid[x, y];
            updateScreen();
        }

        void updateScreen()
        {
            Console.Clear();
            for (int x = 0; x < boolGrid.GetLength(0); x++)
            {
                for (int y = 0; y < boolGrid.GetLength(1); y++)
                {
                    Console.Write(boolGrid[x, y] ? onChar : offChar);
                }
                Console.Write(Environment.NewLine);
            }
        }
    }
}