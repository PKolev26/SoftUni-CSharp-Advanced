namespace SoftUni_CSharp_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inp = Console.ReadLine().Split();
            int n = int.Parse(inp[0]);
            int s = int.Parse(inp[1]);
            int x = int.Parse(inp[2]);
            Queue<int> q = new Queue<int>();
            inp = Console.ReadLine().Split();

            for (int i = 0; i < n; i++)
            {
                q.Enqueue(int.Parse(inp[i]));
            }
            bool flag = q.Contains(x);
            for (int i = 0; i < s; i++)
            {
                q.Dequeue();
            }
            if (q.Contains(x)) Console.WriteLine("true");
            else if (q.Count == 0) Console.WriteLine(0);
            else if (flag && !q.Contains(x)) Console.WriteLine(q.Min());
        }
    }
}
