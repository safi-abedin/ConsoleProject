using Microsoft.EntityFrameworkCore;
using System.IO;

namespace FileOpSystem
{
    public class DbOperations
    {
        public void CreateFileInDatabase()
        {
            using (var context = new AppDbContext())
            {
               
                Console.WriteLine("Enter file name:");
                string FileName = Console.ReadLine();
                Console.WriteLine("Enter file text:");
                string FileText = Console.ReadLine();

     
                var file = new data { fileName = FileName, fileText = FileText };

               
                context.Files.Add(file);

            
                context.SaveChanges();

                Console.WriteLine("File Created successfully in database .");
            }

        }

        public void EditFileInDatabase()
        {
            using (var context = new AppDbContext())
            {
                
                Console.WriteLine("Enter file name to edit: ");
                string fileName = Console.ReadLine();

                
                var fileToUpdate = context.Files.FirstOrDefault(f => f.fileName == fileName);

                if (fileToUpdate == null)
                {
                    Console.WriteLine("File not found in databaase!");
                    return;
                }

       
                Console.WriteLine("Enter new file text: ");
                string fileText = Console.ReadLine();

                
                fileToUpdate.fileText = fileText;
                context.Update(fileToUpdate);
                context.SaveChanges();

                Console.WriteLine("File edited successfully in database!");
            }

        }

        public void DeleteFileInDatabase()
        {
            using (var context = new AppDbContext())
            {

                Console.WriteLine("Enter file name to delete: ");
                string fileName = Console.ReadLine();


                var fileToDelete = context.Files.FirstOrDefault(f => f.fileName == fileName);

                if (fileToDelete == null)
                {
                    Console.WriteLine("File not found in database!");
                    return;
                }


                context.Files.Remove(fileToDelete);


                context.SaveChanges();

                Console.WriteLine("File deleted successfully from database!");
            }
        }
    }
}

