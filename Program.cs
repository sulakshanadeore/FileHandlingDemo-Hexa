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

        //        FileInfo fi = new FileInfo("file2.txt");
        //        Console.WriteLine(fi.Extension);
        //        Console.WriteLine(fi.CreationTime);
        //        Console.WriteLine(fi.DirectoryName);
        //        Console.WriteLine(fi.FullName);
        //fi.Create(FileMode.Create,FileSystemRights.FullControl,FileShare.ReadWrite,10,FileOptions.WriteThrough,null);

                CreateAndWriteToTheTextFileUsingStreamWriter();

        //OpenAndReadFromTextFileUsingStreamReader();




        //FileStream fs=new FileStream("D:\\AllDemos\\HexaMarch",)


    }

    private static void OpenAndReadFromTextFileUsingStreamReader()
    {
        FileStream fs = null;
        StreamReader reader = null;
        try
        {
            fs = new FileStream(@"D:\AllDemos\HexaMarch\firstfile.txt", FileMode.Open, FileAccess.Read);
            reader = new StreamReader(fs);

            string filecontents = reader.ReadToEnd();
            Console.WriteLine(filecontents);

        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message); ;
        }
        finally
        {
            reader.Close();
            reader.Dispose();
            fs.Close();
            fs.Dispose();
        }
    }

    private static void CreateAndWriteToTheTextFileUsingStreamWriter()
    {
        FileStream fs = null;
        StreamWriter writer = null;
        try
        {
            fs = new FileStream(@"D:\AllDemos\HexaMarch\firstfile.txt", FileMode.Create, FileAccess.Write);
            
            writer = new StreamWriter(fs);
            writer.AutoFlush = true;
            string s = "Writing data to the file";
            writer.WriteLine(s);
            Console.WriteLine("File created successfully......");
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message); ;
        }
        finally
        {
            //writer.Flush();
            writer.Close();
            writer.Dispose();
            fs.Close();
            fs.Dispose();
        }
    }
}