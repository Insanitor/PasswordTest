using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordTest
{
    class PasswordTester
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TestPasswordLength("Password1"));
            Console.WriteLine(TestPasswordContainsNumber("Password1"));
            Console.ReadKey();
        }
        
        //Check if password lenght is higher or equal to 5 and less or equal to 10
        static string TestPasswordLength(string password = "")
        {
            PasswordValidator pv = new PasswordValidator();
            return pv.IsLengthValid(password) ? "Password is valid" : "Password is invalid";
        }

        //Check if password contains a Digit
        static string TestPasswordContainsNumber(string password = "")
        {
            PasswordValidator pv = new PasswordValidator();
            return pv.ContainsNumber(password) ? "Password is valid" : "Password is invalid";
        }

        #region Customers have unrealistic expectations.
        ////Find the meaning of life
        //static string FindMeaningOfLife()
        //{
        //    DeepThought dt = new PandimensionalSuperComputer();
        //    return dt.CalculateMeaningOfLife();
        //}
        #endregion
    }

    internal class PasswordValidator
    {
        internal bool ContainsNumber(string password)
        {
            return password.Any(c => Char.IsDigit(c)) ? true : false;
        }

        internal bool IsLengthValid(string password)
        {
            return password.Length >= 5 && password.Length <= 10 ? true : false;
        }
    }
}
