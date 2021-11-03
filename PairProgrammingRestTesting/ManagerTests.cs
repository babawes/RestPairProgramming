using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestPairProgramming.Managers;
using RestPairProgramming.Models;
using System.Collections.Generic;

namespace PairProgrammingRestTesting {
    [TestClass]
    public class ManagerTests {
        [TestMethod]
        public void GetAllMusicRecordsReturnsAnything() {
            Assert.IsNotNull(MusicRecordsManager.GetAll());
        }
        [TestMethod]
        public void GetAllMusicRecordsReturnsRecords() {
            Assert.IsTrue(MusicRecordsManager.GetAll() is List<MusicRecord>);
        }

        [TestMethod]
        public void GetByTests_ExceptionTests()
        {
            MusicRecordsManager.GetByTitle("r");
            MusicRecordsManager.GetByArtist("r");
            
            MusicRecordsManager.GetByGenre("r");
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void AddMusicRecordTest() {
            Assert.IsTrue(MusicRecordsManager.AddMusicRecord(new MusicRecord("title", "artist", 0, 0, "genre")));
        }

        [TestMethod]
        public void DeleteMusicRecordTest()
        {
            MusicRecord testRecord = new MusicRecord("title", "artist", 0, 0, "genre");
            MusicRecordsManager.AddMusicRecord(testRecord);
            Assert.IsTrue(MusicRecordsManager.DeleteMusicRecord(testRecord));
        }
    }
}
