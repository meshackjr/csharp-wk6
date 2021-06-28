using NidaCloneApp;
using System;
using System.Collections;
using System.Collections.Generic;

namespace WK6SESSAPP
{
    public class UserData
    {
        private int USRID = 0;

        private int UserLimit = 1;

        public int USERID { get { return USRID++; } set { USRID = value ; } }

        private List<User> usersDB = new List<User>();

        private NidaNumberGenerator generator = new NidaNumberGenerator();

        public int ID { get { return USRID ++; } }

        public void SaveUser()
        {
            
            for (int i = USERID; i < UserLimit; i++)
            {
                var user_ = new User();
                user_.Id = USERID;

                #region Task 4
                //Assign necessary data to the user_ object

                Console.WriteLine("User ID:" + user_.Id);

                Console.Write("Enter your Firstname: ");
                user_.FirstName = Console.ReadLine();

                Console.Write("Enter your Lastname: ");
                user_.LastName = Console.ReadLine();

                Console.Write("Enter your Email Address: ");
                user_.EmailAddress = Console.ReadLine();

                Console.Write("Enter your Age: ");
                user_.Age = Convert.ToInt32(Console.ReadLine());

                #endregion
                usersDB.Add(user_);

                Console.WriteLine("Data Succesfully saved!");

            }

        }

        public void AllUsers()
        {
            foreach (var item in usersDB)
            {
                printUser(item);
            }
        }


        #region Task 6
        //Write a function to find a user by there id
        #endregion

        public void findById(int userId) {
            User user = usersDB.Find(user => {
                return user.Id == userId;
            });

            if (user != null)
            {
                printUser(user);
            }
            else {
                Console.WriteLine("No user with id of {0} could be found", userId);
            }
        }

        public void printUser(User user) {
            #region Task 5
            //Include Nida Identity Number for all users
            #endregion

            string userString = string.Format("\nUserID = {0}\n Firstname: {1}\n Lastname" +
                    ": {2}\n Email: {3}\n Age: {4}\n NidaNo: {5}",
                    user.Id, user.FirstName, user.LastName,
                    user.EmailAddress, user.Age, user.NidaIdentityNo);

            Console.WriteLine(userString);
        }
    }
}