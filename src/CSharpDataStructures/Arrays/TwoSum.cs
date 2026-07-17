namespace CSharpDataStructures.Arrays;

public static class TwoSum
{
    public static int[] Encontrar(int[] nums, int target)
    {
        Dictionary<int, int> numToIndex = new Dictionary<int, int>();
        for (int i = 0; i <nums.Length; i++)
        {
            int complement = target - nums[i];
            if (numToIndex.ContainsKey(complement))
            {
                return new int[] { numToIndex[complement], i };
            }
            numToIndex.Add(nums[i], i);
        }
        throw new InvalidOperationException("Nenhuma solução encontrada.");
    }
}