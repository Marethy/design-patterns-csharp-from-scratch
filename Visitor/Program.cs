using System;
using System.Collections.Generic;
using Visitor;

// Danh sách các shape
List<IShape> shapes = new()
        {
            new Circle(3),
            new Rectangle(3, 4),
            new Triangle( 5, 2)
        };

// Tạo các Visitor
var areaVisitor = new AreaVisitor();
var drawVisitor = new DrawVisitor();
var exportVisitor = new ExportVisitor();

Console.WriteLine("== Areas ==");
foreach (var shape in shapes)
    Console.WriteLine(shape.Accept(areaVisitor));

Console.WriteLine("\n== Drawing ==");
foreach (var shape in shapes)
    Console.WriteLine(shape.Accept(drawVisitor));

Console.WriteLine("\n== Export to SVG ==");
foreach (var shape in shapes)
    Console.WriteLine(shape.Accept(exportVisitor));
