using System;
using System.Collections.Generic;
using EmployeesLeaveManagementSystem.Data;

namespace EmployeesLeaveManagementSystem.Repository
{
    public interface ILeaveRequestRepository : IRepositoryBase<LeaveRequest>
    {
        ICollection<LeaveRequest> GetLeaveRequestsByEmployee(string employeeid);
    }
}
