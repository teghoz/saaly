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

            var differences = historicalAuditableTypes.Except(historicalAuditableModels).ToList();

            var check = differences.Count();

            var messages = string.Join(",", differences);

            Assert.That(check == 0, Is.True, messages + " should have audit table(s)");
        }
    }
}
