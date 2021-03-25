using System;
using System.Collections.Generic;
using EmployeesLeaveManagementSystem.Data;

namespace EmployeesLeaveManagementSystem.Repository
{
    public interface ILeaveAllocationRepository : IRepositoryBase<LeaveAllocation>
    {
        bool CheckAllocation(int leavetypeid, string employeeid);
        ICollection<LeaveAllocation> GetLeaveAllocationsByEmployee(string id);
        LeaveAllocation GetLeaveAllocationsByEmployeeAndType(string employeeid, int leavetypeid);
    }
}
