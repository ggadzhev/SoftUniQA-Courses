using System;
using Shapes;

internal class Rectangle : IDrawable
{

    private int width;
    private int height;

    public Rectangle(int width, int height)
    {
        this.width = width;
        this.height = height;
    }

    public void Draw()
    {
        DrawLine(this.width, '*', '*');
        for (int i = 1; i <= this.height - 1; i++)
        {
            DrawLine(this.width, '*', '*');

        }
        DrawLine(this.width, '*', '*');
    }

    private void DrawLine(int width, char end, char mid)
    {
        Console.WriteLine(end);
        for (int i = 1; i <= width - 1; i++)
        {
            Console.WriteLine(mid);
        }
        Console.WriteLine(end);
    }
}