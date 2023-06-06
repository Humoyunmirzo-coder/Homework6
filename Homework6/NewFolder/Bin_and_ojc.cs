internal class Program
{
    private static void Main(string[] args)
    {

        string file = "C:\\Gitignore\\test.txt";

        var files = Directory.GetFiles(file, "*bin.*", SearchOption.AllDirectories);
        foreach (string filess in files)
        {
            Console.WriteLine(filess);
        }

    }
}