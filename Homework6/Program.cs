internal class Program
{
    private static void Main(string[] args)
    {
        string file = "C:\\Gitignore\\test.txt";

        if (!Directory.Exists(file))
        {
            Directory.CreateDirectory(file);
        }
        else
        {
            Console.WriteLine("  File Exists ");
        }
    }
}