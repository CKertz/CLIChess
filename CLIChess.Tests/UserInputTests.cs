using NUnit.Framework;
using System;
using System.IO;
using System.Reflection;

namespace CLIChess.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IsValidUserInput_LongInput()
        {
            // Arrange

            UserInput userInput = new UserInput();
            MethodInfo methodInfo = typeof(UserInput).GetMethod("IsValidUserInput", BindingFlags.NonPublic | BindingFlags.Instance);
            // Act
            var result = methodInfo.Invoke(userInput, new object[] { "abvccef" });


            // Assert
            Assert.AreEqual(false, result);

            // text blob pasted here, this test works but should probably look into how logic is placed

            //Instead of testing private methods, you should focus on testing the public interface of the class, which includes its public methods and properties.Public methods are the only part of the class that are visible to clients and are therefore the most important to test.
            //If a private method contains complex logic that is critical to the behavior of a public method, then you should consider refactoring that logic into a separate class or method that can be tested independently.This can make your code more modular and easier to test.
            //In summary, while testing private methods is technically possible, it's generally not a good practice. Instead, focus on testing the public interface of your class, and refactor complex logic into separate classes or methods that can be tested independently.
        }
    }
}