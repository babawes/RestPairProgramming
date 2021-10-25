using Microsoft.AspNetCore.Mvc;
using RestPairProgramming.Managers;
using RestPairProgramming.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestPairProgramming.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MusicRecordsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<MusicRecord> GetAll() {
            return MusicRecordsManager.GetAll();
        } 
    }
}
