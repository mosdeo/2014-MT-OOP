using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class PinBoard
    {
        public int Rows = 10;
        public int Cols = 10;
        public double xInterval = 1;
        public double yInterval = 1;
        public MyPoint_C[,] PinArray = null;

        public void CreatePins()
        {
            PinArray = new MyPoint_C[Rows, Cols];

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    PinArray[i, j] = new MyPoint_C();
                }
            }
        }

        public void SetPinPositions()
        {
            for (int i = 0; (i * xInterval) < Rows; i++)
            {
                for (int j = 0; (j * yInterval) < Cols; j++)
                {
                    PinArray[i, j].X = i * xInterval;
                    PinArray[i, j].Y = j * yInterval;
                }
            }
        }
    }
}
