﻿namespace EmployeeAdminPortal.Models
{
    public class AddEmployeeDto
    {
        public required string Name { get; set; }

        public string Email { get; set; }

        public string? PhoneNumber { get; set; }

        public decimal salary { get; set; }
    }
}
