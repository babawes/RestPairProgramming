using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestPairProgramming.Models;

namespace RestPairProgramming.Managers
{
    public static class MusicRecordsManager
    {
        private static List<MusicRecord> Data = new List<MusicRecord>()
        {
            new MusicRecord("album1","Artist1",34,25,"Rock"),
            new MusicRecord("album2","Artist5",346,22,"Pop"),
            new MusicRecord("album6","Artist2",43,52,"Rock")
        };

        public static List<MusicRecord> GetAll()
        {
            return Data;
        }

        

    }
}
