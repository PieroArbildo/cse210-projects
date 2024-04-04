public class Rectangle : Shape
{
  private double _legth;
  private double _width;
  public Rectangle(double legth,double width, string color):base(color)
  {
    _legth = legth;
    _width = width;
  }
  public override double GetArea()
  {
    return _width * _legth; 
  }
}