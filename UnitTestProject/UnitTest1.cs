using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;
namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Example()
        {
            //Arrange

            //Assemble

            //Assert

        }
        [TestMethod]
        public void Add_AddToEmptyList_PutAtIndexZero()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 1;
            int actual;

            //Assemble
            testList.Add(1);
            actual = testList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddToList_CountLength()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 1;
            int actual;

            //Assemble
            testList.Add(123);
            actual = testList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddMiltipleItems_FillList()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 10;
            int actual;

            //Assemble
            for(int i = 0; i < 10; i++)
            {
                testList.Add(1);
            }
            actual = testList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddMultipleItemsToEmptyList_FillFromIndexZeroOn()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 2;
            int actual;

            //Assemble
            testList.Add(1);
            testList.Add(2);
            actual = testList[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddMultipleItemsToIncreaseCapacity_CheckItemFromOldArray()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 4;
            int actual;

            //Assemble
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Add(6);
            testList.Add(7);
            actual = testList[3];

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
