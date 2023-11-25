using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Controller
    {
        private CheckAuth checkAuth;
        private ConsoleUserInteraction consoleUserInteraction;
        private ExternalDependencySim externalDependencySimulator;
        private DatabaseHandler databaseHandler;
        private UserInput userInput;

        public Controller(CheckAuth checkAuth, ConsoleUserInteraction consoleUserInteraction, ExternalDependencySim externalDependencySimulator, DatabaseHandler databaseHandler, UserInput userInput)
        {
            this.checkAuth = checkAuth;
            this.consoleUserInteraction = consoleUserInteraction;
            this.externalDependencySimulator = externalDependencySimulator;
            this.databaseHandler = databaseHandler;
            this.userInput = userInput;
        }

        public void Run()
        {
            (string authResult, string errorMessage) = checkAuth.CheckData(userInput.Login, userInput.Password, userInput.RepeatPassword);

            if (authResult == " ")
            {
                string result = databaseHandler.GetData(userInput.Login, userInput.Password, userInput.RepeatPassword);

                consoleUserInteraction.DisplayResult(result);

                externalDependencySimulator.SendEmail(result);
            }
            else
            {
                consoleUserInteraction.DisplayResult(errorMessage);
            }
        }
    }
}

