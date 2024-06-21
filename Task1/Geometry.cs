namespace Math
{
    class Program
    {
        static int Power(int x, int n)
        {
            if (n < 0)
                return -1;

            int result = 1;
            for (int i = 0; i < n; i++)
            {
                result *= x;
            }
            return result;
        }

        static int Square(int x)
        {
            if (x < 0)
                return -1;

            return x * x;
        }
    }
}