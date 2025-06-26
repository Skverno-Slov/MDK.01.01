namespace LabWork9;

internal interface IFigure
{
    string Name => "Фигура";
    double GetSquare();
    double GetPerimeter();
    void ShowInfo();
}