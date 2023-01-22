namespace Summator
{
    public static class Summator
    {
        public static long Sum(int[] arr)
        {
            long sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            // return sum
            return sum;
        }

        public static double Average(int[] arr)
        {
            double sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            // return sum
            return sum / arr.Length;
        }

        public static double Multiply(int[] arr)
        {
            double result = 1;

            foreach(int item in arr)
            {
                result *= item;
            }

            //return the result
            return result;
        }
    }
}
