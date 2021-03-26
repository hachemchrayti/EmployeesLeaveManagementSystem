using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeesLeaveManagementSystem.Data;

namespace EmployeesLeaveManagementSystem.Repository
{
    public interface ILeaveAllocationRepository : IRepositoryBase<LeaveAllocation>
    {
        Task<bool> CheckAllocation(int leavetypeid, string employeeid);
        Task<ICollection<LeaveAllocation>> GetLeaveAllocationsByEmployee(string employeeid);
        Task<LeaveAllocation> GetLeaveAllocationsByEmployeeAndType(string employeeid, int leavetypeid);
    }
}
