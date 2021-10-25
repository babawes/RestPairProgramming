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
    }
}
