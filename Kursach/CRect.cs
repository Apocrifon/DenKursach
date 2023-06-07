using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    internal class CRect : IComparable<CRect>
    {
        public double width { get; private set; }
        public double height { get; private set; }
        public string color  { get; private set; }
        public static CRect MaxSquare { get;  set; } = null;

        public CRect(double width, double heigth, string color)
        {
            this.width = width;
            this.height = heigth;
            this.color = color;
            if (MaxSquare == null)
                MaxSquare = this;
            else if (this.CompareTo(MaxSquare) > 0)
                MaxSquare = this;
        }


        public double Square()
        {
            return width * height;
        }

        public double Perimetr()
        {
            return 2* (width+height);
        }

        public void ChangeProperties(double width, double heigth, string color) 
        {
            this.width = width;
            this.height = heigth;
            this.color = color;
            if (this.CompareTo(MaxSquare) > 0)
                MaxSquare = this;
        }

        public int CompareTo(CRect? rect)
        {
            if (Square() > rect.Square())
                return 1;
            if (Square() < rect.Square())
                return -1;
            return 0;
        }
    }
}
