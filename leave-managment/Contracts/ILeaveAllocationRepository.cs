using leave_managment.Data;
using leave_managment.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_managment.Contracts
{
    public interface ILeaveAllocationRepository : IRepositoryBase<LeaveAllocation>
    {
        bool CheckAllocaiton(int leaveTypeId, string employeeId );
        ICollection<LeaveAllocation> GetLeaveAllocationsByEmployee(string Id);
    }
}
