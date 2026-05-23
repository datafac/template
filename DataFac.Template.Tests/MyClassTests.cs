using Shouldly;
using Xunit;

namespace DataFac.Template.Tests
{
    public class MyClassTests
    {
        [Fact]
        public void Test1()
        {
            // arrange
            using var myClass = new MyClass1("Alice");

            // act
            var result = myClass.GetGreeting("Bob");

            // assert
            result.ShouldBe("Hello Bob, my name is Alice.");
        }
    }
}