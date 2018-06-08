using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using M2BLL.Managers;
using AutoMapper;
using M2BLL.DataTransferObjects;

namespace M2PL.Controllers
{
    [Produces("application/json")]
    [Route("api/Plants")]
    public class PlantsController : BaseController
    {
        private readonly PlantManager _plantManager;
        

        public PlantsController(IMapper mapper, PlantManager plantManager) : base(mapper)
        {
            _plantManager = plantManager;
        }
        // GET: api/Plants
        [HttpGet]
        public async Task<IEnumerable<PlantDTO>> GetAsync()
        {
            return _plantManager.GetAllIncluding();
        }

        // GET: api/Plants/5
        [HttpGet("{id}", Name = "GetP")]
        public async Task<PlantDTO> GetAsync(string id)
        {
            return await _plantManager.GetIncluding(id);
        }
        
        // POST: api/Plants
        [HttpPost]
        public void Post([FromBody]PlantDTO value)
        {
            _plantManager.Create(value);
        }
        
        // PUT: api/Plants/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody]PlantDTO value)
        {
            _plantManager.Update(value);
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _plantManager.Delete(id);
        }
    }
}
