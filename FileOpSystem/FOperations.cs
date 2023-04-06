using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOpSystem
{
    public class FOperations
    {
        public void CreateFileInFolder()
        {
            const string folderPath = @"UserFiles\";

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            Console.WriteLine("Enter file name:");
            string fileName = Console.ReadLine();
            string filePath = folderPath + fileName;

            if (File.Exists(filePath))
            {
                Console.WriteLine("File with this name already exists. Please choose a different name.");
                return;
            }

            Console.WriteLine("Enter file text:");
            string fileText = Console.ReadLine();

            using (StreamWriter writer = File.CreateText(filePath))
            {
                writer.Write(fileText);
            }

            Console.WriteLine("File created successfully in the folder.");
        }

        public void EditFileInFolder()
        {
            Console.WriteLine("Enter file name to edit:");
            string fileName = Console.ReadLine();

            
            string currentDirectoryPath = Path.Combine(Directory.GetCurrentDirectory(), "UserFiles");
            DirectoryInfo currentDirectory = new DirectoryInfo(currentDirectoryPath);
            string path = Path.Combine(currentDirectory.FullName,fileName);

            if (File.Exists(path))
            {
                Console.WriteLine("Enter new file text: ");
                string fileText = Console.ReadLine();

                using (StreamWriter writer = File.CreateText(path))
                {
                    writer.Write(fileText);
                    Console.WriteLine("File edited successfully in the folder.");
                }
            }
            else
            {
                Console.WriteLine("File not found in the folder.");
            }

        }

        public void DeleteFileInFolder()
        {
            Console.WriteLine("Enter file name to delete:");
            string fileName = Console.ReadLine();


            string currentDirectoryPath = Path.Combine(Directory.GetCurrentDirectory(), "UserFiles");
            DirectoryInfo currentDirectory = new DirectoryInfo(currentDirectoryPath);
            string path = Path.Combine(currentDirectory.FullName, fileName);

            if (File.Exists(path))
            {

                File.Delete(path);

                Console.WriteLine("File successfully  deleted from folder");
            }
            else
            {
                Console.WriteLine("File not found in the folder.");
            }
        }
    }
}
