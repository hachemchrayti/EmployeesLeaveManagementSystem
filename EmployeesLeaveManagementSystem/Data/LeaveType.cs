using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeesLeaveManagementSystem.Data
{
    public class LeaveType
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }


        public DateTime DateCreated { get; set; }
    }
}