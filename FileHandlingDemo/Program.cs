using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace FileHandlingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                FileOperation();
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        createFile(); break;
                    case 2:
                        ReadFileData(); break;
                    case 3:
                        addPersonData(); break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Enter valid choice ... ");
                        break;
                }
            }
        }


        public static void FileOperation()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create File");
            Console.WriteLine("2. Read File Data");
            Console.WriteLine("3. Add Person Data");
            Console.WriteLine("4. Exit");
        }
        public static  void createFile()
        {
            Console.WriteLine("Etner file Name:");
            string fileName=Console.ReadLine();
            string filePath = @"D:\Training\" + fileName;
            if (!File.Exists(filePath))
            {
                FileStream fs = new FileStream(filePath, FileMode.Create);
                Console.WriteLine($"File created at this path : {filePath}");
            }
            else
            {
                Console.WriteLine("File not created!!!!! ");
            }
        }
        public static void ReadFileData()
        {
            Console.WriteLine("Etner file Name:");
            string fileName = Console.ReadLine();
            string filePath = @"D:\Training\" + fileName;
            FileStream fs = null;
            try
            {

              fs  = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                StreamReader sr = null;
                try
                {
                    sr = new StreamReader(fs);
                    string data = sr.ReadToEnd();
                    Console.WriteLine(data);

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);

                }
                finally
                {

                    sr.Close();
                    sr.Dispose();
                    fs.Close();
                    fs.Dispose();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void addPersonData()
        {
            Console.WriteLine("Etner file Name:");
            string fileName = Console.ReadLine();
            string filePath = @"D:\Training\" + fileName;
            FileStream fs = null;
            try
            {
            fs=new FileStream(filePath, FileMode.Open, FileAccess.Write);
                StreamWriter sr = null;
                try
                {
                    sr = new StreamWriter(fs);
                    Console.WriteLine("Enter Person Name :");
                    string name =Console.ReadLine();
                    Console.WriteLine("Enter Person Address :");
                    string address=Console.ReadLine();
                    Console.WriteLine("Enter Person City :");
                    string city=Console.ReadLine();
                    Console.WriteLine("Enter Person Country :");
                    string country=Console.ReadLine();
                    string linetoAdd=string.Concat("Name:",name,",","Address:",address,",",
                        "City:",city,",","Country:",country);
                    sr.WriteLine(linetoAdd);
                    sr.Flush();
                }
                catch (Exception ex)
                {

                    fs.Close() ;
                    sr.Close() ;
                }
            }catch(Exception ex)
            {
                Console.WriteLine("File not found !!!!! ");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
