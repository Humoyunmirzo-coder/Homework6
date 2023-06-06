
static void Main(string[] args)
{
    
    string path = "C:\\Textnew";
    string[] Clear = Directory.GetDirectories(path, "bin* "); foreach (string bin in Clear)
    { 
        Console.WriteLine(bin + " DELETED"); Directory.Delete(bin, true); 
    }
    string[] ClearObj = Directory.GetDirectories(path, "obj*.");
    foreach (string obj in ClearObj)
    {
        Console.WriteLine(obj + " DELETED"); Directory.Delete(obj, true);
       };
}   