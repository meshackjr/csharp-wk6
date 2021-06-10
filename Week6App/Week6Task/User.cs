using NidaCloneApp;
using System;

namespace WK6SESSAPP
{
    public class User:NidaNumberBase
    {
        #region Task 2
        //Inherit NidaIdentityNo from NidaNumberBase
        #endregion
        public int Id { get; set; }

        public int Age { get; set; }     

        public string FirstName { get; set; }

        public string  LastName { get; set; }

        public string EmailAddress { get; set; }

    }
}