﻿namespace EmployeeAdminPortal.Models.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }   

        public required string  Name { get; set; }

        public string Email { get; set; }

        public string? PhoneNumber { get; set; } 

        public decimal Salary { get; set; } 
    }
}
