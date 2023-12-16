using Saaly.Models;
using Saaly.Models.Interfaces;

namespace Saaly.Data.Tests.AuditTests
{
    [TestFixture]
    public class Historical_Auditable_Models_Tests
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void Historical_Auditable_Models_Should_Have_Auditable_Models()
        {
            var historicalAuditableTypes = new List<string>();
            var historicalAuditableModels = new List<string>();

            //Assembly.GetExecutingAssembly().GetTypes()

            var types = typeof(ApplicationUser).Assembly.GetTypes();
            var concreteTypes = types.Where(t => typeof(IHistoricalAuditable).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract);

            string phraseToMatch = "Audit";
            var typesStartingWithPhrase = types.Where(t => t.Name.StartsWith(phraseToMatch, StringComparison.InvariantCultureIgnoreCase));

            foreach (var type in concreteTypes)
            {
                historicalAuditableTypes.Add($@"Audit{type.Name}");
            }

            foreach (var type in typesStartingWithPhrase)
            {
                historicalAuditableModels.Add(type.Name);
            }

            var check = historicalAuditableTypes.Except(historicalAuditableModels).ToList().Count();

            Assert.That(check == 0, Is.True, "1 should not be prime");
        }
    }
}
