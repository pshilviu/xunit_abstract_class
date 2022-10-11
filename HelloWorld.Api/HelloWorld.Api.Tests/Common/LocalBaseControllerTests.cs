using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace HelloWorld.Api.Tests.Common
{
    public abstract class LocalBaseControllerTests<TController>
    {
        protected Type ControllerType { get; } = typeof(TController);

        /// <summary>
        /// Test Explore shows the test, and it can determine the source.
        /// When the test is selected, one can see in Test Detail Summary:
        /// Source: LocalBaseControllerTests.cs line 18 and it can be navigated to it.
        /// Test can be run without issues.
        /// </summary>
        [Fact]
        public void BaseSameAssembly_ShouldBeDecoratedWithExcludeFromCodeCoverageAttribute()
        {
            // Arrange & Act
            var attributes = ControllerType
                .GetCustomAttributes<ExcludeFromCodeCoverageAttribute>()
                .Select(x => x).ToArray();

            // Assert
            Assert.Single(attributes);
        }
    }
}
