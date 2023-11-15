using System.Text;

namespace SoftUni_CSharp_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder text = new StringBuilder();
            Stack<string> previos = new Stack<string>();
            for (int i = 0; i < n; i++)
            {
                string[] com = Console.ReadLine().Split(' ').ToArray();
                if (com[0] == "1")
                {
                    previos.Push(text.ToString());
                    text.Append(com[1]);
                }
                if (com[0] == "2")
                {
                    int count = int.Parse(com[1]);
                    previos.Push(text.ToString());
                    text.Remove(text.Length - count, count);
                }
                if (com[0] == "3")
                {
                    int ind = int.Parse(com[1]);
                    Console.WriteLine(text[ind - 1]);
                }
                if (com[0] == "4")
                {
                    text.Clear();
                    text.Append(previos.Pop());
                }
            }
        }
    }
}
