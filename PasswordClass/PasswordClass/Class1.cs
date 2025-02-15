using System.Text.RegularExpressions;

namespace PasswordClass
{
    public class PasswordVerifier
    {
        public bool Verify(string password) => IsPasswordPassedLengthRule(password, 8);

        public bool IsPasswordPassedLengthRule(string password, int length)
        {
            if (password == String.Empty)
            {
                return false;
            }
            else if (password.Length <= length)
            {
                return false;
            }

            bool isUpperCase = false;

            foreach (char c in password)
            {
                if ((int)c >= 65 && (int)c <= 90)
                {
                    isUpperCase = true;
                    break;
                }
            }

            if (isUpperCase == false)
            {
                return false;
            }

            bool isLowerCase = false;

            foreach (char c in password)
            {
                if ((int)c >= 97 && (int)c <= 122)
                {
                    isLowerCase = true;
                    break;
                }
            }

            if (isLowerCase == false)
            {
                return false;
            }
            if (!Regex.IsMatch(password, @"[!@#$%^&*()_+\-=\[\]{};':""\\|,.<>\/?]"))
            {
                return false;
            }
            if(!Regex.IsMatch(password, @"\d"))
            {
                return false;
            }
            return true;
        }
    }
}
