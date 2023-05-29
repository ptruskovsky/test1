using SuperShape.Interfaces;
using SuperShape.Shapes;

var sircle1 = new Circle(5);
var sircle2 = new Circle(10);
var triangle1 = new Triangle(3, 4, 5);
var triangle2 = new Triangle(9, 11, 13);

IShape currentShape = sircle1;

Console.WriteLine($"Area of sircle1 is : {currentShape.CalculateArea()}");

currentShape = sircle2;

Console.WriteLine($"Area of sircle2 is : {currentShape.CalculateArea()}");

currentShape = triangle1;

Console.WriteLine($"Area of triangle 1 is: {currentShape.CalculateArea()}");

if (currentShape is Triangle t1)
{
    Console.WriteLine($"Is triangle 1 is right?: {t1.IsRightTriangle()}");
}

currentShape = triangle2;

Console.WriteLine($"Area of triangle 2 is: {currentShape.CalculateArea()}");

if (currentShape is Triangle t2)
{
    Console.WriteLine($"Is triangle 2 is right?: {t2.IsRightTriangle()}");
}

Console.ReadKey();


