using System;
namespace SpecialNumbersApp.Logic
{
    public static class SpecialNumberAll
    {
        public static bool IsPrime(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                if (n % i == 0)
                {
                    return false;
                }
                }
                return true;
            
        }

        public static bool IsFibonacci(int n)
        {
            int a = 0, b = 1;
            while (b < n)
            {
                int temp = b;
                b += a;
                a = temp;
            }
            return b == n || n == 0;
        }

        public static bool IsPerfectSquare(int n)
        {
            int root = (int)Math.Sqrt(n);
            return root * root == n;
        }

        public static bool IsPerfectNumber(int n)
        {
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }      
            return sum == n;
        }

        public static bool IsAbundantNumber(int n)
        {
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            
            return sum > n;
        }

        public static bool IsDeficientNumber(int n)
        {
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
                
            return sum < n;
        }
        public static bool IsNarcissitc(int n)
        {
            int count = 0;
            double sum = 0;
            int temp = n;
            while (temp > 0)
            {
                count++;
                temp = temp / 10;
            }
            temp = n;
            int rem = 0;
            while (n > 0)
            {
                rem = n % 10;
                sum += Math.Pow(rem, count);
                n = n / 10;
            }
            return sum == temp;
        }
         public static bool IsPalandrom(int n)
        {
            double sum = 0;
            int temp = n;
            int rem = 0;
            while (n > 0)
            {
                rem = n % 10;
                sum = sum * 10 + rem;
                n = n / 10;

            }
            return sum == temp;
        }
    }
}
