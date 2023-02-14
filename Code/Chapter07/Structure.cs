using System;

namespace Structure
{
    struct Point
    {
        public int x;
        public int y;
        public int z;

        public Point(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return string.Format($"{x}, {y}, {z}");
        }
    }

    class MainApp
    {
        static void Main()
        {
            Point point1;
            point1.x = 10;
            point1.y = 20;
            point1.z = 40;

            Console.WriteLine(point1.ToString());

            Point point2 = new Point(100, 200, 300);
            Point point3 = point2; // 구조체이기 때문에 깊은 복사가 된다.
            point3.z = 400;

            Console.WriteLine(point2.ToString());
            Console.WriteLine(point3.ToString());
        }
    }
}