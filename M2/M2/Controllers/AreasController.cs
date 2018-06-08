using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using M2BLL.Managers;
using M2BLL.DataTransferObjects;

namespace M2PL.Controllers
{
    [Produces("application/json")]
    [Route("api/Areas")]
    public class AreasController : BaseController
    {
        AreaManager _areaManager;

        public AreasController(IMapper mapper, AreaManager areaManager) : base(mapper)
        {
            _areaManager = areaManager;
        }

        // GET: api/Areas
        [HttpGet]
        public IEnumerable<AreaDTO> Get()
        {
            return _areaManager.GetAllIncluding();
        }

        // GET: api/Areas/5
        [HttpGet("{id}", Name = "GetA")]
        public async Task<AreaDTO> GetAsync(string id)
        {
            return await _areaManager.GetIncluding(id);
        }
        
        // POST: api/Areas
        [HttpPost]
        public void Post([FromBody]AreaDTO value)
        {
            _areaManager.Create(value);
        }
        
        // PUT: api/Areas/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody]AreaDTO value)
        {
            _areaManager.Update(value);
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _areaManager.Delete(id);
        }
    }
}
