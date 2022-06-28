using System;

TriangleArea NewTriangle = new TriangleArea(3, 4, 5);
NewTriangle.Qinjiushao();
Console.WriteLine(NewTriangle.area);

class TriangleArea
{
    double a, b, c;
    public double area { get; private set; }
    public TriangleArea(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public TriangleArea(double b, double h)
    {
        area = b * h;
    }

    public void Qinjiushao()
    {
        area = Math.Sqrt(this.a * this.a * this.c * this.c * 4 - Math.Pow(this.a * this.a +this.c * this.c - this.b * this.b, 2)) / 4;
    }
}

