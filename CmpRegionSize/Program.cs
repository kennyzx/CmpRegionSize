using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmpRegionSize
{
    class Program
    {
        //22B14C ED1C24
        static void Main(string[] args)
        {
            unchecked
            {
                int REDColor = (int)0xFFED1C24;
                int GREENColor = (int)0xFF22B14C;
                int countREDDot = 0;
                int countGREENDot = 0;
                Bitmap bitmap = (Bitmap)Image.FromFile("cmp.png");
                for (int i = 0; i < bitmap.Width; i++)
                {
                    for (int j = 0; j < bitmap.Height; j++)
                    {
                        Color c = bitmap.GetPixel(i, j);
                        if (c.ToArgb() == REDColor)
                        {
                            countREDDot++;
                        }
                        else if (c.ToArgb() == GREENColor)
                        {
                            countGREENDot++;
                        }
                    }
                }
            }
        }
    }
}
