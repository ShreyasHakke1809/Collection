namespace CollectionPracticeProblem
{
    internal class MaxSellingPrice
    {
        public void Swapping()
        {
            int n = 4;
            int k = 2;
            int[] a = { 25, 16, 9, 21 };
            int[] b = { 1, 34, 22, 6 };
            Array.Sort(a);
            Array.Sort(b);
            Array.Reverse(b);

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                if (i < k)
                {
                    sum += Math.Max(a[i], b[i]);
                }
                else
                {
                    sum += a[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
