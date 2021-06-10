using System;

namespace WK6SESSAPP
{
    class NidaClone
    {

        private UserData database = new UserData();

        static void Main(string[] args)
        {
            Console.WriteLine("NIDA-NAMBA REGISTRATION SYSTEM");

            #region Task 7
            //Run the Application
            #endregion

            NidaClone nida = new NidaClone();
            nida.Run();

        }

        public void Meshack() { }

        private void Run()
        {
            Console.WriteLine("App is Running...");

            database.SaveUser();

            Console.ReadKey();

            #region Task 0
            //Display all Users
            database.AllUsers();
            #endregion


            #region Task 1
            //Single User by id
            Console.Write("Find user by id: ");

            var userid = Console.ReadLine();
            if (!int.TryParse(userid, out int no)) {
                Console.WriteLine("Please enter a number.");
            }
            else {
                database.findById(no);
            }

            #endregion

            Console.WriteLine("App is Closing...");

            Console.ReadKey();
        }
    }
}
