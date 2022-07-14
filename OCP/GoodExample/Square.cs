namespace OCP.GoodExample
{
    public class Square : Shape
    {
        public int EdgeWidth { get; set; }

        public override double Area()
        {
            return EdgeWidth * EdgeWidth;
        }
    }
}
