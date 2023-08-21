public class Solution {
    public bool IsPalindrome(int x)
{
    int y=x , sum=0, mod;
    while (x > 0)
    {
        mod = x % 10;
        sum = (sum * 10) + mod;
        x /= 10;
    }
    return y == sum ? true : false;
}
}