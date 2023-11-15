namespace SoftUni_CSharp_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothes = new Stack<int>(Console.ReadLine().Split(new String[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            int capacity = int.Parse(Console.ReadLine());
            int current = capacity;
            int number = 1;
            while (clothes.Count > 0)
            {
                current -= clothes.Peek();

                if (current < 0)
                {
                    current = capacity;
                    number++;
                    continue;
                }

                clothes.Pop();
            }

            Console.WriteLine(number);
        }
    }
}
