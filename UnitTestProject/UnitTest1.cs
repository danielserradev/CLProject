﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;
namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
    //Arrange

    //Assemble

    //Assert

        
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
        //-------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------
        [TestMethod]
        public void Remove_RemoveValueFromList_DecreaseCount()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 3;
            int actual;


            //Assemble
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Remove(3);
            actual = testList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveValueFromList_ItemsShifted()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 3;
            int actual;


            //Assemble
            testList.Add(1);//0
            testList.Add(2);//1
            testList.Add(3);//2
            testList.Add(4);//3
            testList.Remove(2);
            actual = testList[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveValueFromListThatAppearsMoreThanOnce_CheckIfTheCorrectValueWasRemoved()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 1;
            int actual;


            //Assemble
            testList.Add(1);//0
            testList.Add(2);//1
            testList.Add(1);//2
            testList.Add(4);//3
            testList.Remove(1);
            actual = testList[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveItemFromList_CheckBool()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            bool expected = true;
            bool actual;


            //Assemble
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            actual = testList.Remove(3);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveItemFromListThatsNotThere_CheckBool()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            bool expected = false;
            bool actual;


            //Assemble
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            actual = testList.Remove(5);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveLastNumberInArray_HaveLastIndexRemoved()
        {
            CustomList<int> testList = new CustomList<int>();
            bool expected = true;
            bool actual = false;


            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Remove(4);
            try
            {
               Console.WriteLine(testList[3]);
            }
            catch(ArgumentOutOfRangeException)
            {
                actual = true;
            }
            

            Assert.AreEqual(expected, actual);

        }

    }
}
