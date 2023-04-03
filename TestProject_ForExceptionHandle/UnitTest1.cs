using System;
using System.IO;
using Day10_ExceptionHandling;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject_ForExceptionHandle
{

    [TestClass]
    public class CategoryTests
    {
        [TestMethod]
        public void TestGetCategory_Children()
        {
            // Arrange
            int age = 10;
            string expectedCategory = "Category: Children";
            Categorized categorized = new Categorized();

            // Act
            using (ConsoleOutput consoleOutput = new ConsoleOutput())
            {
                categorized.GetCategory(age);
                string actualCategory = consoleOutput.GetOuput();

                // Assert
                Assert.AreEqual(expectedCategory, actualCategory);
            }
        }

        [TestMethod]
        public void TestGetCategory_Youth()
        {
            // Arrange
            int age = 20;
            string expectedCategory = "Category: Youth";
            Categorized categorized = new Categorized();

            // Act
            using (ConsoleOutput consoleOutput = new ConsoleOutput())
            {
                categorized.GetCategory(age);
                string actualCategory = consoleOutput.GetOuput();

                // Assert
                Assert.AreEqual(expectedCategory, actualCategory);
            }
        }

        [TestMethod]
        public void TestGetCategory_Adults()
        {
            // Arrange
            int age = 40;
            string expectedCategory = "Category: Adults";
            Categorized categorized = new Categorized();

            // Act
            using (ConsoleOutput consoleOutput = new ConsoleOutput())
            {
                categorized.GetCategory(age);
                string actualCategory = consoleOutput.GetOuput();

                // Assert
                Assert.AreEqual(expectedCategory, actualCategory);
            }
        }

        [TestMethod]
        public void TestGetCategory_Seniors()
        {
            // Arrange
            int age = 80;
            string expectedCategory = "Category: Seniors";
            Categorized categorized = new Categorized();

            // Act
            using (ConsoleOutput consoleOutput = new ConsoleOutput())
            {
                categorized.GetCategory(age);
                string actualCategory = consoleOutput.GetOuput();

                // Assert
                Assert.AreEqual(expectedCategory, actualCategory);
            }
        }

        [TestMethod]
        public void TestGetCategory_InvalidAge()
        {
            // Arrange
            int age = -10;
            string expectedErrorMessage = "Invalid age entered.";
            Categorized categorized = new Categorized();

            // Act
            using (ConsoleOutput consoleOutput = new ConsoleOutput())
            {
                categorized.GetCategory(age);
                string actualErrorMessage = consoleOutput.GetOuput();

                // Assert
                Assert.AreEqual(expectedErrorMessage, actualErrorMessage);
            }
        }

    }

    public class ConsoleOutput : IDisposable
    {
        private readonly StringWriter stringWriter;
        private readonly TextWriter originalOutput;

        public ConsoleOutput()
        {
            stringWriter = new StringWriter();
            originalOutput = Console.Out;
            Console.SetOut(stringWriter);
        }

        public string GetOuput()
        {
            return stringWriter.ToString().Trim();
        }

        public void Dispose()
        {
            Console.SetOut(originalOutput);
            stringWriter.Dispose();
        }
    }
}
