using AreaCalculationLib;

var firstUnknownFigure = FigureCreator.CreateFigure(3);
Console.WriteLine(firstUnknownFigure.Area());
            
var secondUnknownFigure = FigureCreator.CreateFigure(3, 4, 5);
Console.WriteLine(secondUnknownFigure.Area());