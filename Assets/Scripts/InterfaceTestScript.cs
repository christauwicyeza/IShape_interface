using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceTestScript : MonoBehaviour
{
    void Start()
    {
        Trapezium trapezium = new Trapezium(5, 7, 4, 3);
        trapezium.CalculateArea();
        trapezium.CalculatePerimeter();

        Circle circle = new Circle(10);
        circle.CalculateArea();
        circle.CalculatePerimeter();

        Nonagon nonagon = new Nonagon(6);
        nonagon.CalculateArea();
        nonagon.CalculatePerimeter();
        Debug.Log("Nonagon Number of Sides: " + nonagon.CalculateNumberOfSides());
    }
}

public interface IShape
{
    void CalculateArea();
    void CalculatePerimeter();
}

public class Trapezium : IShape
{
    float base1, base2, height, side;
    
    public Trapezium(float base1, float base2, float height, float side)
    {
        this.base1 = base1;
        this.base2 = base2;
        this.height = height;
        this.side = side;
    }

    public void CalculateArea()
    {
        float area = 0.5f * (base1 + base2) * height;
        Debug.Log("Trapezium's Area: " + area);
    }

    public void CalculatePerimeter()
    {
        float perimeter = base1 + base2 + 2 * side;
        Debug.Log("Trapezium's Perimeter: " + perimeter);
    }
}

public class Circle : IShape
{
    float radius;

    public Circle(float radius)
    {
        this.radius = radius;
    }

    public void CalculateArea()
    {
        float area = Mathf.PI * radius * radius;
        Debug.Log("Circle's Area: " + area);
    }

    public void CalculatePerimeter()
    {
        float perimeter = 2 * Mathf.PI * radius;
        Debug.Log("Circle's circumference : " + perimeter);
    }
}

public class Nonagon : IShape
{
    int numberOfSides;
    float sideLength;

    public Nonagon(float sideLength)
    {
        this.numberOfSides = 9;
        this.sideLength = sideLength;
    }

    public void CalculateArea()
    {
        float area = (9 * sideLength * sideLength) / (4 * Mathf.Tan(Mathf.PI / 9));
        Debug.Log("Area of Nonagon: " + area);
    }

    public void CalculatePerimeter()
    {
        float perimeter = 9 * sideLength;
        Debug.Log("Nonagon's Perimeter: " + perimeter);
    }

    public int CalculateNumberOfSides()
    {
        return numberOfSides;
    }
}
