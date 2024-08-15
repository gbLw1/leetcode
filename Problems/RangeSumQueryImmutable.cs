namespace leetcode.Problems;

public static class RangeSumQueryImmutable
{
    private class NumArray {
        private readonly int[] _preSum = [];

        public NumArray(int[] nums) {
            _preSum = new int[nums.Length];

            for (int i = 0; i < nums.Length; ++i) {
                if (i == 0) {
                    _preSum[i] = nums[i];
                    continue;
                }
                _preSum[i] = _preSum[i-1] + nums[i];
            }
        }
        
        public int SumRange(int left, int right) {
            if (left == 0) {
                return _preSum[right];
            }
            return _preSum[right] - _preSum[left-1];
        }
    }
    /**
    * Your NumArray object will be instantiated and called as such:
    * NumArray obj = new NumArray(nums);
    * int param_1 = obj.SumRange(left,right);
    */

    public static void Test() {
        NumArray numArray = new ([-2, 0, 3, -5, 2, -1]);
        Console.WriteLine(numArray.SumRange(0, 2)); // return (-2) + 0 + 3 = 1
        Console.WriteLine(numArray.SumRange(2, 5)); // return 3 + (-5) + 2 + (-1) = -1
        Console.WriteLine(numArray.SumRange(0, 5)); // return (-2) + 0 + 3 + (-5) + 2 + (-1) = -3
    }
}
