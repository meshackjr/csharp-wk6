using System;
using System.Collections.Generic;
using System.Text;

namespace NidaCloneApp
{
    public class NidaNumberGenerator
    {
        public string GeneratedNumber { get { return NumberGenerator(); } }


        private string NumberGenerator()
        {
            #region Task 3
            //generate a random string of 9 characters
            #endregion

            var userNo = new StringBuilder(9);
            Random random = new Random();
            for (int i = 0; i < 9; i++) {
                //userNo += ((char)(random.Next(1, 26) + 64)).ToString().ToLower();
                userNo.Append((char)(random.Next(1, 26) + 64));
            }

            return userNo.ToString().ToLower();
        }
    }
}
