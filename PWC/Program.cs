namespace PWC


{
    public class Circle
    {
        private float radius;
        private float pi = 3.14159f;

        public Circle(float radius)
        {
            this.radius = radius;
        }
        public float getRadius() {  return radius; }

        public float CalculateCircleArea()
        {
            return pi * radius * radius;
        }

        public float CalculateCircumference()
        {
            return 2 * pi * radius;
        }
    }
}