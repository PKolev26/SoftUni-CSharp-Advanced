using System.Text;

namespace SoftUni_CSharp_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> cups = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Stack<int> bottles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int wastedWater = 0;

            while (true)
            {
                if (bottles.Peek() >= cups.Peek())
                {
                    wastedWater += bottles.Peek() - cups.Peek();
                    cups.Dequeue();
                    bottles.Pop();
                }
                else
                {
                    int cupCapacity = cups.Peek();
                    while (cupCapacity > 0)
                    {
                        if (!bottles.Any())
                        {
                            break;
                        }
                        if (cupCapacity < bottles.Peek())
                        {
                            wastedWater += bottles.Peek() - cupCapacity;
                        }
                        cupCapacity = cupCapacity - bottles.Peek();
                        bottles.Pop();
                    }
                    cups.Dequeue();
                }
                if (!bottles.Any())
                {
                    Console.WriteLine($"Cups: {string.Join(" ", cups)}");
                    Console.WriteLine($"Wasted litters of water: {wastedWater}");
                    return;
                }
                else if (!cups.Any())
                {
                    Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
                    Console.WriteLine($"Wasted litters of water: {wastedWater}");
                    return;
                }
            }
        }
    }
}
