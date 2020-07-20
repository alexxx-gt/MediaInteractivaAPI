using System;
using System.Collections.Generic;
using System.Text;

namespace SharedModels.DTOs
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsMIEmployee { get; set; }

        public override bool Equals(object obj)
        {
            EmployeeDto objectForComparison = obj as EmployeeDto;

            if (objectForComparison == null)
            {
                return false;
            }
            else
            {
                if (this.Id == objectForComparison.Id && this.FirstName == objectForComparison.FirstName &&
                    this.LastName == objectForComparison.LastName &&
                    this.IsMIEmployee == objectForComparison.IsMIEmployee)
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
