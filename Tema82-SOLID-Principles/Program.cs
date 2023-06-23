


using Tema82_SOLID_Principles.Open_Closed_Principle;

class Program
{
    static void Main(string[] args)
    {
        AreaCalculator a=new AreaCalculator();

        Rectangle r=new Rectangle();
        r.Width=2;
        r.Height=3;

        Circle c=new Circle();
        c.Radius=5;

        Shape[] arrObjects = new Shape[] { r, c };

        double area = a.TotalArea(arrObjects);

        Console.WriteLine(area);
    }
}