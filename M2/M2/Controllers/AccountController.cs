using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using M2BLL.Managers;
using M2BLL.DataTransferObjects;

namespace M2PL.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class AccountController : BaseController
    {
        AccountManager _accountManager;
        
        public AccountController(IMapper mapper, AccountManager accountManager) : base(mapper)
        {
            _accountManager = accountManager;
        }        

        [HttpPost]
        public async Task<string> Login([FromBody]LoginDTO model)
        {
            if (ModelState.IsValid)
            {
                var result = await _accountManager.SignInAsync(model);
                if (result.Succeeded)
                {
                    return "+";
                }
                else
                {
                    return "-";
                }
            }
            return string.Empty;
        }

        [HttpGet]
        public void SignOut()
        {
            _accountManager.SignOutAsync();
        }


    }
}