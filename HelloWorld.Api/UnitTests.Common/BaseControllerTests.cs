using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace UnitTests.Common
{
    public abstract class BaseControllerTests<TController>
    {
        protected Type ControllerType { get; } = typeof(TController);

        /// <summary>
        /// Test Explore shows the test, however it cannot determine the source.
        /// When the test is selected, one can see in Test Detail Summary:
        /// "No source available". Thus it cannot be navigated to it by using F12 on the test,
        /// or the "Go To Test" context menu action.
        /// Test can be run without issues.
        /// </summary>
        [Fact]
        public void BaseDiffAssembly_ShouldBeDecoratedWithExcludeFromCodeCoverageAttribute()
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
