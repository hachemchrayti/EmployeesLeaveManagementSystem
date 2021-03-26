using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeesLeaveManagementSystem.Data;

namespace EmployeesLeaveManagementSystem.Repository
{
    public interface ILeaveRequestRepository : IRepositoryBase<LeaveRequest>
    {
        Task<ICollection<LeaveRequest>> GetLeaveRequestsByEmployee(string employeeid);
    }
}
