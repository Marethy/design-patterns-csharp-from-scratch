using System;
using System.Collections.Generic;

namespace Visitor
{
    // Interface cho tất cả Visitor
    public interface IVisitor<T>
    {
        T Visit(Circle circle);
        T Visit(Rectangle rectangle);
        T Visit(Triangle triangle);
    }

    // Visitor tính diện tích
    public class AreaVisitor : IVisitor<double>
    {
        public double Visit(Circle circle) => Math.PI * circle.Radius * circle.Radius;
        public double Visit(Rectangle rectangle) => rectangle.Width * rectangle.Height;
        public double Visit(Triangle triangle) => 0.5 * triangle.Base * triangle.Height;
    }

    // Visitor vẽ
    public class DrawVisitor : IVisitor<string>
    {
        public string Visit(Circle circle) => $"Drawing a Circle with radius {circle.Radius}";
        public string Visit(Rectangle rectangle) => $"Drawing a Rectangle with width {rectangle.Width} and height {rectangle.Height}";
        public string Visit(Triangle triangle) => $"Drawing a Triangle with base {triangle.Base} and height {triangle.Height}";
    }

    // Visitor export
    public class ExportVisitor : IVisitor<string>
    {
        public string Visit(Circle circle) => $"<circle radius='{circle.Radius}' />";
        public string Visit(Rectangle rectangle) => $"<rectangle width='{rectangle.Width}' height='{rectangle.Height}' />";
        public string Visit(Triangle triangle) => $"<triangle base='{triangle.Base}' height='{triangle.Height}' />";
    }

    // Interface cho Shape
    public interface IShape
    {
        T Accept<T>(IVisitor<T> visitor);
    }

    // Circle
    public class Circle : IShape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius must be positive");
            Radius = radius;
        }

        public T Accept<T>(IVisitor<T> visitor) => visitor.Visit(this);
    }

    // Rectangle
    public class Rectangle : IShape
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height)
        {
            if (width <= 0 || height <= 0)
                throw new ArgumentException("Width and Height must be positive");
            Width = width;
            Height = height;
        }

        public T Accept<T>(IVisitor<T> visitor) => visitor.Visit(this);
    }

    // Triangle
    public class Triangle : IShape
    {
        public double Base { get; }
        public double Height { get; }

        public Triangle(double b, double h)
        {
            if (b <= 0 || h <= 0)
                throw new ArgumentException("Base and Height must be positive");
            Base = b;
            Height = h;
        }

        public T Accept<T>(IVisitor<T> visitor) => visitor.Visit(this);
    }
}
