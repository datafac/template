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
            MyClass myClass = new MyClass();

            // act
            var result = myClass.GetGreeting("World");

            // assert
            result.ShouldBe("Hello, World!");
        }
    }
}