using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.QualityTools.Testing.Fakes;
using MercuryHealth.Web.Utilities.Fakes;
using MercuryHealth.Web.Utilities;
using System.Fakes;

namespace MercuryHealth.UnitTests
{
    [TestClass]
    public class UserRepositoryTests
    {
        [TestMethod]
        [TestCategory("Unit Tests")]
        public void GenerateReportNameTest()
        {
            using (ShimsContext.Create())
            {
                ShimUserRepository.AllInstances.GetUserInt32 = (self, userId) => new User
                {
                    Id = userId,
                    FirstName = "Abel",
                    LastName = "Wang"
                };

                ShimDateTime.NowGet = () => new DateTime(2016, 2, 5);

                var calc = new HealthCalculator();
                var reportName = calc.GenerateReportName(25);

                var expectedDateTime = new DateTime(2016, 2, 5).ToString();

                Assert.AreEqual(expectedDateTime + ": Abel Wang", reportName, "Report name is wrong");
            }
        }
    }
}
