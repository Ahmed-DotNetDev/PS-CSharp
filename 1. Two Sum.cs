class Solution
{
    public int[] TwoSum(int[] arr, int target)
    {
        for (int i = 0; i <= arr.Length - 1; i++)
        {
            for (int j = i + 1; j <= arr.Length - 1; j++)
            {
                if (arr[i] + arr[j] == target)
                {
                    return new int[2] { i, j };
                }
                else
                {
                    continue;
                }
            }
        }
        return new int[2];
    }
}