using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP_RoverApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverApplicationTest
{
    [TestClass]
    public class OOP_RoverApplication_Test
    {
        [TestMethod]
        public void RoverExecuteMoveCommand_sucessfull()
        {
            Rover rover = Rover.getInstance();
            var currentPosition = rover.ExceuteCommand("MMM", new Position(new Points(0, 0), Direction.North));
            Assert.AreEqual("0,3,North", string.Format("{0},{1},{2}", currentPosition.Points.X, currentPosition.Points.Y, currentPosition.Direction));
        }


        [TestMethod]
        public void RoverExecuteLeftCommand_sucessfull()
        {
            Rover rover = Rover.getInstance();
            var currentPosition = rover.ExceuteCommand("MML", new Position(new Points(0, 1), Direction.East));
            Assert.AreEqual("2,1,North", string.Format("{0},{1},{2}", currentPosition.Points.X, currentPosition.Points.Y, currentPosition.Direction));
        }



        [TestMethod]
        public void RoverExecuteCommand_sucessfull()
        {
            Rover rover = Rover.getInstance();
            var currentPosition = rover.ExceuteCommand("MMLMRMML", new Position(new Points(10, 5), Direction.North));
            Assert.AreEqual("9,9,West", string.Format("{0},{1},{2}", currentPosition.Points.X, currentPosition.Points.Y, currentPosition.Direction));
        }


        [TestMethod]
        public void AA()
        {
            Rover rover = Rover.getInstance();
            var currentPosition = rover.ExceuteCommand("MMLR", new Position(new Points(0, 3), Direction.South));
            Assert.AreEqual("0,1,South", string.Format("{0},{1},{2}", currentPosition.Points.X, currentPosition.Points.Y, currentPosition.Direction));
        }
    }
}
