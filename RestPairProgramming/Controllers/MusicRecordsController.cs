﻿using Microsoft.AspNetCore.Mvc;
using RestPairProgramming.Managers;
using RestPairProgramming.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace RestPairProgramming.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MusicRecordsController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public ActionResult<IEnumerable<MusicRecord>> GetAll() {
            if (MusicRecordsManager.GetAll() == null||MusicRecordsManager.GetAll().Count==0)
            {
                return NoContent();
            }
            return Ok(MusicRecordsManager.GetAll());
        } 

        [HttpGet]
        [Route("bytitle")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public ActionResult<IEnumerable<MusicRecord>> GetByTitle([FromQuery] string title)
        {
            if (MusicRecordsManager.GetByTitle(title) == null || MusicRecordsManager.GetByTitle(title).Count == 0)
            {
                return NoContent();
            }
            return Ok(MusicRecordsManager.GetByTitle(title));
        }

        [HttpGet]
        [Route("byartist")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public ActionResult<IEnumerable<MusicRecord>> GetByArtist([FromQuery] string artist)
        {
            if (MusicRecordsManager.GetByArtist(artist) == null || MusicRecordsManager.GetByArtist(artist).Count == 0)
            {
                return NoContent();
            }
            return Ok(MusicRecordsManager.GetByArtist(artist));
        }

        [HttpGet]
        [Route("bygenre")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public ActionResult<IEnumerable<MusicRecord>> GetByGenre([FromQuery] string genre)
        {
            if (MusicRecordsManager.GetByGenre(genre) == null || MusicRecordsManager.GetByGenre(genre).Count == 0)
            {
                return NoContent();
            }
            return Ok(MusicRecordsManager.GetByGenre(genre));
        }


    }
}
