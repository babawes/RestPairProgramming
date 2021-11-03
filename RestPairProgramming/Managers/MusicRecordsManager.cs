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

        public static List<MusicRecord> GetByTitle(string title)
        {
            return Data.FindAll((MusicRecord mr) => {
                if (mr.Title.ToLowerInvariant().StartsWith(title.ToLowerInvariant())) return true;
                else return false;
            });
        }

        public static List<MusicRecord> GetByArtist(string artist)
        {
            return Data.FindAll((MusicRecord mr) => {
                if (mr.Artist.ToLowerInvariant().StartsWith(artist.ToLowerInvariant())) return true;
                else return false;
            });
        }

        public static List<MusicRecord> GetByGenre(string genre)
        {
            return Data.FindAll((MusicRecord mr) => {
                if (mr.Genre.ToLowerInvariant().StartsWith(genre.ToLowerInvariant())) return true;
                else return false;
            });
        }

        public static bool AddMusicRecord(MusicRecord record) {
            int tmp = Data.Count;
            Data.Add(record);
            if(tmp + 1 == Data.Count) { return true; }
            return false;
        }

        public static bool DeleteMusicRecord(MusicRecord record)
        {
            return Data.Remove(record);
        }

        public static bool UpdateMusicRecord(MusicRecord oldRecord, MusicRecord newRecord) {
            if(Data.Remove(oldRecord)) {
                Data.Add(newRecord);
            }
            return Data.Contains(newRecord);
        }
    }
}