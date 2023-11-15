namespace SoftUni_CSharp_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new Queue<string>(Console.ReadLine().Split(new String[] { ", " }, StringSplitOptions.RemoveEmptyEntries));
            while (songs.Count > 0)
            {
                string[] keys = Console.ReadLine().Split(new String[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                string command = keys[0];
                switch (command)
                {
                    case "Play":
                        songs.Dequeue();
                        break;
                    case "Add":
                        string song = string.Join(" ", keys.Skip(1));
                        if (songs.Contains(song)) Console.WriteLine($"{song} is already contained!");
                        else songs.Enqueue(song);
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ", songs));
                        break;
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
