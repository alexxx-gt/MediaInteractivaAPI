using System;
using System.Collections.Generic;
using System.Text;
using SharedModels.Enums;

namespace SharedModels.DTOs
{
    public class AnimalDto
    {
        public int Id { get; set; }
        public EAnimalType Type { get; set; }
        public string Name { get; set; }
        public int OwnerId { get; set; }

        public override bool Equals(object obj)
        {
            AnimalDto objectForComparing = obj as AnimalDto;

            if (objectForComparing == null)
            {
                return false;
            }
            else
            {
                if (this.Id == objectForComparing.Id && this.Type == objectForComparing.Type &&
                    this.Name == objectForComparing.Name && this.OwnerId == objectForComparing.OwnerId)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
