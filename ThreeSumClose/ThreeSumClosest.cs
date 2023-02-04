namespace ThreeSumClose;
public class ThreeSumClosest
{
    public int ThreeSumClosestFunction(int[] nums, int target)
    {
        List<int> sums = new List<int>();
        Array.Sort(nums);
        int i = 0;

        while (i < nums.Length - 2)
        {
            int k = i + 1;
            int j = nums.Length - 1;
            while (k < j)
            {
                int sum = nums[i] + nums[j] + nums[k];
                sums.Add(sum);
                if (sum == target)
                {
                    return sum;
                }
                else if (sum > target)
                {
                    j--;
                }
                else if (sum < target)
                {
                    k++;
                }
            }
            i++;
        }

        var nearest = sums.MinBy(x => Math.Abs(x - target));
        return nearest;
    }
}
