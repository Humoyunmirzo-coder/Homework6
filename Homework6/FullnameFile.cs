

internal class Program
{
    private static void Main(string[] args)
    {
         string file = "C:\\Gitignore\\test.txt";

        var filesExe = Directory.GetFiles(file, "*exe*", SearchOption.AllDirectories);
        foreach (var fileX in filesExe)
        {
            Console.WriteLine(Path.GetFileNameWithoutExtension(fileX));
        }
    }
}