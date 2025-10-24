using DataLayer.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Services
{

    public interface IUserRepository
    {
        Task<Response> GetAll();
        Task<Response> Get(int id);
        Task<Response> Create();

    }

    public class UserRepository
    {
        private readonly DBContext _context;
        public UserRepository(DBContext context)
        {
            _context = context;
        }

        public async Task<Response> GetAll()
        {
            Response response = new Response(TypeOfResponse.OK, "Bien");
            try
            {
                var users = _context.Users.ToList();
                response.Data = users;                
            }
            catch (Exception ex)
            {
                response.TypeOfResponse = TypeOfResponse.Exception;
                response.Message = ex.Message;

            }
            return response;
        }
    }
}

