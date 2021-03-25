using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EmployeesLeaveManagementSystem.Models
{
    public class LeaveAllocationVM
    {

        public int Id { get; set; }


        [Required]
        public int NumberOfDays { get; set; }


        public DateTime DateCreated { get; set; }


        public int Period { get; set; }

        public EmployeeVM Employee { get; set; }


        public string EmployeeId { get; set; }


        public LeaveTypeVM LeaveType { get; set; }


        public int LeaveTypeId { get; set; }

        public IEnumerable<SelectListItem> Employees { get; set; }


        public IEnumerable<SelectListItem> LeaveTypes { get; set; }
    }
}
