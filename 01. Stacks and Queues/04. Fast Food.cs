namespace SoftUni_CSharp_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            Queue<int> ints = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Console.WriteLine(ints.Max());
            while (ints.Count > 0)
            {
                quantity -= ints.Peek();
                if (quantity < 0)
                {
                    break;
                }
                ints.Dequeue();
            }
            if (ints.Any())
            {
                Console.WriteLine($"Orders left: {string.Join(" ", ints)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
