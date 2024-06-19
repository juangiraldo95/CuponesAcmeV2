

using Cuponesv2.Models;
using CuponesV2.Data;
using CuponesV2.Services.Rol;

namespace CuponesV2.Services
{
    public class RolRepository:IRolRespository
    {
        private readonly BaseContext _context;
        public RolRepository(BaseContext context)
        {
            _context = context;
        }
        public void Create(Role role)
        {
            _context.Add(role);
            _context.SaveChanges();
        }
        public void Delete(Role role)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Role> GetAll()
        {
            return _context.Roles.ToList();
        }
        public Role GetById(int id)
        {
            throw new NotImplementedException();
        }
        public void Update(Role role)
        {
            throw new NotImplementedException();
        }

    }
}