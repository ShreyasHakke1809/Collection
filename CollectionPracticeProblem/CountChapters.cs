namespace CollectionPracticeProblem
{
    internal class CountChapters
    {
        public void Amelia()
        {
            int pages = 0;
            int N = 4;
            Console.WriteLine("Enter page number");
            int K = Convert.ToInt32(Console.ReadLine());

            int[,] chapter = new int[,]
                {
                    {1,5 },
                    {6,11 },
                    {12,18 },
                    {19,24 }
                };

            for (int i = 0; i < N; i++)
            {
                int X = chapter[i, 0];
                int Y = chapter[i, 1];

                if (K >= X && K <= Y)
                {
                    pages = N - i;
                }
            }
            Console.WriteLine("Chapters remaining " + pages);
        }
    }
}
