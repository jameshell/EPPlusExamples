using System;
using System.Collections.Generic;
using System.Data;
using Newtonsoft.Json;
using reportsInNetCore.models;
using reportsInNetCore.utils;

namespace reportsInNetCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<User> users = new List<User>(){
                new User("Jaime",3242424,"Cra 16 #115", 25),
                new User("Javier",3242444,"Cra 14 #74-32", 22),
                new User("Eliana",3246644,"Cra 7 #80", 55)
            };
            
            // We need to create a table to succesfully convert it to an excel table.
            DataTable table = (DataTable)JsonConvert.DeserializeObject(JsonConvert.SerializeObject(users), (typeof(DataTable)));

            ExcelMethods utils = new ExcelMethods();

            utils.userReports(table, "users.xlsx");

            Console.WriteLine($"The user report was created...");
        }
    }
}
