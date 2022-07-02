namespace ConsoleApp.DbConnections
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var res = "N";
            do
            {
                try
                {
                    var choice = PrintChoices();
                    Run(choice);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine("Do you want to continue more?(y/n)");
                res = Console.ReadLine();
            } while (res.ToUpper() == "Y");
        }

        private static void Run(int choice)
        {
            switch (choice)
            {
                case 1:
                    DbCon.GetAll();
                    break;

                case 2:
                    DbCon.GetById();
                    break;

                case 3:
                    DbCon.Create();
                    break;

                case 4:
                    DbCon.Edit();
                    break;

                case 5:
                    DbCon.Delete();
                    break;

                default:
                    Console.WriteLine("Choice is invalid");
                    break;
            }
        }

        private static int PrintChoices()
        {
            Console.Clear();
            Console.WriteLine("1 to get all records");
            Console.WriteLine("2 to get record by id");
            Console.WriteLine("3 to create record");
            Console.WriteLine("4 to edit record");
            Console.WriteLine("5 to delete record");

            Console.WriteLine("Enter your choice");
            var choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
    }
}