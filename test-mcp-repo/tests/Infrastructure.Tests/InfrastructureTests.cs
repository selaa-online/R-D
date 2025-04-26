using Xunit;
using YourNamespace.Infrastructure.Persistence; // Adjust the namespace as necessary
using YourNamespace.Infrastructure.Repositories; // Adjust the namespace as necessary
using Microsoft.EntityFrameworkCore;

namespace YourNamespace.Infrastructure.Tests
{
    public class InfrastructureTests
    {
        private readonly AppDbContext _context;

        public InfrastructureTests()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            _context = new AppDbContext(options);
        }

        [Fact]
        public void ExampleRepository_AddsEntity_Successfully()
        {
            // Arrange
            var repository = new ExampleRepository(_context);
            var exampleEntity = new ExampleEntity { /* Set properties */ };

            // Act
            repository.Add(exampleEntity);
            _context.SaveChanges();

            // Assert
            var retrievedEntity = _context.ExampleEntities.Find(exampleEntity.Id);
            Assert.NotNull(retrievedEntity);
        }

        [Fact]
        public void AppDbContext_CanRetrieveEntities()
        {
            // Arrange
            var repository = new ExampleRepository(_context);
            var exampleEntity = new ExampleEntity { /* Set properties */ };
            repository.Add(exampleEntity);
            _context.SaveChanges();

            // Act
            var entities = repository.GetAll();

            // Assert
            Assert.Contains(entities, e => e.Id == exampleEntity.Id);
        }
    }
}