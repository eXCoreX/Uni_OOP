using System;
using System.Text;

namespace OOP_Lab_2
{
    public class Rectangle
    {
        protected struct Point : IComparable<Point>
        {
            public double x, y;
            public Point(double x, double y)
            {
                this.x = x;
                this.y = y;
            }

            int IComparable<Point>.CompareTo(Point other)
            {
                if (other.x == this.x)
                {
                    return this.y.CompareTo(other.y);
                }
                else
                {
                    return this.x.CompareTo(other.x);
                }
            }
        }


        protected Point[] vertices;
        protected double a, b; // side lengths


        public Rectangle(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            Point[] tmp_v = new Point[4];
            tmp_v[0] = new Point(x1, y1);
            tmp_v[1] = new Point(x2, y2);
            tmp_v[2] = new Point(x3, y3);
            tmp_v[3] = new Point(x4, y4);
            Array.Sort(tmp_v);
            if (CheckRect(tmp_v))
            {
                vertices = tmp_v;
                a = vertices[2].x - vertices[0].x;
                b = vertices[1].y - vertices[0].y;
            }
            else
            {
                throw new ArgumentException("Illegal rectangle");
            }
        }


        public double this[string side]
        {
            get
            {
                switch (side)
                {
                    case "a":
                        return a;
                    case "b":
                        return b;
                    default:
                        throw new ArgumentException(string.Format("Can't access {0} side, only a and b available", side));
                }
            }
        }


        public double Perimeter
        {
            get
            {
                return 2 * a + 2 * b;
            }
        }


        public double Area
        {
            get
            {
                return a * b;
            }
        }


        protected static bool CheckRect(Point[] verts)
        {
            return verts[0].x == verts[1].x &&
                verts[0].y != verts[1].y &&
                verts[0].y == verts[2].y &&
                verts[0].x != verts[2].x &&
                verts[2].x == verts[3].x &&
                verts[1].y == verts[3].y;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Vertices: ");
            foreach (var v in vertices)
            {
                sb.Append(string.Format("[{0}, {1}] ", v.x, v.y));
            }
            sb.Append(string.Format("a = {0} b = {1}", a, b));
            return sb.ToString();
        }


        public void InputRectangle()
        {
            Point[] tmp_v = new Point[4];
            for (int i = 0; i < 4; i++)
            {
                Console.Write("x{0}: ", i + 1);
                tmp_v[i].x = double.Parse(Console.ReadLine());
                Console.Write("y{0}: ", i + 1);
                tmp_v[i].y = double.Parse(Console.ReadLine());
            }
            Array.Sort(tmp_v);

            if (CheckRect(tmp_v))
            {
                vertices = tmp_v;
                a = vertices[2].x - vertices[0].x;
                b = vertices[1].y - vertices[0].y;
            }
            else
            {
                throw new ArgumentException("Illegal rectangle");
            }
        }
    }
}
