using NUnit.Framework;
using Moq;
using Lab3;
using Xunit;

namespace TestProject2
{
    public class Tests
    {
        [TestFixture]
        public class ControllerTests
        { 
            //[Fact]
            //public void Run_ValidInput_DisplayResultAndSendEmail()
            //{
            //    var checkAuthMock = new Mock<CheckAuth>();
            //    checkAuthMock.Setup(x => x.CheckData(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()))
            //        .Returns((" ", string.Empty));

            //    var consoleUserInteractionMock = new Mock<ConsoleUserInteraction>();
            //    var externalDependencySimulatorMock = new Mock<ExternalDependencySim>();
            //    var databaseHandlerMock = new Mock<DatabaseHandler>();
            //    databaseHandlerMock.Setup(x => x.GetData(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()))
            //        .Returns("TestResult");

            //    var userInput = new UserInput
            //    {
            //        Login = "Логин",
            //        Password = "Пароль12$",
            //        RepeatPassword = "Пароль12$"
            //    };

            //    var controller = new Controller(
            //        checkAuthMock.Object,
            //        consoleUserInteractionMock.Object,
            //        externalDependencySimulatorMock.Object,
            //        databaseHandlerMock.Object,
            //        userInput
            //    );

            //    controller.Run();

            //    consoleUserInteractionMock.Verify(x => x.DisplayResult("TestResult"), Times.Once);
            //    externalDependencySimulatorMock.Verify(x => x.SendEmail("TestResult"), Times.Once);
            //}

        }
        
    }
}