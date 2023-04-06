using FileOpSystem;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

Console.WriteLine("Please select data storage:");
Console.WriteLine("1. Database");
Console.WriteLine("2. File");
Console.WriteLine("3. Exit");
var storageOption = Console.ReadLine();

while (storageOption != "3")
{
    switch (storageOption)
    {
        case "1":
            Console.WriteLine("Please select task:");
            Console.WriteLine("1. Create file");
            Console.WriteLine("2. Edit file");
            Console.WriteLine("3. Delete file");
            Console.WriteLine("4. Exit");
            var databaseOption = Console.ReadLine();

            switch (databaseOption)
            {
                case "1":
                    DbOperations operation = new DbOperations();
                    operation.CreateFileInDatabase();
                    break;
                case "2":
                    DbOperations operation1 = new DbOperations();
                    operation1.EditFileInDatabase();
                    break;
                case "3":
                    DbOperations operation2 = new DbOperations();
                    operation2.DeleteFileInDatabase();
                    break;
                case "4":
                    return;
            }
            break;
        case "2":
            Console.WriteLine("Please select task :");
            Console.WriteLine("1. Create file");
            Console.WriteLine("2. Edit file");
            Console.WriteLine("3. Delete file");
            Console.WriteLine("4. Exit");
            var fileOption = Console.ReadLine();

            switch (fileOption)
            {
                case "1":
                    FOperations operation = new FOperations();
                    operation.CreateFileInFolder();
                    break;
                case "2":
                    FOperations operation1 = new FOperations();
                    operation1.EditFileInFolder();
                    break;
                case "3":
                    FOperations operation2 = new FOperations();
                    operation2.DeleteFileInFolder();
                    break;
                case "4":
                    return;
            }
            break;
    }
}

