using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace UnitTests.Common.MsTests
{
    public abstract class BaseControllerTests<TController>
    {
        protected Type ControllerType { get; } = typeof(TController);

        [TestMethod]
        public void Base_ShouldBeDecoratedWithExcludeFromCodeCoverageAttribute()
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
