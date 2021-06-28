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

            string id = string.Empty;
            Random random = new Random();

            for (int i = 0; i < 9; i++) {
                id += random.Next(0, 9);
            }

            return id;
        }
    }
}
