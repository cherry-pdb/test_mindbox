namespace Shape.Shapes;

public class Circle : BaseShape
{
    /// <summary>
    /// The radius of the circle.
    /// </summary>
    private readonly double _radius;

    /// <summary>
    /// Constructor for creating an object Circle with specified radius.
    /// </summary>
    /// <param name="radius">
    /// The radius of the circle.
    /// </param>
    /// <exception cref="ArgumentException">
    /// Throw ArgumentException if the radius of the circle is less than zero or equal to zero.
    /// </exception>
    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Error. Radius must be greater than zero.");
        
        _radius = radius;
    }
    
    public override double CountArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}