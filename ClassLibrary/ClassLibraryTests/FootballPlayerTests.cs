using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTests
{
    [TestClass()]
    public class FootballPlayerTests
    {
        private FootballPlayer _player;

        [TestInitialize]
        public void BeforeEachTest()
        {
            _player = new FootballPlayer("Boris", 1000, 83);
        }

        [TestMethod()]
        public void FootballPlayerNameTest()
        {
            _player.Name = "Søren";

            Assert.AreEqual("Søren", _player.Name);

            _player.Name = "Mads";

            Assert.AreEqual("Mads", _player.Name);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _player.Name = "Tor");

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _player.Name = "");
        }

        [TestMethod()]
        public void FootballPlayerPriceTest()
        {
            _player.Price = 100000;

            Assert.AreEqual(100000, _player.Price);

            _player.Price = 0;

            Assert.AreEqual(0, _player.Price);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _player.Price = -1);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _player.Price = -10000);
        }

        [TestMethod()]
        public void FootballPlayerShirtNumberTest()
        {
            _player.ShirtNumber = 1;

            Assert.AreEqual(1, _player.ShirtNumber);

            _player.ShirtNumber = 50;

            Assert.AreEqual(50, _player.ShirtNumber);

            _player.ShirtNumber = 100;

            Assert.AreEqual(100, _player.ShirtNumber);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _player.ShirtNumber = 0);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _player.ShirtNumber = -1);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _player.ShirtNumber = 101);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _player.ShirtNumber = 1000);
        }

    }
}