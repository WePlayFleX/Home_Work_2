class Triangle
{
    public static bool CheckTriangle(int a, int b, int c)
    {
        return (((a + b) > c) || ((a + c) > b) || ((b + c) > a));
    }
}
