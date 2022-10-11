using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using UnitTests.Common.MsTests;

namespace HelloWorld.Api.Tests
{
    [TestClass]
    public class ControllerTests : BaseControllerTests<HelloWorldController>
    {
        /// <summary>
        /// Test Explore shows and determines the Source of this test correctly
        /// and it can be navigated to it by using F12 on the test,
        /// or the "Go To Test" context menu action.
        /// Test can be run without issues.
        /// </summary>
        [TestMethod]
        public void Local_ShouldBeDecoratedWithExcludeFromCodeCoverageAttribute()
        {
            // Arrange & Act
            var attributes = ControllerType
                .GetCustomAttributes<ExcludeFromCodeCoverageAttribute>()
                .Select(x => x).ToArray();

            // Assert
            Assert.IsTrue(attributes.Length == 1);
        }
    }
}
