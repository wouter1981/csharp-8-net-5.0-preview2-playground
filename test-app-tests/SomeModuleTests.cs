using System;
using Xunit;
using test_app;

namespace test_app_tests
{
    public class SomeModuleTests
    {
        [Fact]
        public void TestNameSetting()
        {
            var module = new SomeModule();
            module.Name = "test";
            Assert.Equal("Test", module.Name);
            module.Name = "test twowords";
            Assert.Equal("Test twowords", module.Name);
        }

        [Fact]
        public void TestVeryShortNameSetting()
        {
            var module = new SomeModule();
            module.Name = "t";
            Assert.Equal("T", module.Name);
        }

        [Fact]
        public void TestGreeting()
        {
            var module = new SomeModule();
            module.Name = "test";
            Assert.Equal("Hello Test", module.Greeting);
        }
    }
}
