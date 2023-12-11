namespace _2DpointConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point2D p1 = new Point2D(2, 3);   
            Point2D p2 = new Point2D(5, 7);
            Point2D p3 = new Point2D();
            Point2D p4 = new Point2D(2, 9);
            //p1.DistanceTo(p2);
            Console.WriteLine(p2.DistanceTo(p1));
            Console.WriteLine(Point2D.DistanceBetween(p1, p4));
            Console.WriteLine($"X:{p1.X},Y:{p1.Y}");
            if (Point2D.isTriangle(p1, p2, p3))
            {
                Console.WriteLine("It is a triangle");
            }
            else
            {
                Console.WriteLine("It is not a triangle");
            }
        }
    }

    class Point2D  
    {
        private int x;
        private int y;

        public Point2D()
        {
            x = 0;
            y = 0;
        }

        public Point2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        /*public int X
        {
            set; get;
        }

        public int Y
        {
            set; get;
        }*/


        public int X
        {
            get { return x; } 
            set { x = value; } 
        }

        public int Y
        {             
            get { return y; } 
            set { y = value; } 
        }

        public double DistanceTo(Point2D p)
        {
            return Math.Sqrt(Math.Pow(p.X - x, 2) + Math.Pow(p.Y - y, 2));
        }

        public static bool isTriangle(Point2D p1, Point2D p2, Point2D p3)
        {
            double a = p1.DistanceTo(p2);
            double b = p1.DistanceTo(p3);
            double c = p2.DistanceTo(p3);
            if (a + b > c && a + c > b && b + c > a)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static double DistanceBetween(Point2D p1, Point2D p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2)); 
        }
        
        /*public int getX() 
        { 
            return x; 
        }

        public int getY()
        {
            return y; 
        }

        public void setX(int x)
        {
            this.x = x;
        }

        public void setY(int y)
        {
            this.y = y;
        }*/
    }
}