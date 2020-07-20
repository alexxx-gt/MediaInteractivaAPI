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
    public class AnimalExtensionTests
    {
        [TestMethod]
        public void ConvertAnimalToDto()
        {
            var animalDbModel = new Animal() { Id = 1, Name = "Jack", Owner = new Employee() { FirstName = "John", LastName = "Smith", Id = 1, IsMIEmployee = true}, Type = EAnimalType.Cat, OwnerId = 1};
            var animalDto = new AnimalDto() {Id = 1, Name = "Jack", OwnerId = 1, Type = EAnimalType.Cat};

            Assert.AreEqual(animalDto, animalDbModel.MapToDto());
        }
    }
}
