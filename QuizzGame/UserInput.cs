using System;
using System.Collections.Generic;
using System.Text;

namespace QuizzGame
{
    public class UserInput
    {
        public char RequestInput()
        {
            char choice = (char)Console.Read();

            return choice;
        }
    }
}
