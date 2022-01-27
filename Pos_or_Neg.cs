class Pos_or_Neg
{
    public static bool CheckNumber(int a, int b, int c)
    {
        return (((a >= 0) && (b >= 0)) || ((a >= 0) && (c >= 0)) || ((b >= 0) && (c >= 0)));
    }
}
