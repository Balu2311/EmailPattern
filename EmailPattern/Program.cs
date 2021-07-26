using System;
using System.Text.RegularExpressions;

namespace EmailPattern
{
    class Program
    {
        public static string REGEX_PATTERN = "^[A-Z]{1}[a-zA-Z]{2,}";
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome_To_Email Pattern");
            EmailValidation();
        }
        public static void EmailValidation()
        {
            string EMAIL_PATTERN = "^[A-Z0-9a-z]{1,}([.#$^+-][A-Za-z0-9]+)*[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";
            Regex rg = new Regex(EMAIL_PATTERN);
            Console.Write("Enter E-mail: ");
            string email = Console.ReadLine();
            bool validate = rg.IsMatch(email);
            if (validate)
                Console.WriteLine("Email is valid : " + email);
            else
                Console.WriteLine("Invalid E-mail.");
        }
    }
}