using System;
using Xunit;
using Moq;
using UnitTest_Mock.Services;
using UnitTest_Mock.Models;
using UnitTest_Mock.Controllers;

namespace UnitTesting
{
    public class EmployeeTest
    {
        #region property
        public Mock<IEmployeeService> mock = new Mock<IEmployeeService>();
        #endregion

        [Fact]
        public async void GetEmployeebyId()
        {
            mock.Setup(p => p.GetEmployeebyId(1)).ReturnsAsync("JK");
            EmployeeController emp = new EmployeeController(mock.Object);
            string result = await emp.GetEmployeeById(1);
            Assert.Equal("JK", result);
        }

        [Fact]
        public async void GetEmployeeDetails()
        {
            var employeeDTO = new Employee()
            {
                Id = 1,
                Name = "JK",
                Designation = "SDE"
            };
            mock.Setup(p => p.GetEmployeeDetails(1)).ReturnsAsync(employeeDTO);
            EmployeeController emp = new EmployeeController(mock.Object);
            var result = await emp.GetEmployeeDetails(1);
            Assert.True(employeeDTO.Equals(result));
        }


        // [Fact]
        // public void Test1()
        // {

        // }
    }
}