using System;
using System.Collections.Generic;
using System.Text;
using SharedModels.Enums;

namespace DAL.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public EAnimalType Type { get; set; }
        public string Name { get; set; }
        public int OwnerId { get; set; }

        public Employee Owner { get; set; }
    }
}
