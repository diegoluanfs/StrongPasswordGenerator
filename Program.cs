using System;
using System.Text;

namespace StrongPasswordGenerator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Pressione Enter para gerar uma senha aleatória. Para sair, pressione qualquer outra tecla.");
            while (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                int length = 12;
                string password = GenerateRandomPassword(length);
                Console.WriteLine("Senha Aleatória: " + password);
                Console.WriteLine("Pressione Enter para gerar outra senha ou qualquer outra tecla para sair.");
            }
        }

        static string GenerateRandomPassword(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+-=[]{}|;:,.<>?";

            Random random = new Random();
            StringBuilder password = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(chars.Length);
                password.Append(chars[index]);
            }

            return password.ToString();
        }
    }
}
