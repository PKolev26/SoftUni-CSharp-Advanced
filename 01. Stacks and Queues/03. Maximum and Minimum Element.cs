namespace SoftUni_CSharp_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                string[] com = Console.ReadLine().Split();
                switch (com[0])
                {

                    case "1":
                        stack.Push(int.Parse(com[1]));
                        break;
                    case "2":
                        if (stack.Count == 0)
                        {
                            continue;
                        }
                        stack.Pop();
                        break;
                    case "3":
                        if (stack.Count == 0)
                        {
                            continue;
                        }
                        Console.WriteLine(stack.Max());
                        break;
                    case "4":
                        if (stack.Count == 0)
                        {
                            continue;
                        }
                        Console.WriteLine(stack.Min());
                        break;
                    default:
                        break;
                }
            }
            string val = string.Join(", ", stack);
            Console.WriteLine(val);
        }
    }
}
