using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ddd.service.DTO;
using ddd.service.Services;
using Microsoft.AspNetCore.Mvc;

namespace ddd.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        BalanceService _balanceService;
        public ValuesController(BalanceService balanceService)
        {
            _balanceService = balanceService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var dto = new CreateBalanceDTO();
            dto.BankCard = "1";
            dto.BlongAccount = "2";
            dto.IdCard = "3";
            dto.IsValid = true;
            dto.MerchantId = Guid.NewGuid();
            dto.Money = 1;
            dto.Name = "cys";
            dto.PhoneNum = "159";
            dto.ServiceRate = 0.08m;
            dto.Source = 1;
            dto.Status = 200;
            _balanceService.CreateBalanceInfo(dto);
            return new string[] { "value1", "value2" };
        }


    }
}
