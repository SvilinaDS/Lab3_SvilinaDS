using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public struct UserInput
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string RepeatPassword { get; set; }
    }

    public interface IUserInteraction
    {
        UserInput GetUserInput();
        void DisplayResult(string result);
    }

    public class ConsoleUserInteraction : IUserInteraction
    {
        public UserInput GetUserInput()
        {
            Console.WriteLine("Введите логин:");
            string login = Console.ReadLine();

            Console.WriteLine("Введите пароль:");
            string password = Console.ReadLine();

            Console.WriteLine("Повторите пароль:");
            string repeatPassword = Console.ReadLine();

            return new UserInput { Login = login, Password = password, RepeatPassword = repeatPassword };
        }

        public void DisplayResult(string result)
        {
            Console.WriteLine(result);
        }
    }
}
