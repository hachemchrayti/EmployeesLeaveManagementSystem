using System;
using System.Collections.Generic;
using EmployeesLeaveManagementSystem.Data;

namespace EmployeesLeaveManagementSystem.Repository
{
    public interface ILeaveTypeRepository : IRepositoryBase<LeaveType>
    {
        ICollection<LeaveType> GetEmployeesByLeaveType(int id);
    }
}
