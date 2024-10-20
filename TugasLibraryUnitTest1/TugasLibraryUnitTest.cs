using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TugasLibrary;



namespace TugasLibraryUnitTest
{
    [TestFixture]
    public class TugasLibraryUnitTest
    {
        private User user;
        private Day day;

        [SetUp]
        public void Init()
        {
            user = new User();
            day = new Day();
        }

        [Test]
        public void UserTest()
        {
            Assert.AreEqual(true, user.IsValidUser("admin", "admin"));
        }
        [Test]
        public void DayTest()
        {
            Assert.AreEqual("Senin", day.NameOfDay(1));
            Assert.AreEqual("Selasa", day.NameOfDay(2));
            Assert.AreEqual("Rabu", day.NameOfDay(3));
            Assert.AreEqual("Kamis", day.NameOfDay(4));
            Assert.AreEqual("Jumat", day.NameOfDay(5));
            Assert.AreEqual("Sabtu", day.NameOfDay(6));
            Assert.AreEqual("Minggu", day.NameOfDay(7));
        }
    }
}
