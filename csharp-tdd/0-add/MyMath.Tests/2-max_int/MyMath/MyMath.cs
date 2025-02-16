using System;
using System.Collections.Generic;
using System.Linq;

namespace MyMath
{
    /// <summary>
    /// Contains mathematical operations.
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Returns the maximum integer in a list.
        /// </summary>
        /// <param name="nums">A list of integers.</param>
        /// <returns>The maximum integer in the list, or 0 if the list is empty.</returns>
        public static int Max(List<int> nums)
        {
            if (nums == null || nums.Count == 0)
                return 0;

            return nums.Max();
        }
    }
}