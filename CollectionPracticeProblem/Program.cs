namespace CollectionPracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Count remaining chapters\n2.Maximum selling price by swapping");
            bool loopAgain = true;
            while (loopAgain)
            {
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        CountChapters count = new CountChapters();
                        count.Amelia();
                        break;
                    case 2:
                        MaxSellingPrice maxSelling = new MaxSellingPrice();
                        maxSelling.Swapping();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    case 4:
                        loopAgain = false;
                        break;
                }
            }


        }
    }
}
