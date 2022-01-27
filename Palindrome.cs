
class Palindrome
{
    public static bool CheckPalindrome(string num)
    {
        string num1 = string.Empty;
        for (int i = num.Length - 1; i >= 0; i--)
        {
            num1 += num[i];
        }

        if (num == num1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
        
    




