namespace SoftUni_CSharp_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Queue<int[]> pumps = new Queue<int[]>();
            for (int i = 0; i < count; i++)
            {
                int[] pumpTokens = Console.ReadLine().Split(new String[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                pumps.Enqueue(pumpTokens);
            }
            int start = 0;
            while (true)
            {
                bool status = true;
                int total = 0;
                foreach (var pump in pumps)
                {
                    int liters = pump[0];
                    int distance = pump[1];
                    total += liters;
                    if (total - distance * 1 < 0)
                    {
                        start++;
                        int[] current = pumps.Dequeue();
                        pumps.Enqueue(current);
                        status = false;
                        break;
                    }
                    total -= distance * 1;
                }
                if (status)
                {
                    Console.WriteLine(start);
                    break;
                }
            }
        }
    }
}
