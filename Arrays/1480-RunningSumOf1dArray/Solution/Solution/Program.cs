using System;

namespace LeetCodeRunningSum
{
    public class Solution
    {
        public int[] RunningSum(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] = nums[i] + nums[i - 1];
            }
            return nums;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] testDizisi = { 1, 2, 3, 4 };

            Console.WriteLine("Girdi Dizisi:");
            Console.WriteLine("[ " + string.Join(", ", testDizisi) + " ]");

            int[] sonucDizisi = solution.RunningSum(testDizisi);

            Console.WriteLine("\nÇalışan Toplam (Running Sum) Çıktısı:");
            Console.WriteLine("[ " + string.Join(", ", sonucDizisi) + " ]");

            Console.WriteLine("\nÇıkmak için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}