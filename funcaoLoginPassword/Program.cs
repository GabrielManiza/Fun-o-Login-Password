using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcaoLoginPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string admin = "xxxxx";

            for (; 1 == 1; )
            {
                Console.WriteLine("Login:");
                var loginid = Console.ReadLine();
                Console.WriteLine("\nPassword:");
                var password = ReadPassword();

                if (password == admin)
                {
                    Console.WriteLine("\nAltere a senha");
                    admin = ReadPassword();
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Senha incorreta, acesso negado.");
                    Console.WriteLine();
                }
            }
        }



        public static string ReadPassword()
        {
            string password = "";
            ConsoleKeyInfo info = Console.ReadKey(true);
            while (info.Key != ConsoleKey.Enter)
            {
                if (info.Key != ConsoleKey.Backspace)
                {
                    Console.Write("*");
                    password += info.KeyChar;
                }
                else
                    if (info.Key == ConsoleKey.Backspace)
                    {
                        if (!string.IsNullOrEmpty(password))
                        {
                            password = password.Substring(0, password.Length - 1);
                            int pos = Console.CursorLeft;
                            Console.SetCursorPosition(pos - 1, Console.CursorTop);
                            Console.Write(" ");
                            Console.SetCursorPosition(pos - 1, Console.CursorTop);
                        }
                    }
                info = Console.ReadKey(true);
            }
            Console.WriteLine();
            return password;
        }
    }
}

