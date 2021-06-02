using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatörler
{
    class Point
    {
        public int x { get; set; }
        public int y { get; set; }
        public Point()
        {

        }
        
        public Point(int c_x, int c_y)
        {
            x = c_x;
            y = c_y;
        }
        public static Point operator +(Point p1, Point p2)
        {
            Point dummyPoint = new Point();
            dummyPoint.x = p1.x + p2.x;
            dummyPoint.y = p1.y + p2.y;
            return dummyPoint;
        }
        public static Point operator -(Point p1, Point p2)
        {
            Point dummyPoint = new Point();
            //Eksi değerler kontrol edilebilir.
            dummyPoint.x = p1.x - p2.x;
            dummyPoint.y = p1.y - p2.y;
            return dummyPoint;
        }
        // ToString
        public override string ToString() // x ve y int olduğu için ikisi içinde ToString kullanmak yerine ToString override yapıldı.
        {
            string dummyString = "";
            dummyString = string.Format("[{0},{1}]",this.x, this.y); // x ve y yi string formatına dönüştürüyor.
            return dummyString;
        }
        public override bool Equals(object o)
        {
            return o.ToString() == this.ToString();
        }
        public static bool operator ==(Point p1, Point p2)
        {
            return p1.Equals(p2);
        }
        public static bool operator !=(Point p1, Point p2)
        {
            return !p1.Equals(p2);
        }
        public int CompareTo(Point other)
        {
            if (this.x > other.x && this.y > other.y)
                return 1;
            if (this.x < other.x && this.y < other.y)
                return -1;
            else
                return 0;
        }
        public static bool operator <(Point p1, Point p2)
        {
            return (p1.CompareTo(p2) < 0);
        }
        public static bool operator <= (Point p1, Point p2)
        {
            return (p1.CompareTo(p2) <= 0);
        }
        public static bool operator >(Point p1, Point p2)
        {
            return (p1.CompareTo(p2) > 0);
        }
        public static bool operator >=(Point p1, Point p2)
        {
            return (p1.CompareTo(p2) >= 0);
        }

    }
}
