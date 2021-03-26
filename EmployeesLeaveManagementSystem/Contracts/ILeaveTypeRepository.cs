using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeesLeaveManagementSystem.Data;

namespace EmployeesLeaveManagementSystem.Repository
{
    public interface ILeaveTypeRepository : IRepositoryBase<LeaveType>
    {
        Task<ICollection<LeaveType>> GetEmployeesByLeaveType(int id);
    }
}
