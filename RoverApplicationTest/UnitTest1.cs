using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoverApplication;

namespace RoverApplicationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RoverExecuteMoveCommand_sucessfull()
        {
            Rover rover = new Rover();
            var currentPosition= rover.ExceuteCommand("MMM", new CurrentPosition(new Points(0, 0), Direction.North));
            Assert.AreEqual("0,3,North", string.Format("{0},{1},{2}", currentPosition.Points.X, currentPosition.Points.Y, currentPosition.Direction));
        }


        [TestMethod]
        public void RoverExecuteLeftCommand_sucessfull()
        {
            Rover rover = new Rover();
            var currentPosition = rover.ExceuteCommand("MML", new CurrentPosition(new Points(0, 1), Direction.East));
            Assert.AreEqual("2,1,North", string.Format("{0},{1},{2}", currentPosition.Points.X, currentPosition.Points.Y, currentPosition.Direction));
        }



        [TestMethod]
        public void RoverExecuteCommand_sucessfull()
        {
            Rover rover = new Rover();
            var currentPosition = rover.ExceuteCommand("MMLMRMML", new CurrentPosition(new Points(10, 5), Direction.North));
            Assert.AreEqual("9,9,West", string.Format("{0},{1},{2}", currentPosition.Points.X, currentPosition.Points.Y, currentPosition.Direction));
        }
    }
}
