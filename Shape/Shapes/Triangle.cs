namespace Shape.Shapes;

public class Triangle : BaseShape
{
    /// <summary>
    /// The first side of the triangle.
    /// </summary>
    private readonly double _firstSide;
    
    /// <summary>
    /// The second side of the triangle.
    /// </summary>
    private readonly double _secondSide;
    
    /// <summary>
    /// The third side of the triangle.
    /// </summary>
    private readonly double _thirdSide;

    /// <summary>
    /// Constructor for creating an object Triangle with specified sides.
    /// </summary>
    /// <param name="firstSide">
    /// The first side of the triangle.
    /// </param>
    /// <param name="secondSide">
    /// The second side of the triangle.
    /// </param>
    /// <param name="thirdSide">
    /// The third side of the triangle.
    /// </param>
    /// <exception cref="ArgumentException">
    /// Throw ArgumentException if one of the sides of the triangle is less than zero or equal to zero.
    /// </exception>
    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
            throw new ArgumentException("Error. Input correct values.");
        
        _firstSide = firstSide;
        _secondSide = secondSide;
        _thirdSide = thirdSide;
    }

    /// <summary>
    /// This function checks if the triangle is rectangular.
    /// </summary>
    /// <param name="sidesList">
    /// Out parameter that contains sorted array of triangle sides.
    /// </param>
    /// <returns>
    /// Return true if the triangle is rectangular, otherwise false.
    /// </returns>
    private bool IsRight(out List<double> sidesList)
    {
        sidesList = new List<double> { _firstSide, _secondSide, _thirdSide };
        sidesList.Sort();

        return Math.Pow(sidesList[0], 2) + Math.Pow(sidesList[1], 2) == Math.Pow(sidesList[2], 2);
    }
    
    public override double CountArea()
    {
        double area;
        var halfPerimeter = (_firstSide + _secondSide + _thirdSide) / 2;

        if (IsRight(out var sidesList))
            area = sidesList[0] * sidesList[1] / 2;
        else
            area = Math.Sqrt(halfPerimeter * (halfPerimeter - _firstSide) 
                                           * (halfPerimeter - _secondSide) 
                                           * (halfPerimeter - _thirdSide));

        return area;
    }
}