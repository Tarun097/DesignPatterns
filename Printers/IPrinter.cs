namespace ConsoleApp2
{
    public interface IPrinter
    {
        void Print(Ellipse ellipse);
        void Print(Rectangle rectangle);
        void Print(Circle circle);
    }

}