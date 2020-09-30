using System;

namespace Hazifeladat1
{
    struct Plotter
    {
        public int PenNum;
        public int PaperLength;
        public int PaperWidth;
        public int MaxSpeed;

        public int CalculatePrice()
        {
            return PenNum * 1000 + PaperLength * 500 + PaperWidth * 500 + MaxSpeed * 20;
        }

        public override string ToString()
        {
            return String.Format("Price: {0} HUF", CalculatePrice());
        }
    }
}
