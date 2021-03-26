using System;
using System.Threading.Tasks;
using EmployeesLeaveManagementSystem.Data;
using EmployeesLeaveManagementSystem.Repository;

namespace EmployeesLeaveManagementSystem.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<LeaveType> LeaveTypes { get; }
        IGenericRepository<LeaveRequest> LeaveRequests { get; }
        IGenericRepository<LeaveAllocation> LeaveAllocations { get; }
        Task Save();
    }
}
