

using Cuponesv2.Models;

namespace CuponesV2.Services.Rol
{
    public interface IRolRespository
    {
        void Create (Role role);
        void Update (Role role);
        void Delete (Role role);
        IEnumerable<Role> GetAll ();
        Role GetById (int id);
    }
}