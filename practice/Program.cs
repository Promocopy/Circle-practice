namespace Program
{
    public class Circle
    {
        float _Pi = 3.142f;
        int _radius;

        public Circle(int Radius)
        {
            this._radius = Radius;
        }

        public float calculateArea()
        {
            return  this._Pi * this._radius * this._radius;
        }


        public static void Main()
        {
            Circle C1 = new Circle(5);
            float Area = C1.calculateArea();

            Console.WriteLine("Area is {0}", Area);
        }

      
       
    }
}