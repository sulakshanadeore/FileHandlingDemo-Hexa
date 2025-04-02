using Microsoft.VisualBasic;
using System.IO;
using System.Security.AccessControl;
internal class Program
{
    private static void Main(string[] args)
    {
        File.WriteAllText("file1.txt", "Hello World");
        //  string[] data =File.ReadAllLines("file1.txt");
        //  foreach (var item in data)
        //  {
        //      Console.WriteLine(item);
        //  }

        //  Console.WriteLine("------------------");
        //string fileContents=  File.ReadAllText("file1.txt");
        //  Console.WriteLine(fileContents);
        //  Console.WriteLine("-----------------------");
        //  File.Delete("file1.txt");
        //  Console.WriteLine("Deleted...");
        //    File.Copy("file1.txt", "file2.txt");
        //  Console.WriteLine("Copied");

        //File.Move("file1.txt", "D:\\AllDemos\\HexaMarch\\FileHandlingDemo\\obj\\filemoved.txt");

        FileInfo fi = new FileInfo("file2.txt");
        Console.WriteLine(fi.Extension);
        Console.WriteLine(fi.CreationTime);
        Console.WriteLine(fi.DirectoryName);
        Console.WriteLine(fi.FullName);
fi.Create(FileMode.Create,FileSystemRights.FullControl,FileShare.ReadWrite,10,FileOptions.WriteThrough,null);
    }
}