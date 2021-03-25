using System;
using AutoMapper;
using EmployeesLeaveManagementSystem.Data;
using EmployeesLeaveManagementSystem.Models;

namespace EmployeesLeaveManagementSystem.Mappings
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
            CreateMap<LeaveHistory, LeaveHistoryVM>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationVM>().ReverseMap();
            CreateMap<Employee, EmployeeVM>().ReverseMap();
        }
    }
}
