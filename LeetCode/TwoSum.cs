using System.Collections.Generic;

namespace LeetCode
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> numberAndIndex = new Dictionary<int, int>();
            int index1 = 0;
            int index2 = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                var cur = nums[i];
                if (numberAndIndex.ContainsKey(target - cur))
                {
                    index1 = i;
                    index2 = numberAndIndex[target - cur];
                    break;
                }
                else
                {
                    numberAndIndex[cur] = i;
                }
            }
            return new int[] { index1, index2 };
        }
    }
}
