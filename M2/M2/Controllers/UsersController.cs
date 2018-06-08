using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using M2BLL.Managers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using M2BLL.DataTransferObjects;

namespace M2PL.Controllers
{
    [Produces("application/json")]
    [Route("api/Users")]
    public class UsersController : BaseController
    {
        private readonly UserManager _userManager;


        public UsersController(IMapper mapper, UserManager userManager) : base(mapper)
        {
            _userManager = userManager;

        }

        // GET: api/Users
        [HttpGet]
        public IEnumerable<UserDTO> GetAsync()
        {
            return _userManager.GetAllUsers();
        }

        // GET: api/Users/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<UserDTO> GetAsync(string id)
        {
            return await _userManager.GetUserByIdAsync(id);
        }
        
        // POST: api/Users
        [HttpPost]
        public async Task PostAsync([FromBody]UserDTO value)
        {
            await _userManager.CreateAsync(value);
        }
        
        // PUT: api/Users/5
        [HttpPut("{id}")]
        public async Task Put(string id, [FromBody]UserDTO user)
        {
            await _userManager.UpdateAsync(user, id);
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task Delete(string id)
        {
            await _userManager.DeleteUserById(id);
        }
    }
}
