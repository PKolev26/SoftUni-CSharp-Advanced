namespace SoftUni_CSharp_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inp = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] i = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(i);

            int numbers = inp[1];
            int element = inp[2];

            for (int j = 0; j < numbers; j++)
            {
                stack.Pop();
            }

            if (stack.Contains(element))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stack.Count > 0)
                {
                    Console.WriteLine(stack.Min());
                }
                else
                {
                    Console.WriteLine(stack.Count);
                }
            }
        }
    }
}
