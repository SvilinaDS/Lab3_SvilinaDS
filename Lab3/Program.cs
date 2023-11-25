using Lab3;

class Program
{
    static void Main()
    {
        UserInput userInput = new UserInput
        {
            Login = "Login",
            Password = "Пароль12$",
            RepeatPassword = "Пароль12$"
        };

        Controller controller = new Controller(new CheckAuth(), new ConsoleUserInteraction(), new ExternalDependencySim(), new DatabaseHandler("DESKTOP-LTUDAGK\\SQLEXPRESS", "CheckAuth"), userInput);

        controller.Run();
    }

}


