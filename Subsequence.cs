class Subsequence
{
    public static bool CheckSubsequence(int num)
    {
        return (((num / 1000 < (num % 1000) / 100) && ((num % 1000) / 100 < (num % 100) / 10) && ((num % 100) / 10 < num % 10)));
    }
}

