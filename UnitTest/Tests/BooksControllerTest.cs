using Xunit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UnitTest.Controllers;
using UnitTest.Data;
using UnitTest.Models;

namespace UnitTest.Tests
{
    public class EmployeeControllerTest
    {
        [Fact]

        public async Task Index_Returns_ViewResult_And_JobList()
        {
            using(var testDB = new UnitTestContext(this.GetTestDbOpts()))
            {
                var testCtrl = new EmployeesController(testDB);
                var res = await testCtrl.Index();
                var resVr = Assert.IsType<ViewResult>(res);
                Assert.IsAssignableFrom<IEnumerable<Employee>>(resVr.ViewData.Model);
            }
        }
        private DbContextOptions<UnitTestContext> GetTestDbOpts()
        {
            return new DbContextOptionsBuilder<UnitTestContext>().UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=UnitTest.Data;Trusted_Connection=True;MultipleActiveResultSets=true").Options;
        }
    }
}
