namespace TestProjectForGitHub
{
    public class Geometry
    {
        public int GetPerimeter(int a, int b)
        {
            return 2 * a + 2 * b;
        }

        public int RectangleArea(int a, int b)
        {
            return a * b;
        }

        public string GetStatistic(int a, int b)
        {
            return "Периметр = " + GetPerimeter(a, b) + ", площадь = " + RectangleArea(a, b);
        }

        public override string  ToString()
        {
            return "Geometry class";
        }
    }
}
