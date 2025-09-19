namespace EmployeeAdminPortal.Models
{
    public class UpdateEmployeeDto
    {
        public required string Name { get; set; }

        public string Email { get; set; }

        public string? PhoneNumber { get; set; }

        public decimal Salary { get; set; }
    }
}
