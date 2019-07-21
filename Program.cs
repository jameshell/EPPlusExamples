using System;
using reportsInNetCore.models;
using reportsInNetCore.utils;

namespace reportsInNetCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            User user = new User("Jaime",324244,"Cra 16 #85-27", 25);

            ExcelMethods utils = new ExcelMethods();
            utils.userReports();

            Console.WriteLine($"The user created is named: {user.Name}");
            Console.WriteLine($"The user report was created...");
        }
    }
}
