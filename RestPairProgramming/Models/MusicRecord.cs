using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestPairProgramming.Models
{
    public class MusicRecord
    {
        public string Title { get; set; }

        public string Artist { get; set; }
        public int Duration { get; set; }
        public int PublicationYear { get; set; }
        public string Genre { get; set; }

        public MusicRecord()
        {
            
        }

        public MusicRecord(string title, string artist, int duration, int publicationYear, string genre)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            PublicationYear = publicationYear;
            Genre = genre;
        }
    }
}
