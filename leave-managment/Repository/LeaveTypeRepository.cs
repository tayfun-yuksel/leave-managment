using leave_managment.Contracts;
using leave_managment.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_managment.Repository
{
    public class LeaveTypeRepository : ILeaveTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public LeaveTypeRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(LeaveType entity)
        {
            _db.LeaveTypes.Add(entity);
            return Save();
        }

        public bool Delete(LeaveType entity)
        {
            _db.LeaveTypes.Remove(entity);
            return Save();
        }

        public ICollection<LeaveType> FindAll()
        {
            return _db.LeaveTypes.ToList();
        }

        public LeaveType FindById(int Id)
        {
            return _db.LeaveTypes.Find(Id);
        }

        public ICollection<LeaveType> GetEmployeesByLeaveType(int Id)
        {
            throw new NotImplementedException();
        }

        public bool Read(LeaveType entity)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            return _db.SaveChanges()>0;
        }

        public bool Update(LeaveType entity)
        {
            _db.LeaveTypes.Update(entity);
            return Save();
        }
    }
}
