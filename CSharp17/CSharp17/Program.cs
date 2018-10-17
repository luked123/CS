/* Luke Donnelly
 * C# Pt 18.
 * Covers File System, File, DirectoryInfo, FileInfo, FileStream, StreamWriter,
 * StreamReader, BinarayWriter, BinaryReader
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;


namespace CSharp17
{
    class Program
    {
        static void Main(string[] args)
        {
            // How to access directory structures
            DirectoryInfo currDir = new DirectoryInfo(".");               // represents current directory
            DirectoryInfo lukesDir = new DirectoryInfo(@"C:\Users\Luke");
            
            // Just some simple information about the directory
            Console.WriteLine(lukesDir.FullName);
            Console.WriteLine(lukesDir.Name);
            Console.WriteLine(lukesDir.Parent);
            Console.WriteLine(lukesDir.Attributes);
            Console.WriteLine(lukesDir.CreationTime);

            string[] customers = { "Sally Smith", "Sue Donnelly", "Bob Smith" };

            // Creates a directory
            Directory.CreateDirectory(@"C:\Users\Luke\CSharpData");
            string textFilePath = @"C:\Users\Luke\CSharpData\testfile1.txt";
            File.WriteAllLines(textFilePath, customers);          // How to write to a File

            foreach(string customer in File.ReadAllLines(textFilePath))
            {
                Console.WriteLine("Customer : {0}", customer);
            }

            /* Get file information data in a certain directory */
            DirectoryInfo myDataDir = new DirectoryInfo(@"C:\Users\Luke\CSharpData");
            FileInfo[] txtFiles = myDataDir.GetFiles("*.txt", SearchOption.AllDirectories);

            Console.WriteLine("Matches : {0}", txtFiles.Length);

            foreach(FileInfo file in txtFiles)
            {
                Console.Write($"{file.Name} : ");
                Console.WriteLine(file.Length);
                Console.WriteLine();
            }

            /* File stream are used when you want to read or write a byte or bytes */
            string testFilePath2 = @"C:\Users\Luke\CSharpData\testfile2.txt";
            FileStream fs = File.Open(testFilePath2, FileMode.Create);

            string randString = "This is a random string";

            byte[] rsByteArray = Encoding.Default.GetBytes(randString);     // converts string to bytes 

            fs.Write(rsByteArray, 0, rsByteArray.Length);                   // writes to the file

            fs.Position = 0;                                                // resets the position of the fs to the start

            byte[] fileByteArray = new byte[rsByteArray.Length];            // creates a byte array for reading

            // Reads bytes into the array
            for(int i = 0; i < rsByteArray.Length; i++)
            {
                fileByteArray[i] = (byte)fs.ReadByte();
            }

            Console.WriteLine(Encoding.Default.GetString(fileByteArray));   // Converts byte array back to string
            fs.Close();

            // Stream readers and writers are used for reading and writing strings
            string testFilePath3 = @"C: \Users\Luke\CSharpData\testfile3.txt";

            StreamWriter sw = File.CreateText(testFilePath3);
            sw.Write("This is a random ");
            sw.WriteLine("sentence");
            sw.WriteLine("This is another sentence");
            sw.Close();

            StreamReader sr = File.OpenText(testFilePath3);
            Console.WriteLine("Peek : {0}", Convert.ToChar(sr.Peek()));
            Console.WriteLine("1st String : {0}", sr.ReadLine());
            Console.WriteLine("Everything : {0}", sr.ReadToEnd());         
            sr.Close();

            // Binary readers and writers used to read and write data types
            string testFilePath4 = @"C: \Users\Luke\CSharpData\testfile4.dat";

            FileInfo datFile = new FileInfo(testFilePath4);
            BinaryWriter bw = new BinaryWriter(datFile.OpenWrite());
            string randText = "Random Text";
            int age = 28;
            double height = 6.25;
            bw.Write(randText);
            bw.Write(age);
            bw.Write(height);
            bw.Close();

            BinaryReader br = new BinaryReader(datFile.OpenRead());
            Console.WriteLine(br.ReadString());                      
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadDouble());
            br.Close();

            Console.ReadLine();
        }
    }
}
