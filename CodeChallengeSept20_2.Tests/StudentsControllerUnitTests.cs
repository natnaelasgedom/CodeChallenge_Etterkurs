using NUnit.Framework;
using CodeChallengeSept20_2;
using CodeChallengeSept20_2.Controllers;
using CodeChallengeSept20_2.Data;
using Microsoft.AspNetCore.Mvc;

namespace CodeChallengeSept20_2.Tests
{
    public class StudentsControllerUnitTests
    {
        public string connectionString =
            "Server=(localdb)\\mssqllocaldb;Database=UniversityOfSerafina3;Trusted_Connection=True;MultipleActiveResultSets=true";
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Index_Returns_ActionResult()
        {
            StudentsController controller = new StudentsController(new SchoolContext(connectionString));

            var actual = controller.Index("","","",1);

            Assert.IsInstanceOf<ActionResult>(actual);
        }
    }
}