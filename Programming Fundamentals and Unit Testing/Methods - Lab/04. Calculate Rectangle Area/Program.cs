int w = int.Parse(Console.ReadLine());
int l = int.Parse(Console.ReadLine());

Console.WriteLine(GetRectArea(w, l));

static int GetRectArea(int width, int length)
{
    int area = width *  length;
    return area;
}
