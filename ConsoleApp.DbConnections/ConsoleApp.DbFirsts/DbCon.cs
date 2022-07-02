using ConsoleApp.DbFirsts.Data;
using ConsoleApp.DbFirsts.Models;

using System.Data.SqlClient;

namespace ConsoleApp.DbConnections
{
    public class DbCon
    {
        //private const string connectionString = "Data Source=DESKTOP-18I9M7G\\SQLEXPRESS;Initial Catalog = Console.DbCon; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private static DefaultContexts db = new DefaultContexts();
        public static void GetAll()
        {
            var data = db.Student.ToList();
            foreach (var item in data)
            {
                Console.WriteLine($"Id : {item.Id}");
                Console.WriteLine($"Name : {item.Name}");
                Console.WriteLine($"Email : {item.Email}");
                Console.WriteLine($"Phone : {item.Phone}");
                Console.WriteLine("========================================");
            }
        }

        

        public static void GetById()
        {
            Console.WriteLine("Enter the id");
            var id = Convert.ToInt32(Console.ReadLine());

            var item = db.Student.Find(id);

            Console.WriteLine($"Id : {item.Id}");
            Console.WriteLine($"Name : {item.Name}");
            Console.WriteLine($"Email : {item.Email}");
            Console.WriteLine($"Phone : {item.Phone}");
            Console.WriteLine("========================================");
        }

        public static void Create()
        {
            var Students = new Students();


            Console.WriteLine("Enter the name");
            Students.Name = Console.ReadLine();
            Console.WriteLine("Enter the email");
            Students.Email = Console.ReadLine();
            Console.WriteLine("Enter the phone");
            Students.Phone = Console.ReadLine();

            db.Student.Add(Students);
            db.SaveChanges();
        }

        public static void Edit()
        {
            Console.WriteLine("Enter the id");
            var id = Convert.ToInt32(Console.ReadLine());
            var existing = db.Student.Find(id);
            if (existing != null)
            {
            Console.WriteLine("Enter the name");
            existing.Name = Console.ReadLine();
            Console.WriteLine("Enter the email");
            existing.Email = Console.ReadLine();
            Console.WriteLine("Enter the phone");
            existing.Phone = Console.ReadLine();

                db.Student.Update(existing);
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("REcord not found");
            }

            
        }

        public static void Delete()
        {
            Console.WriteLine("Enter the id");
            var id = Convert.ToInt32(Console.ReadLine());
            var existing = db.Student.Find(id);
            if (existing != null)
            {
                

                db.Student.Remove(existing);
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("REcord not found");
            }



        }
    }
}