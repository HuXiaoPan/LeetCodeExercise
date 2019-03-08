using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTest
{
    /// <summary>
    /// 给定一个整数数组 nums 和一个目标值 target，请你在该数组中找出和为目标值的那 两个 整数，并返回他们的数组下标。
    /// 你可以假设每种输入只会对应一个答案。但是，你不能重复利用这个数组中同样的元素。
    /// </summary>
    class TwoSum
    {
        /// <summary>
        /// 求数组中相加之和等于目标数的两个元素的下标
        /// </summary>
        /// <param name="nums">给定的数组</param>
        /// <param name="target">目标数</param>
        /// <returns></returns>
        public int[] GetTwoSum(int[] nums, int target)
        {
            int[] result =null;
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] +nums[j] == target)
                    {
                        result=new int[] { i,j };
                    }
                }
            }
            return result;
        }
        /// <summary>
        /// 求数组中相加之和等于目标数的两个元素的下标
        /// 利用字典降低时间复杂度，牺牲空间复杂度，得以优化
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] GetTwoSum2(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (dic.ContainsKey(complement))
                {
                    return new int[] { dic[complement], i };
                }
                //这一步舍弃相同的元素
                if (!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i], i);
                }
            }
            return null;
        }
    }
}
