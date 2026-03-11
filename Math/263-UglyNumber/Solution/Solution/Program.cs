using System;

namespace UglyNumberApp
{
    public class Solution
    {
        public bool IsUgly(int n)
        {
            if(n<=0){
                return false;
            }

            while(n%2==0)
            {
                n=n/2;
            }
            while(n%3==0)
            {
                n=n/3;
            }
            while(n%5==0)
            {
                n=n/5;
            }

            if(n!=1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
f
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] testNumbers = { 6, 1, 14, 8, -5, 60 };

            Console.WriteLine("--- Çirkin Sayı (Ugly Number) Testi ---\n");

            foreach (int number in testNumbers)
            {
                bool result = solution.IsUgly(number);
                Console.WriteLine($"Sayı: {number} -> Çirkin Sayı mı? {result}");
            }

            Console.WriteLine("\nÇıkmak için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}