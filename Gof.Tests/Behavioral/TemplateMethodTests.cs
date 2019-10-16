using Gof.Creational.TemplateMethod;
using Gof.Creational.TemplateMethod.Concrete;
using Xunit;

namespace Gof.Tests
{
    public class TemplateMethodTests
    {
        [Fact]
        public void ShouldReturnLinkToBuiltLostProfitReport()
        {
            var fake = new FakeClient { Report = new LostProfitReport() };
            Assert.Equal("/Reports/LostProfitReport.xlsx", fake.BuildReport());
        }

        [Fact]
        public void ShouldReturnLinkToBuiltPotentialRealProfitReport()
        {
            var fake = new FakeClient { Report = new PotentialRealProfitReport() };
            Assert.Equal("/Reports/PotentialRealProfitReport.xlsx", fake.BuildReport());
        }
    }
}