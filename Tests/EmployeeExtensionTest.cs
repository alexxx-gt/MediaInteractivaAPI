using System;
using System.Collections.Generic;
using System.Text;
using BLL.Infrastructure.Extensions;
using DAL.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharedModels.DTOs;
using SharedModels.Enums;

namespace Tests
{
    [TestClass]
    public class EmployeeExtensionTest
    {
        [TestMethod]
        public void ConvertAnimalToDto()
        {
            var employeeDbModel = new Employee() { FirstName = "John", LastName = "Smith", Id = 1, IsMIEmployee = true};
            var employeeDto = new EmployeeDto() {Id = 1, FirstName = "John", LastName = "Smith", IsMIEmployee = true };

            Assert.AreEqual(employeeDto, employeeDbModel.MapToDto());
        }
    }
}
