using System.IO.Compression;

public class TwoSumProblem {

    private int[] nums;
    private int target;

    public TwoSumProblem(int[] nums, int target) {
        this.nums = nums;
        this.target = target;
    }

    public int[] findTwoSum() {
        int[] result = new int[2];
        Dictionary<int, int> parsedNums = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++){
            int num = nums[i];
            if(parsedNums.ContainsKey(target - num)){
                result[0] = parsedNums[target - num];
                result[1] = i;
                return result;
            }
            parsedNums[num] = i;
        }
        return result;
    }
    
}
