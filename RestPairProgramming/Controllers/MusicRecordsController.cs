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

        [HttpGet]
        [Route("bytitle")]
        public IEnumerable<MusicRecord> GetByTitle([FromQuery] string title)
        {
            return MusicRecordsManager.GetByTitle(title);
        }

        [HttpGet]
        [Route("byartist")]
        public IEnumerable<MusicRecord> GetByArtist([FromQuery] string artist)
        {
            return MusicRecordsManager.GetByArtist(artist);
        }

        [HttpGet]
        [Route("bygenre")]
        public IEnumerable<MusicRecord> GetByGenre([FromQuery] string genre)
        {
            return MusicRecordsManager.GetByGenre(genre);
        }


    }
}
