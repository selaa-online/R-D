using Xunit;

namespace SharedKernel.Tests
{
    public class SharedKernelTests
    {
        [Fact]
        public void BaseEntity_ShouldHaveId()
        {
            // Arrange
            var entity = new BaseEntity();

            // Act
            var id = entity.Id;

            // Assert
            Assert.NotNull(id);
        }

        [Fact]
        public void Entity_ShouldImplementIEntity()
        {
            // Arrange
            var entity = new BaseEntity();

            // Act
            var isEntity = entity is IEntity;

            // Assert
            Assert.True(isEntity);
        }
    }
}